Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


''' <summary>
''' Very special thanks goes out to Danny Blanchard who wrote the original C# control some two years ago.
''' Without his original control to model off of - writing my own vb.net version would have been considerably 
''' more difficult.  
''' 
''' Where the original code worked well, I did nothing more than convert from C# to vb.net.
''' Where I found problems with the original code, I made the necessary corrections.
''' 
''' Thanks again Danny!
''' </summary>
''' <remarks></remarks>


Public Class cp

#Region " Variables and Public Properties"

    Public Event ColorPickerChanged(ByVal _rgb As Color, ByVal _markercolor As Color)

    Private _HeaderText As String = "Color Picker"
    Private _DialogLabel As String = "Select Foreground Color"

    Private _ColorBox As New ColorBox
    Private _ColorSlider As New VerticalColorSlider
    Private _HSL As HSL
    Private _RGB As Color
    Private _CMYK As CMYK

    Public Property RGB() As Color
        Get
            Return _RGB
        End Get
        Set(ByVal value As Color)
            _RGB = value
            _HSL = RGB_to_HSL(_RGB)
            _CMYK = RGB_to_CMYK(_RGB)

            _ColorSlider.cbHSL = _HSL
            ColorSlider_Scrolled()

            OriginalColorLabel.BackColor = _ColorBox.cbRGB
            OriginalColorLabel.ForeColor = _ColorBox.MarkerColor
        End Set
    End Property

    Public Property HeaderText() As String
        Get
            Return _HeaderText
        End Get
        Set(ByVal value As String)
            _HeaderText = value
            Me.Text = _HeaderText
        End Set
    End Property

    Public Property DialogLabel() As String
        Get
            Return _DialogLabel
        End Get
        Set(ByVal value As String)
            _DialogLabel = value
            SelectLabel.Text = _DialogLabel
        End Set
    End Property

#End Region

#Region " Private Methods "

    Private Sub UpdateControls()
        If SelectedColorLabel.ForeColor <> _ColorBox.MarkerColor Then
            SelectedColorLabel.ForeColor = _ColorBox.MarkerColor
        End If

        ' The refreshes are required in order to produce a more realtime effect.
        SelectedColorLabel.BackColor = _RGB
        SelectedColorLabel.Refresh()

        HueText.Text = Math.Round(_HSL.H * 360).ToString()
        HueText.Tag = _HSL.H.ToString
        HueText.Refresh()

        SaturationText.Text = Math.Round(_HSL.S * 100).ToString()
        SaturationText.Tag = _HSL.S.ToString
        SaturationText.Refresh()

        BrightnessText.Text = Math.Round(_HSL.L * 100).ToString()
        BrightnessText.Tag = _HSL.L.ToString
        BrightnessText.Refresh()

        RedText.Text = _RGB.R.ToString()
        RedText.Refresh()

        GreenText.Text = _RGB.G.ToString()
        GreenText.Refresh()

        BlueText.Text = _RGB.B.ToString()
        BlueText.Refresh()

        CyanLabel.Text = Math.Round(_CMYK.C * 100).ToString()
        CyanLabel.Refresh()

        MagentaLabel.Text = Math.Round(_CMYK.M * 100).ToString()
        MagentaLabel.Refresh()

        YellowLabel.Text = Math.Round(_CMYK.Y * 100).ToString()
        YellowLabel.Refresh()

        BlackLabel.Text = Math.Round(_CMYK.K * 100).ToString()
        BlackLabel.Refresh()

        HexColorText.Text = WriteHexData(_RGB)
        HexColorText.Refresh()

        RaiseEvent ColorPickerChanged(_RGB, _ColorBox.MarkerColor)

    End Sub

	Private Sub ColorBox_Scrolled()
		_HSL = _ColorBox.cbHSL
		_RGB = HSL_to_RGB(_HSL)
        _CMYK = RGB_to_CMYK(_RGB)

        UpdateControls()
	End Sub

	Private Sub ColorSlider_Scrolled()
		_HSL = _ColorSlider.cbHSL
		_RGB = HSL_to_RGB(_HSL)
		_CMYK = RGB_to_CMYK(_RGB)
        _ColorBox.cbHSL = _HSL

        UpdateControls()
	End Sub

	Private Function WriteHexData(ByVal c As Color) As String
		Dim ReturnString As String = ""

		Dim red As String = Convert.ToString(RGB.R, 16)
		If red.Length < 2 Then red = "0" & red

		Dim green As String = Convert.ToString(RGB.G, 16)
		If green.Length < 2 Then green = "0" & green

		Dim blue As String = Convert.ToString(RGB.B, 16)
		If blue.Length < 2 Then blue = "0" & blue

		ReturnString = red.ToUpper & green.ToUpper & blue.ToUpper

		Return ReturnString
	End Function

	Private Function ParseHexString(ByVal hex_data As String) As Color
		If hex_data.Length <> 6 Then
			Return Color.Black
			Exit Function
		End If

		Dim r_text As String
		Dim g_text As String
		Dim b_text As String

		Dim r As Integer
		Dim g As Integer
		Dim b As Integer

		r_text = hex_data.Substring(0, 2)
		g_text = hex_data.Substring(2, 2)
		b_text = hex_data.Substring(4, 2)

		Try
			r = Integer.Parse(r_text, System.Globalization.NumberStyles.HexNumber)
			g = Integer.Parse(g_text, System.Globalization.NumberStyles.HexNumber)
			b = Integer.Parse(b_text, System.Globalization.NumberStyles.HexNumber)

		Catch ex As Exception
			r = 0
			g = 0
			b = 0

		End Try

		Return Color.FromArgb(r, g, b)
    End Function


    Private Function ValidKey(ByVal KeyCode As Integer) As Boolean
        Select Case KeyCode
            Case 8, 48 To 57
                Return True

            Case Else
                Return False
        End Select
    End Function

#End Region



#Region " Radio Buttons"

	Private Sub HueRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HueRadio.CheckedChanged
		_ColorBox.DrawStyle = ColorBox.eDrawStyle.Hue
		_ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Hue
	End Sub

	Private Sub SaturationRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaturationRadio.CheckedChanged
		_ColorBox.DrawStyle = ColorBox.eDrawStyle.Saturation
		_ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Saturation
	End Sub

	Private Sub BrightnessRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrightnessRadio.CheckedChanged
		_ColorBox.DrawStyle = ColorBox.eDrawStyle.Brightness
		_ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Brightness
	End Sub

	Private Sub RedRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedRadio.CheckedChanged
		_ColorBox.DrawStyle = ColorBox.eDrawStyle.Red
		_ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Red
	End Sub

	Private Sub GreenRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenRadio.CheckedChanged
		_ColorBox.DrawStyle = ColorBox.eDrawStyle.Green
		_ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Green
	End Sub

	Private Sub BlueRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueRadio.CheckedChanged
		_ColorBox.DrawStyle = ColorBox.eDrawStyle.Blue
		_ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Blue
	End Sub

#End Region

#Region " Hex Values "

	Private _HexChanging As Boolean = False
	Private Sub HexColorText_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HexColorText.GotFocus
		_HexChanging = True
		HexColorText.SelectAll()
	End Sub

    Private Sub HexColorText_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HexColorText.LostFocus
        _HexChanging = False
    End Sub

    Private Sub HexColorText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HexColorText.Leave
        If HexColorText.Text.Length = 6 Then
            _RGB = ParseHexString(HexColorText.Text)
            _HSL = RGB_to_HSL(_RGB)
            _CMYK = RGB_to_CMYK(_RGB)

            _ColorBox.cbHSL = _HSL
            _ColorSlider.cbHSL = _HSL
            UpdateControls()
        End If
    End Sub

#End Region

#Region " H S L "

    Private _EditHSL As Boolean = False
    Private Sub HueText_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles HueText.GotFocus
        _EditHSL = True
        HueText.SelectAll()
    End Sub
    Private Sub HueText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HueText.TextChanged
        If _EditHSL Then
            If HueText.Text = "" Then
                HueText.Text = "0"
                HueText.SelectAll()
            End If
            HueText.Tag = CDbl(CInt(HueText.Text) / 360)
        End If
    End Sub
    Private Sub HueText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HueText.KeyDown
        If Not ValidKey(e.KeyValue) Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub HueText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HueText.Leave
        If Mid(HueText.Tag.ToString, 1, 8) <> Mid(_HSL.H.ToString, 1, 8) Then
            If IsNumeric(HueText.Text) Then
                Dim hValue As Integer = CInt(HueText.Text)
                If hValue < 0 Or hValue > 360 Then
                    MsgBox("Hue must be between 0 and 360" & Chr(13) & "Selecting the nearest Value.")
                    If hValue < 0 Then hValue = 0
                    If hValue > 360 Then hValue = 360
                End If

                _HSL.H = CDbl(hValue / 360)
                HueText.Tag = _HSL.H.ToString
                _ColorBox.cbHSL = _HSL
                _ColorSlider.cbHSL = _HSL
                _RGB = _ColorBox.cbRGB
                UpdateControls()
            End If
        End If
        _EditHSL = False
    End Sub


    Private Sub SaturationText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SaturationText.KeyUp
        If ValidKey(e.KeyValue) Then
            SaturationText.Tag = CDbl(CInt(SaturationText.Text) / 100)
        End If
    End Sub
    Private Sub SaturationText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaturationText.Leave
        If Mid(SaturationText.Tag.ToString, 1, 8) <> Mid(_HSL.S.ToString, 1, 8) Then
            If IsNumeric(SaturationText.Text) Then
                Dim hValue As Integer = CInt(SaturationText.Text)
                If hValue < 0 Or hValue > 100 Then
                    MsgBox("Saturation must be between 0 and 100" & Chr(13) & "Selecting the nearest Value.")
                    If hValue < 0 Then hValue = 0
                    If hValue > 100 Then hValue = 100
                End If

                _HSL.S = CDbl(hValue / 100)
                SaturationText.Tag = _HSL.S.ToString
                _ColorBox.cbHSL = _HSL
                _ColorSlider.cbHSL = _HSL
                _RGB = _ColorBox.cbRGB
                UpdateControls()
            End If
        End If
    End Sub

    Private Sub BrightnessText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BrightnessText.KeyUp
        If ValidKey(e.KeyValue) Then
            BrightnessText.Tag = CDbl(CInt(BrightnessText.Text) / 100)
        End If
    End Sub
    Private Sub BrightnessText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrightnessText.Leave
        If Mid(BrightnessText.Tag.ToString, 1, 8) <> Mid(_HSL.L.ToString, 1, 8) Then
            If IsNumeric(BrightnessText.Text) Then
                Dim hValue As Integer = CInt(BrightnessText.Text)
                If hValue < 0 Or hValue > 100 Then
                    MsgBox("Luminesce must be between 0 and 100" & Chr(13) & "Selecting the nearest Value.")
                    If hValue < 0 Then hValue = 0
                    If hValue > 100 Then hValue = 100
                End If

                _HSL.L = CDbl(hValue / 100)
                BrightnessText.Tag = _HSL.L.ToString
                _ColorBox.cbHSL = _HSL
                _ColorSlider.cbHSL = _HSL
                _RGB = HSL_to_RGB(_HSL)
                UpdateControls()
            End If
        End If
    End Sub

#End Region

#Region " R G B "

    Private Sub RedText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedText.Leave
        If IsNumeric(RedText.Text) Then
            Dim hValue As Integer = CInt(RedText.Text)
            If hValue < 0 Or hValue > 255 Then
                MsgBox("Red must be between 0 and 255" & Chr(13) & "Selecting the nearest Value.")
                If hValue < 0 Then hValue = 0
                If hValue > 255 Then hValue = 255
            End If

            ' Calculate the new color
            Dim myColor As Color = Color.FromArgb(hValue, Me.RGB.G, Me.RGB.B)

            ' Update my color values
            _RGB = myColor
            _HSL = RGB_to_HSL(_RGB)
            _ColorSlider.cbHSL = _HSL
            _ColorBox.cbHSL = _HSL
            UpdateControls()
        End If
    End Sub

	Private Sub GreenText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GreenText.Leave
		If IsNumeric(GreenText.Text) Then
			Dim hValue As Integer = CInt(GreenText.Text)
			If hValue < 0 Or hValue > 255 Then
				MsgBox("Green must be between 0 and 255" & Chr(13) & "Selecting the nearest Value.")
				If hValue < 0 Then hValue = 0
				If hValue > 255 Then hValue = 255
			End If

            ' Calculate the new color
            Dim myColor As Color = Color.FromArgb(Me.RGB.R, hValue, Me.RGB.B)

            ' Update my color values
            _RGB = myColor
            _HSL = RGB_to_HSL(_RGB)
            _ColorSlider.cbHSL = _HSL
            _ColorBox.cbHSL = _HSL
            UpdateControls()
        End If
    End Sub

	Private Sub BlueText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BlueText.Leave
		If IsNumeric(BlueText.Text) Then
			Dim hValue As Integer = CInt(BlueText.Text)
			If hValue < 0 Or hValue > 255 Then
				MsgBox("Blue must be between 0 and 255" & Chr(13) & "Selecting the nearest Value.")
				If hValue < 0 Then hValue = 0
				If hValue > 255 Then hValue = 255
			End If

            ' Calculate the new color
            Dim myColor As Color = Color.FromArgb(Me.RGB.R, Me.RGB.G, hValue)

            ' Update my color values
            _RGB = myColor
            _HSL = RGB_to_HSL(_RGB)
            _ColorSlider.cbHSL = _HSL
            _ColorBox.cbHSL = _HSL
            UpdateControls()
        End If
    End Sub

#End Region

#Region " Control Load"

    ''' <summary>
    ''' We'll create the two additional custom controls and add them to our main control here.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Add any initialization after the InitializeComponent() call.
        _ColorBox.Top = 30
        _ColorBox.Left = 10
        _ColorBox.Height = 235
        _ColorBox.Width = 250
        _ColorBox.DrawStyle = ColorBox.eDrawStyle.Hue
        _ColorBox.TabStop = False
        Me.Controls.Add(_ColorBox)
        AddHandler _ColorBox.ColorBoxScrolled, AddressOf ColorBox_Scrolled

        ' Add the slider
        _ColorSlider.Top = 28
        _ColorSlider.Left = 262
        _ColorSlider.Height = 239
        _ColorSlider.Width = 40
        _ColorSlider.DrawStyle = VerticalColorSlider.eDrawStyle.Hue
        _ColorSlider.TabStop = False
        Me.Controls.Add(_ColorSlider)
        AddHandler _ColorSlider.ColorSliderScroll, AddressOf ColorSlider_Scrolled

        HueRadio.Checked = True
        HueRadio.TabStop = False

        If IsNothing(_RGB) Then
            Me.RGB = Color.White
        Else
            Me.RGB = _RGB
        End If

        Me.Text = _HeaderText

        ' Set our original color...the RGB property will already set the 'Startup'
        SelectedColorLabel.BackColor = _ColorBox.cbRGB
        SelectedColorLabel.ForeColor = _ColorBox.MarkerColor

        RedText.Focus()
    End Sub

    Private Sub OriginalColorLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginalColorLabel.Click
        Me.RGB = OriginalColorLabel.BackColor
    End Sub

#End Region



#Region " Command Buttons"
	Private Sub Ok_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
		Me.Hide()
	End Sub
#End Region

End Class
