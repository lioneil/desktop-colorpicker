Imports system
Imports system.Collections
Imports system.ComponentModel
Imports system.Drawing
Imports system.Data
Imports System.Windows.Forms

Public Class VerticalColorSlider

	Public Event ColorSliderScroll()

#Region " Variables and Setup"
	Public Enum eDrawStyle
		Hue
		Saturation
		Brightness
		Red
		Green
		Blue
	End Enum

	Private m_iMarker_Start_Y As Integer = 0
	Private m_bDragging As Boolean = False
	Private m_eDrawStyle As eDrawStyle = eDrawStyle.Hue
	Private m_hsl As HSL
	Private m_rgb As Color
	Private m_Height As Integer
	Private m_Width As Integer


	Private Sub VerticalColorSlider_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		' Add any initialization after the InitializeComponent() call.
		m_hsl = New HSL
		m_hsl.H = 1
		m_hsl.S = 1
		m_hsl.L = 1

		m_rgb = HSL_to_RGB(m_hsl)
		m_eDrawStyle = eDrawStyle.Hue

		Redraw_Control()
	End Sub

#End Region

#Region " Paint and Resize"
	Private Sub VerticalColorSlider_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
		Redraw_Control()
	End Sub
	Private Sub VerticalColorSlider_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Redraw_Control()
	End Sub
#End Region

#Region " Slider Mouse Events"
	Private Sub VerticalColorSlider_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
		If e.Button = Windows.Forms.MouseButtons.Left Then
			m_bDragging = True

			Dim y As Integer = e.Y
			y -= 4
			If y < 0 Then y = 0
			If y > (m_Height - 9) Then y = (m_Height - 9)

			If y <> m_iMarker_Start_Y Then
				DrawSlider(y, False)
				ResetHSLRGB()
				RaiseEvent ColorSliderScroll()
			End If
		End If
	End Sub

	Private Sub VerticalColorSlider_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
		If m_bDragging Then
			Dim y As Integer = e.Y
			y -= 4
			If y < 0 Then y = 0
			If y > (m_Height - 9) Then y = (m_Height - 9)

			If y <> m_iMarker_Start_Y Then
				DrawSlider(y, False)
				ResetHSLRGB()
				RaiseEvent ColorSliderScroll()
			End If
		End If
	End Sub

	Private Sub VerticalColorSlider_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
		If m_bDragging Then
			m_bDragging = False

			Dim y As Integer = e.Y
			y -= 4
			If y < 0 Then y = 0
			If y > (m_Height - 9) Then y = (m_Height - 9)

			If y <> m_iMarker_Start_Y Then
				DrawSlider(y, False)
				ResetHSLRGB()
				RaiseEvent ColorSliderScroll()
			End If
		End If
	End Sub
#End Region

