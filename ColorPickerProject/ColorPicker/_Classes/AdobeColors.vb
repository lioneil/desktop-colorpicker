Public Class AdobeColors

	Public Function SetBrightness(ByVal c As Color, ByVal Brightness As Double) As Color
		Dim _hsl As New HSL
		_hsl.L = Brightness
		Return HSL_to_RGB(_hsl)
	End Function
	Public Function ModifyBrightness(ByVal c As Color, ByVal Brightness As Double) As Color
		Dim _hsl As New HSL
		_hsl.L *= Brightness
		Return HSL_to_RGB(_hsl)
	End Function


	Public Function SetSaturation(ByVal c As Color, ByVal Saturation As Double) As Color
		Dim _hsl As New HSL
		_hsl.S = Saturation
		Return HSL_to_RGB(_hsl)
	End Function
	Public Function ModifySaturation(ByVal c As Color, ByVal Saturation As Double) As Color
		Dim _hsl As New HSL
		_hsl.S *= Saturation
		Return HSL_to_RGB(_hsl)
	End Function


	Public Function SetHue(ByVal c As Color, ByVal Hue As Double) As Color
		Dim _hsl As New HSL
		_hsl.H = Hue
		Return HSL_to_RGB(_hsl)
	End Function
	Public Function ModifyHue(ByVal c As Color, ByVal Hue As Double) As Color
		Dim _hsl As New HSL
		_hsl.H *= Hue
		Return HSL_to_RGB(_hsl)
	End Function

End Class


