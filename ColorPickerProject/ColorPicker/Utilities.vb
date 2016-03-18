Module Utilities

	Public Function RGB_to_HSL(ByVal c As Color) As HSL
		Dim _hsl As New HSL

		Dim _max As Integer
		Dim _min As Integer
		Dim _diff As Integer
		Dim _sum As Integer

		' Of the RBG Values - assign the highest value to _Max and the lowest to _min
		If c.R > c.G Then
			_max = c.R
			_min = c.G
		Else
			_max = c.G
			_min = c.R
		End If
		If c.B > _max Then _max = c.B
		If c.B < _min Then _min = c.B

		_diff = _max - _min
		_sum = _max + _min


		' Luminance (aka Brightness)
		_hsl.L = CDbl(_max / 255)


		' Saturation
		If _max = 0 Then
			_hsl.S = 0
		Else
			_hsl.S = CDbl(_diff / _max)
		End If


		' Hue
		' R is situated at the angle of 360 eller noll degrees
		' G vid 120 degrees
		' B vid 240 degrees
		Dim _Q As Double
		If _diff = 0 Then
			_Q = 0
		Else
			_Q = CDbl(60 / _diff)
		End If


		If _max = CInt(c.R) Then
			If CInt(c.G) < CInt(c.B) Then
				_hsl.H = CDbl(360 + (_Q * (CInt(c.G) - CInt(c.B)))) / 360
			Else
				_hsl.H = CDbl(_Q * (CInt(c.G) - CInt(c.B))) / 360
			End If

		ElseIf _max = CInt(c.G) Then
			_hsl.H = CDbl(120 + (_Q * (CInt(c.B) - CInt(c.R)))) / 360

		ElseIf _max = CInt(c.B) Then
			_hsl.H = CDbl(240 + (_Q * (CInt(c.R) - CInt(c.G)))) / 360

		End If


		Return _hsl
	End Function

	Public Function HSL_to_RGB(ByVal _hsl As HSL) As Color
		Dim _max As Integer
		Dim _min As Integer
		Dim _mid As Integer
		Dim _q As Double

		_max = CInt(Math.Round(_hsl.L * 255))
		_min = CInt(Math.Round((1.0 - _hsl.S) * (_hsl.L / 1.0) * 255))
		_q = CDbl((_max - _min) / 255)

		If _hsl.H >= 0 And _hsl.H <= CDbl(1 / 6) Then
			_mid = CInt(Math.Round(((_hsl.H - 0) * _q) * 1530 + _min))
			Return Color.FromArgb(_max, _mid, _min)

		ElseIf _hsl.H <= CDbl(1 / 3) Then
			_mid = CInt(Math.Round(-((_hsl.H - CDbl(1 / 6)) * _q) * 1530 + _max))
			Return Color.FromArgb(_mid, _max, _min)

		ElseIf _hsl.H <= 0.5 Then
			_mid = CInt(Math.Round(((_hsl.H - CDbl(1 / 3)) * _q) * 1530 + _min))
			Return Color.FromArgb(_min, _max, _mid)

		ElseIf _hsl.H <= CDbl(2 / 3) Then
			_mid = CInt(Math.Round(-((_hsl.H - 0.5) * _q) * 1530 + _max))
			Return Color.FromArgb(_min, _mid, _max)

		ElseIf _hsl.H <= CDbl(5 / 6) Then
			_mid = CInt(Math.Round(((_hsl.H - CDbl(2 / 3)) * _q) * 1530 + _min))
			Return Color.FromArgb(_mid, _min, _max)

		ElseIf _hsl.H <= 1.0 Then
			_mid = CInt(Math.Round(-((_hsl.H - CDbl(5 / 6)) * _q) * 1530 + _max))
			Return Color.FromArgb(_max, _min, _mid)
        Else
            Return Color.FromArgb(0, 0, 0)
		End If
	End Function

	Public Function RGB_to_CMYK(ByVal c As Color) As CMYK
		Dim _cmyk As New CMYK
		Dim _low As Double = 1

		_cmyk.C = CDbl((255 - c.R) / 255)
		If _low > _cmyk.C Then _low = _cmyk.C

		_cmyk.M = CDbl((255 - c.G) / 255)
		If _low > _cmyk.M Then _low = _cmyk.M

		_cmyk.Y = CDbl((255 - c.B) / 255)
		If _low > _cmyk.Y Then _low = _cmyk.Y

		If _low > 0 Then _cmyk.K = _low

		Return _cmyk
	End Function

	Public Function CMYK_to_RGB(ByVal _cmyk As CMYK) As Color
		Dim _red As Integer
		Dim _green As Integer
		Dim _blue As Integer

		' To convert CMYK to RGB we first have to convert CMYK to CMY
		Dim _Cyan As Double = (_cmyk.C * (1 - _cmyk.K)) + _cmyk.K
		Dim _Magenta As Double = (_cmyk.M * (1 - _cmyk.K)) + _cmyk.K
		Dim _Yellow As Double = (_cmyk.Y * (1 - _cmyk.K)) + _cmyk.K

		'_red = CInt(Math.Round(255 - (255 * _Cyan)))
		'_green = CInt(Math.Round(255 - (255 * _Magenta)))
		'_blue = CInt(Math.Round(255 - (255 * _Yellow)))

		_red = CInt(Math.Round(_Cyan * 255))
		_green = CInt(Math.Round(_Magenta * 255))
		_blue = CInt(Math.Round(_Yellow * 255))

		Return Color.FromArgb(_red, _green, _blue)

	End Function

End Module