#Region " Painting"
	Private Sub Redraw_Control()
		m_Height = Me.Height
		m_Width = Me.Width

		DrawSlider(m_iMarker_Start_Y, True)
		Drawborder()
		DrawContent()
	End Sub

	Private Sub Reset_Slider(ByVal Redraw As Boolean)
		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				m_iMarker_Start_Y = (m_Height - 8) - CInt(Math.Round((m_Height - 8) * m_hsl.H))

			Case eDrawStyle.Saturation
				m_iMarker_Start_Y = (m_Height - 8) - CInt(Math.Round((m_Height - 8) * m_hsl.S))

			Case eDrawStyle.Brightness
				m_iMarker_Start_Y = (m_Height - 8) - CInt(Math.Round((m_Height - 8) * m_hsl.L))

			Case eDrawStyle.Red
				m_iMarker_Start_Y = (m_Height - 8) - CInt(Math.Round((m_Height - 8) * CDbl(m_rgb.R / 255)))

			Case eDrawStyle.Green
				m_iMarker_Start_Y = (m_Height - 8) - CInt(Math.Round((m_Height - 8) * CDbl(m_rgb.G / 255)))

			Case eDrawStyle.Blue
				m_iMarker_Start_Y = (m_Height - 8) - CInt(Math.Round((m_Height - 8) * CDbl(m_rgb.B / 255)))

		End Select

		If Redraw Then DrawSlider(m_iMarker_Start_Y, True)
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

	Private Sub Drawborder()
		Dim g As Graphics = Me.CreateGraphics
		Dim pencil As Pen

		pencil = New Pen(Color.FromArgb(172, 168, 153))						' The same gray color used by Photoshop
		g.DrawLine(pencil, m_Width - 10, 2, 9, 2)							' Draw top line
		g.DrawLine(pencil, 9, 2, 9, m_Height - 4)							' Draw left hand line

		pencil = New Pen(Color.White)
		g.DrawLine(pencil, m_Width - 9, 2, m_Width - 9, m_Height - 3)	' Draw right hand line
		g.DrawLine(pencil, m_Width - 9, m_Height - 3, 9, m_Height - 3)	' Draw bottome line

		pencil = New Pen(Color.Black)
		g.DrawRectangle(pencil, 10, 3, m_Width - 20, m_Height - 7)		' Draw inner black rectangle
	End Sub

	Private Sub ClearSlider()
		Dim g As Graphics = Me.CreateGraphics()
		Dim myBrush As Brush = System.Drawing.SystemBrushes.Control
		g.FillRectangle(myBrush, 0, 0, 8, m_Height)						' clear left hand slider
		g.FillRectangle(myBrush, m_Width - 8, 0, 8, m_Height)				' clear right hand slider
	End Sub

	Private Sub DrawSlider(ByVal position As Integer, ByVal unconditional As Boolean)
		If position < 0 Then position = 0
		If position > (m_Height - 9) Then position = (m_Height - 9)

		If m_iMarker_Start_Y = position And Not unconditional Then
			Exit Sub
		End If

		m_iMarker_Start_Y = position

		Me.ClearSlider()

		Dim g As Graphics = Me.CreateGraphics

		Dim pencil As New Pen(Color.FromArgb(116, 114, 106))		' Same gray Photoshop uses
		Dim WhiteBrush As Brush = Brushes.White

		Dim LeftArrow As Point() = _
		{ _
		New Point(1, position), _
		New Point(3, position), _
		New Point(7, position + 4), _
		New Point(3, position + 8), _
		New Point(1, position + 8), _
		New Point(0, position + 7), _
		New Point(0, position + 1) _
		}
		g.FillPolygon(WhiteBrush, LeftArrow)	' Fill left arrow with white
		g.DrawPolygon(pencil, LeftArrow)		' Draw left arrow border with gray

		Dim RightArrow As Point() = _
		{ _
		New Point(m_Width - 2, position), _
		New Point(m_Width - 4, position), _
		New Point(m_Width - 8, position + 4), _
		New Point(m_Width - 4, position + 8), _
		New Point(m_Width - 2, position + 8), _
		New Point(m_Width - 1, position + 7), _
		New Point(m_Width - 1, position + 1) _
		}
		g.FillPolygon(WhiteBrush, RightArrow)	' Fill right arrow with white
		g.DrawPolygon(pencil, RightArrow)		' Draw right arrow border with gray
	End Sub

	Private Sub ResetHSLRGB()
		Select Case m_eDrawStyle
			Case eDrawStyle.Hue
				m_hsl.H = 1.0 - CDbl(m_iMarker_Start_Y / (m_Height - 9))
				m_rgb = HSL_to_RGB(m_hsl)

			Case eDrawStyle.Saturation
				m_hsl.S = 1.0 - CDbl(m_iMarker_Start_Y / (m_Height - 9))
				m_rgb = HSL_to_RGB(m_hsl)

			Case eDrawStyle.Brightness
				m_hsl.L = 1.0 - CDbl(m_iMarker_Start_Y / (m_Height - 9))
				m_rgb = HSL_to_RGB(m_hsl)

			Case eDrawStyle.Red
				m_rgb = Color.FromArgb(255 - CInt(Math.Round(255 * CDbl(m_iMarker_Start_Y / (m_Height - 9)))), m_rgb.G, m_rgb.B)
				m_hsl = RGB_to_HSL(m_rgb)

			Case eDrawStyle.Green
				m_rgb = Color.FromArgb(m_rgb.R, 255 - CInt(Math.Round(255 * CDbl(m_iMarker_Start_Y / (m_Height - 9)))), m_rgb.B)
				m_hsl = RGB_to_HSL(m_rgb)

			Case eDrawStyle.Blue
				m_rgb = Color.FromArgb(m_rgb.R, m_rgb.G, 255 - CInt(Math.Round(255 * CDbl(m_iMarker_Start_Y / (m_Height - 9)))))
				m_hsl = RGB_to_HSL(m_rgb)
		End Select
	End Sub

