Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data
Imports System.Windows.Forms

Public Class ColorBox

	Public Event ColorBoxScrolled()

#Region " Variables and Startup"
	Public Enum eDrawStyle
		Hue
		Saturation
		Brightness
		Red
		Green
		Blue
	End Enum

	Private m_iMarker_X As Integer = 0
	Private m_iMarker_Y As Integer = 0
	Private m_MarkerColor As Color

	Private m_bDragging As Boolean = False
	Private m_eDrawStyle As eDrawStyle = eDrawStyle.Hue

	Private m_hsl As HSL
	Private m_rgb As Color

	Private m_Width As Integer
	Private m_Height As Integer


	Private Sub ColorBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		' Add any initialization after the InitializeComponent() call.
		m_hsl = New HSL
		m_hsl.H = 1
		m_hsl.S = 1
		m_hsl.L = 1

		m_rgb = HSL_to_RGB(m_hsl)
		m_eDrawStyle = eDrawStyle.Hue

		Redraw_Control()
	End Sub

	Private Sub ColorBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
		Redraw_Control()
	End Sub

	'Private Sub ColorBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
	'	Redraw_Control()
	'End Sub

#End Region

#Region " Control Events"
	Private Sub ColorBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
		If e.Button = Windows.Forms.MouseButtons.Left Then
			m_bDragging = True
			Dim x As Integer = e.X - 2
			Dim y As Integer = e.Y - 2

			If x < 0 Then x = 0
			If x > (m_Width - 4) Then x = (m_Width - 4)

			If y < 0 Then y = 0
			If y > (m_Height - 4) Then y = (m_Height - 4)

			If x <> m_iMarker_X Or y <> m_iMarker_Y Then
				DrawMarker(x, y, True)	' Redraw the marker
				ResetHSLRGB()			' Reset the color

				RaiseEvent ColorBoxScrolled()
			End If
		End If
	End Sub

	Private Sub ColorBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
		If m_bDragging Then
			Dim x As Integer = e.X - 2
			Dim y As Integer = e.Y - 2

			If x < 0 Then x = 0
			If x > (m_Width - 4) Then x = (m_Width - 4)

			If y < 0 Then y = 0
			If y > (m_Height - 4) Then y = (m_Height - 4)

			If x <> m_iMarker_X Or y <> m_iMarker_Y Then
				DrawMarker(x, y, True)	' Redraw the marker
				ResetHSLRGB()			' Reset the color

				RaiseEvent ColorBoxScrolled()
			End If
		End If
	End Sub

	Private Sub ColorBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
		If m_bDragging Then
			m_bDragging = False
			Dim x As Integer = e.X - 2
			Dim y As Integer = e.Y - 2

			If x < 0 Then x = 0
			If x > (m_Width - 4) Then x = (m_Width - 4)

			If y < 0 Then y = 0
			If y > (m_Height - 4) Then y = (m_Height - 4)

			If x <> m_iMarker_X Or y <> m_iMarker_Y Then
				DrawMarker(x, y, True)	' Redraw the marker
				ResetHSLRGB()			' Reset the color

				RaiseEvent ColorBoxScrolled()
			End If
		End If
	End Sub
#End Region

#Region " Public Methods"

	Public Property MarkerColor() As Color
		Get
			Return m_MarkerColor
		End Get
		Set(ByVal value As Color)
			m_MarkerColor = value
		End Set
	End Property

	Public Property DrawStyle() As eDrawStyle
		Get
			Return m_eDrawStyle
		End Get
		Set(ByVal value As eDrawStyle)
			m_eDrawStyle = value

			Reset_Marker(True)
			Redraw_Control()
		End Set
	End Property

	Public Property cbHSL() As HSL
		Get
			Return m_hsl
		End Get
		Set(ByVal value As HSL)
			m_hsl = value
			m_rgb = HSL_to_RGB(m_hsl)

			Reset_Marker(True)
			Redraw_Control()
		End Set
	End Property

	Public Property cbRGB() As Color
		Get
			Return m_rgb
		End Get
		Set(ByVal value As Color)
			m_rgb = value
			m_hsl = RGB_to_HSL(m_rgb)

			Reset_Marker(True)
			Redraw_Control()
		End Set
	End Property