#End Region

#Region " Content Style Drawing"

	Private Sub Draw_Style_Hue()
		Dim g As Graphics = Me.CreateGraphics
		Dim _hsl As New HSL

		_hsl.S = 1
		_hsl.L = 1
		For iCX As Integer = 0 To m_Height - 9
			_hsl.H = 1.0 - CDbl(iCX / (m_Height - 9))
			Dim myPen As New Pen(HSL_to_RGB(_hsl))
			g.DrawLine(myPen, 11, iCX + 4, m_Width - 11, iCX + 4)
		Next
	End Sub

	Private Sub Draw_Style_Saturation()
		Dim g As Graphics = Me.CreateGraphics
		Dim _hsl As New HSL

		_hsl.H = m_hsl.H
		_hsl.L = m_hsl.L
		For iCX As Integer = 0 To m_Height - 9
			_hsl.S = 1.0 - CDbl(iCX / (m_Height - 9))
			Dim myPen As New Pen(HSL_to_RGB(_hsl))
			g.DrawLine(myPen, 11, iCX + 4, m_Width - 11, iCX + 4)
		Next
	End Sub

	Private Sub Draw_Style_Luminance()
		Dim g As Graphics = Me.CreateGraphics
		Dim _hsl As New HSL

		_hsl.H = m_hsl.H
		_hsl.S = m_hsl.S
		For iCX As Integer = 0 To m_Height - 9
			_hsl.L = 1.0 - CDbl(iCX / (m_Height - 9))
			Dim myPen As New Pen(HSL_to_RGB(_hsl))
			g.DrawLine(myPen, 11, iCX + 4, m_Width - 11, iCX + 4)
		Next
	End Sub

	Private Sub Draw_Style_Red()
		Dim g As Graphics = Me.CreateGraphics
		For iCX As Integer = 0 To m_Height - 9
			Dim _red As Integer = CInt(255 - Math.Round(255 * CDbl(iCX / (m_Height - 9))))
			Dim myPen As New Pen(Color.FromArgb(_red, m_rgb.G, m_rgb.B))
			g.DrawLine(myPen, 11, iCX + 4, m_Width - 11, iCX + 4)
		Next
	End Sub

	Private Sub Draw_Style_Green()
		Dim g As Graphics = Me.CreateGraphics
		For iCX As Integer = 0 To m_Height - 9
			Dim _green As Integer = CInt(255 - Math.Round(255 * CDbl(iCX / (m_Height - 9))))
			Dim myPen As New Pen(Color.FromArgb(m_rgb.R, _green, m_rgb.B))
			g.DrawLine(myPen, 11, iCX + 4, m_Width - 11, iCX + 4)
		Next
	End Sub

	Private Sub Draw_Style_Blue()
		Dim g As Graphics = Me.CreateGraphics
		For iCX As Integer = 0 To m_Height - 9
			Dim _blue As Integer = CInt(255 - Math.Round(255 * CDbl(iCX / (m_Height - 9))))
			Dim myPen As New Pen(Color.FromArgb(m_rgb.R, m_rgb.G, _blue))
			g.DrawLine(myPen, 11, iCX + 4, m_Width - 11, iCX + 4)
		Next
	End Sub

#End Region

#Region " Public Methods"

	Public Property DrawStyle() As eDrawStyle
		Get
			Return m_eDrawStyle
		End Get
		Set(ByVal value As eDrawStyle)
			m_eDrawStyle = value

			Reset_Slider(True)
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

			Reset_Slider(True)
			Redraw_Control()
		End Set
	End Property

	Public Property RGB() As Color
		Get
			Return m_rgb
		End Get
		Set(ByVal value As Color)
			m_rgb = value
			m_hsl = RGB_to_HSL(m_rgb)

			Reset_Slider(True)
			Redraw_Control()
		End Set
	End Property

#End Region

End Class