#End Region

#Region " Private Methods"

	Private Sub ClearMarker()
		Dim g As Graphics = Me.CreateGraphics

		' Determine the area that needs to be redrawn
		Dim start_x As Integer
		Dim start_y As Integer
		Dim end_x As Integer
		Dim end_y As Integer

		Dim red As Integer = 0
		Dim green As Integer = 0
		Dim blue As Integer = 0

		Dim hsl_start As New HSL
		Dim hsl_end As New HSL

		' Find the markers corners
		start_x = m_iMarker_X - 5
		start_y = m_iMarker_Y - 5
		end_x = m_iMarker_X + 5
		end_y = m_iMarker_Y + 5

		' Adjust the area if part of it hangs outside the content area
		If start_x < 0 Then start_x = 0
		If start_y < 0 Then start_y = 0

		If end_x > (m_Width - 4) Then end_x = (m_Width - 4)
		If end_y > (m_Height - 4) Then end_y = (m_Height - 4)

		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				' Hue is constant
				hsl_start.H = m_hsl.H
				hsl_end.H = m_hsl.H

				hsl_start.S = CDbl(start_x / (m_Width - 4))		' Because we're drawing horizontal lines, s will not change
				hsl_end.S = CDbl(end_x / (m_Width - 4))			' from line to line

				For iCX As Integer = start_y To end_y
					hsl_start.L = 1.0 - CDbl(iCX / (m_Height - 4))	' Brightness (L) WILL change for each horizontal
					hsl_end.L = hsl_start.L							' line drawn

					Dim br As New LinearGradientBrush(New Rectangle(start_x + 1, iCX + 2, end_x - start_x + 1, 1), HSL_to_RGB(hsl_start), HSL_to_RGB(hsl_end), 0, False)
					g.FillRectangle(br, New Rectangle(start_x + 2, iCX + 2, end_x - start_x + 1, 1))
				Next



			Case eDrawStyle.Saturation
				' Saturation is constant
				hsl_start.S = m_hsl.S
				hsl_end.S = m_hsl.S

				hsl_start.L = 1.0 - CDbl(start_y / (m_Height - 4))	' Because we're drawing vertical lines, L will 
				hsl_end.L = 1.0 - CDbl(end_y / (m_Height - 4))		' not change from line to line

				For iCX As Integer = start_x To end_x
					hsl_start.H = CDbl(iCX / (m_Width - 4))
					hsl_end.H = hsl_start.H

					Dim br As New LinearGradientBrush(New Rectangle(iCX + 2, start_y + 1, 1, end_y - start_y + 2), HSL_to_RGB(hsl_start), HSL_to_RGB(hsl_end), 90, False)
					g.FillRectangle(br, New Rectangle(iCX + 2, start_y + 2, 1, end_y - start_y + 1))
				Next



			Case eDrawStyle.Brightness
				' Luminance is constant
				hsl_start.L = m_hsl.L
				hsl_end.L = m_hsl.L

				hsl_start.S = 1.0 - CDbl(start_y / (m_Height - 4))	' Because we're drawing vertical lines, S will 
				hsl_end.S = 1.0 - CDbl(end_y / (m_Height - 4))		' not change from line to line

				For iCX As Integer = start_x To end_x
					hsl_start.H = CDbl(iCX / (m_Width - 4))
					hsl_end.H = hsl_start.H

					Dim br As New LinearGradientBrush(New Rectangle(iCX + 2, start_y + 1, 1, end_y - start_y + 2), HSL_to_RGB(hsl_start), HSL_to_RGB(hsl_end), 90, False)
					g.FillRectangle(br, New Rectangle(iCX + 2, start_y + 2, 1, end_y - start_y + 1))
				Next


			Case eDrawStyle.Red
				red = m_rgb.R		' Red is constant
				Dim start_b As Integer = CInt(Math.Round(255 * CDbl(start_x / (m_Width - 4))))	' Because we're drawing horizontal lines, B
				Dim end_b As Integer = CInt(Math.Round(255 * CDbl(end_x / (m_Width - 4))))		' will not change from line to line

				For iCX As Integer = start_y To end_y
					green = CInt(Math.Round(255 - (255 * CDbl(iCX / (m_Height - 4)))))			' green WILL change for each horizontal line drawn
					Dim br As New LinearGradientBrush(New Rectangle(start_x + 1, iCX + 2, end_x - start_x + 1, 1), Color.FromArgb(red, green, start_b), Color.FromArgb(red, green, end_b), 0, False)
					g.FillRectangle(br, New Rectangle(start_x + 2, iCX + 2, end_x - start_x + 1, 1))
				Next

			Case eDrawStyle.Green
				green = m_rgb.G		' Green is constant
				Dim start_b As Integer = CInt(Math.Round(255 * CDbl(start_x / (m_Width - 4))))	' Because we're drawing horizontal lines, B
				Dim end_b As Integer = CInt(Math.Round(255 * CDbl(end_x / (m_Width - 4))))		' will not change from line to line

				For iCX As Integer = start_y To end_y
					red = CInt(Math.Round(255 - (255 * CDbl(iCX / (m_Height - 4)))))			' red WILL change for each horizontal line drawn
					Dim br As New LinearGradientBrush(New Rectangle(start_x + 1, iCX + 2, end_x - start_x + 1, 1), Color.FromArgb(red, green, start_b), Color.FromArgb(red, green, end_b), 0, False)
					g.FillRectangle(br, New Rectangle(start_x + 2, iCX + 2, end_x - start_x + 1, 1))
				Next

			Case eDrawStyle.Blue
				blue = m_rgb.B		' Blue is constant
				Dim start_r As Integer = CInt(Math.Round(255 * CDbl(start_x / (m_Width - 4))))	' Because we're drawing horizontal lines, R
				Dim end_r As Integer = CInt(Math.Round(255 * CDbl(end_x / (m_Width - 4))))		' will not change from line to line

				For iCX As Integer = start_y To end_y
					green = CInt(Math.Round(255 - (255 * CDbl(iCX / (m_Height - 4)))))			 ' green WILL change for each horizontal line drawn
					Dim br As New LinearGradientBrush(New Rectangle(start_x + 1, iCX + 2, end_x - start_x + 1, 1), Color.FromArgb(start_r, green, blue), Color.FromArgb(end_r, green, blue), 0, False)
					g.FillRectangle(br, New Rectangle(start_x + 2, iCX + 2, end_x - start_x + 1, 1))
				Next
		End Select

	End Sub

	Private Sub DrawMarker(ByVal x As Integer, ByVal y As Integer, ByVal unconditional As Boolean)
		If x < 0 Then x = 0
		If x > (m_Width - 4) Then x = (m_Width - 4)

		If y < 0 Then x = 0
		If y > (m_Height - 4) Then y = (m_Height - 4)

		If m_iMarker_Y = y And m_iMarker_X = x And Not unconditional Then
			Exit Sub
		End If

		ClearMarker()

		m_iMarker_X = x
		m_iMarker_Y = y

        ' The selected color will determine whether our marker is white or black
		Dim g As Graphics = Me.CreateGraphics
        Dim _hsl As HSL = GetColor(x, y)
		Dim pencil As Pen

        If _hsl.L < CDbl(200 / 255) Then
            m_MarkerColor = Color.White
        ElseIf (_hsl.H < CDbl(26 / 360)) Or (_hsl.H > CDbl(200 / 360)) Then
            If _hsl.S > CDbl(70 / 255) Then
                m_MarkerColor = Color.White
            Else
                m_MarkerColor = Color.Black
            End If
        Else
            m_MarkerColor = Color.Black
        End If

		pencil = New Pen(m_MarkerColor)
		g.DrawEllipse(pencil, x - 3, y - 3, 10, 10)	' Draw the marker : 11 x 11 circle

		DrawBorder()	' Force the border to be redrawn, just in case the marker has been drawn over it.

	End Sub

	Private Function GetColor(ByVal x As Integer, ByVal y As Integer) As HSL
		Dim _hsl As New HSL

		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				_hsl.H = m_hsl.H
				_hsl.S = CDbl(x / (m_Width - 4))
				_hsl.L = 1.0 - CDbl(y / (m_Height - 4))

			Case eDrawStyle.Saturation
				_hsl.S = m_hsl.S
				_hsl.H = CDbl(x / (m_Width - 4))
				_hsl.L = 1.0 - CDbl(y / (m_Height - 4))

			Case eDrawStyle.Brightness
				_hsl.L = m_hsl.L
				_hsl.H = CDbl(x / (m_Width - 4))
				_hsl.S = 1.0 - CDbl(y / (m_Height - 4))

			Case eDrawStyle.Red
				_hsl = RGB_to_HSL(Color.FromArgb(m_rgb.R, CInt(Math.Round(255 * (1.0 - CDbl(y / (m_Height - 4))))), CInt(Math.Round(255 * CDbl(x / (m_Width - 4))))))

			Case eDrawStyle.Green
				_hsl = RGB_to_HSL(Color.FromArgb(CInt(Math.Round(255 * (1.0 - CDbl(y / (m_Height - 4))))), m_rgb.G, CInt(Math.Round(255 * CDbl(x / (m_Width - 4))))))

			Case eDrawStyle.Blue
				_hsl = RGB_to_HSL(Color.FromArgb(CInt(Math.Round(255 * CDbl(x / (m_Width - 4)))), CInt(Math.Round(255 * (1.0 - CDbl(y / (m_Height - 4))))), m_rgb.B))

		End Select

		Return _hsl
	End Function

	Private Sub DrawBorder()
		Dim g As Graphics = Me.CreateGraphics
		Dim pencil As Pen

		pencil = New Pen(Color.FromArgb(172, 168, 153))						' The same gray color used by Photoshop
		g.DrawLine(pencil, m_Width - 2, 0, 0, 0)							' Draw top line
		g.DrawLine(pencil, 0, 0, 0, m_Height - 2)							' Draw left hand line

		pencil = New Pen(Color.White)
		g.DrawLine(pencil, m_Width - 1, 0, m_Width - 1, m_Height - 1)	' Draw right hand line
		g.DrawLine(pencil, m_Width - 1, m_Height - 1, 0, m_Height - 1)	' Draw bottome line

		pencil = New Pen(Color.Black)
		g.DrawRectangle(pencil, 1, 1, m_Width - 3, m_Height - 3)			' Draw inner black rectangle
	End Sub


	Private Sub Redraw_Control()
		m_Width = Me.Width
		m_Height = Me.Height

		DrawBorder()
		DrawContent()
		DrawMarker(m_iMarker_X, m_iMarker_Y, True)
	End Sub


	Private Sub DrawContent()
		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				Draw_Style_Hue()

			Case eDrawStyle.Saturation
				Draw_Style_Saturation()

			Case eDrawStyle.Brightness
				Draw_Style_Luminance()

			Case eDrawStyle.Red
				Draw_Style_Red()

			Case eDrawStyle.Green
				Draw_Style_Green()

			Case eDrawStyle.Blue
				Draw_Style_Blue()

		End Select
	End Sub

	Private Sub Draw_Style_Hue()
		Dim g As Graphics = Me.CreateGraphics
		Dim hsl_start As New HSL()
		Dim hsl_end As New HSL()
		If IsNothing(m_hsl) Then
			m_hsl = New HSL
			m_hsl.H = 1
			m_hsl.S = 1
			m_hsl.L = 1
			m_rgb = HSL_to_RGB(m_hsl)
		End If

		hsl_start.H = m_hsl.H
		hsl_end.H = m_hsl.H
		hsl_start.S = 0.0
		hsl_end.S = 1.0

		For i As Integer = 0 To m_Height - 4
			hsl_start.L = 1.0 - CDbl(i / (m_Height - 4)) ' Calculate luminance at this line (Hue and Saturation are constant)
			hsl_end.L = hsl_start.L

			Dim colorStart As Color = HSL_to_RGB(hsl_start)
			Dim colorEnd As Color = HSL_to_RGB(hsl_end)

			Dim br As New LinearGradientBrush(New Rectangle(2, 2, m_Width - 4, 1), colorStart, colorEnd, 0, False)
			g.FillRectangle(br, New Rectangle(2, i + 2, m_Width - 4, 1))
		Next

	End Sub

	Private Sub Draw_Style_Saturation()
		Dim g As Graphics = Me.CreateGraphics
		Dim hsl_start As New HSL()
		Dim hsl_end As New HSL()
		hsl_start.S = m_hsl.S
		hsl_end.S = m_hsl.S
		hsl_start.L = 1.0
		hsl_end.L = 0.0

		For i As Integer = 0 To m_Width - 4
			hsl_start.H = CDbl(i / (m_Width - 4))	  ' Calculate Hue at this line (Saturation and Luminance are constant)
			hsl_end.H = hsl_start.H

			Dim br As New LinearGradientBrush(New Rectangle(2, 2, 1, m_Height - 4), HSL_to_RGB(hsl_start), HSL_to_RGB(hsl_end), 90, False)
			g.FillRectangle(br, New Rectangle(i + 2, 2, 1, m_Height - 4))
		Next
	End Sub

	Private Sub Draw_Style_Luminance()
		Dim g As Graphics = Me.CreateGraphics
		Dim hsl_start As New HSL()
		Dim hsl_end As New HSL()
		hsl_start.L = m_hsl.L
		hsl_end.L = m_hsl.L
		hsl_start.S = 1.0
		hsl_end.S = 0.0

		For i As Integer = 0 To m_Width - 4
			hsl_start.H = CDbl(i / (m_Width - 4))	  ' Calculate Hue at this line (Saturation and Luminance are constant)
			hsl_end.H = hsl_start.H

			Dim br As New LinearGradientBrush(New Rectangle(2, 2, 1, m_Height - 4), HSL_to_RGB(hsl_start), HSL_to_RGB(hsl_end), 90, False)
			g.FillRectangle(br, New Rectangle(i + 2, 2, 1, m_Height - 4))
		Next
	End Sub

	Private Sub Draw_Style_Red()
		Dim g As Graphics = Me.CreateGraphics
		Dim red As Integer = m_rgb.R

		For i As Integer = 0 To m_Height - 4
			' Calculate Green at this line (Red and Blue are constant)
			Dim green As Integer = CInt(Math.Round(255 - (255 * CDbl(i / (m_Height - 4)))))
			Dim br As New LinearGradientBrush(New Rectangle(2, 2, m_Width - 4, 1), Color.FromArgb(red, green, 0), Color.FromArgb(red, green, 255), 0, False)
			g.FillRectangle(br, New Rectangle(2, i + 2, m_Width - 4, 1))
		Next
	End Sub

	Private Sub Draw_Style_Green()
		Dim g As Graphics = Me.CreateGraphics
		Dim green As Integer = m_rgb.G

		For i As Integer = 0 To m_Height - 4
			' Calculate Red at this line (Green and Blue are constant)
			Dim red As Integer = CInt(Math.Round(255 - (255 * CDbl(i / (m_Height - 4)))))
			Dim br As New LinearGradientBrush(New Rectangle(2, 2, m_Width - 4, 1), Color.FromArgb(red, green, 0), Color.FromArgb(red, green, 255), 0, False)
			g.FillRectangle(br, New Rectangle(2, i + 2, m_Width - 4, 1))
		Next
	End Sub

	Private Sub Draw_Style_Blue()
		Dim g As Graphics = Me.CreateGraphics
		Dim blue As Integer = m_rgb.B

		For i As Integer = 0 To m_Height - 4
			' Calculate Green at this line (Red and Blue are constant)
			Dim green As Integer = CInt(Math.Round(255 - (255 * CDbl(i / (m_Height - 4)))))

			Dim br As New LinearGradientBrush(New Rectangle(2, 2, m_Width - 4, 1), Color.FromArgb(0, green, blue), Color.FromArgb(255, green, blue), 0, False)
			g.FillRectangle(br, New Rectangle(2, i + 2, m_Width - 4, 1))
		Next
	End Sub

	Private Sub Reset_Marker(ByVal Redraw As Boolean)
		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				m_iMarker_X = CInt(Math.Round((m_Width - 4) * m_hsl.S))
				m_iMarker_Y = CInt(Math.Round((m_Height - 4) * (1.0 - m_hsl.L)))
			Case eDrawStyle.Saturation
				m_iMarker_X = CInt(Math.Round((m_Width - 4) * m_hsl.H))
				m_iMarker_Y = CInt(Math.Round((m_Height - 4) * (1.0 - m_hsl.L)))
			Case eDrawStyle.Brightness
				m_iMarker_X = CInt(Math.Round((m_Width - 4) * m_hsl.H))
				m_iMarker_Y = CInt(Math.Round((m_Height - 4) * (1.0 - m_hsl.S)))
			Case eDrawStyle.Red
				m_iMarker_X = CInt(Math.Round((m_Width - 4) * CDbl(m_rgb.B / 255)))
				m_iMarker_Y = CInt(Math.Round((m_Height - 4) * (1.0 - CDbl(m_rgb.G / 255))))
			Case eDrawStyle.Green
				m_iMarker_X = CInt(Math.Round((m_Width - 4) * CDbl(m_rgb.B / 255)))
				m_iMarker_Y = CInt(Math.Round((m_Height - 4) * (1.0 - CDbl(m_rgb.R / 255))))
			Case eDrawStyle.Blue
				m_iMarker_X = CInt(Math.Round((m_Width - 4) * CDbl(m_rgb.R / 255)))
				m_iMarker_Y = CInt(Math.Round((m_Height - 4) * (1.0 - CDbl(m_rgb.G / 255))))

		End Select

		If Redraw Then DrawMarker(m_iMarker_X, m_iMarker_Y, True)

	End Sub

	Private Sub ResetHSLRGB()
		Dim red As Integer
		Dim green As Integer
		Dim blue As Integer

		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				m_hsl.S = CDbl(m_iMarker_X / (m_Width - 4))
				m_hsl.L = 1.0 - CDbl(m_iMarker_Y / (m_Height - 4))
				m_rgb = HSL_to_RGB(m_hsl)

			Case eDrawStyle.Saturation
				m_hsl.H = CDbl(m_iMarker_X / (m_Width - 4))
				m_hsl.L = 1.0 - CDbl(m_iMarker_Y / (m_Height - 4))
				m_rgb = HSL_to_RGB(m_hsl)

			Case eDrawStyle.Brightness
				m_hsl.H = CDbl(m_iMarker_X / (m_Width - 4))
				m_hsl.S = 1.0 - CDbl(m_iMarker_Y / (m_Height - 4))
				m_rgb = HSL_to_RGB(m_hsl)

			Case eDrawStyle.Red
				blue = CInt(Math.Round(255 * CDbl(m_iMarker_X / (m_Width - 4))))
				green = CInt(Math.Round(255 * (1.0 - CDbl(m_iMarker_Y / (m_Height - 4)))))
				m_rgb = Color.FromArgb(m_rgb.R, green, blue)
				m_hsl = RGB_to_HSL(m_rgb)

			Case eDrawStyle.Green
				blue = CInt(Math.Round(255 * CDbl(m_iMarker_X / (m_Width - 4))))
				red = CInt(Math.Round(255 * (1.0 - CDbl(m_iMarker_Y / (m_Height - 4)))))
				m_rgb = Color.FromArgb(red, m_rgb.G, blue)
				m_hsl = RGB_to_HSL(m_rgb)

			Case eDrawStyle.Blue
				red = CInt(Math.Round(255 * CDbl(m_iMarker_X / (m_Width - 4))))
				green = CInt(Math.Round(255 * (1.0 - CDbl(m_iMarker_Y / (m_Height - 4)))))
				m_rgb = Color.FromArgb(red, green, m_rgb.B)
				m_hsl = RGB_to_HSL(m_rgb)

		End Select
	End Sub

#End Region

End Class
