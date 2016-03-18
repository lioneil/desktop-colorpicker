Public Class HSL
	Private _H As Double = 0
	Private _S As Double = 0
	Private _L As Double = 0

	Public Property H() As Double
		Get
			Return _H
		End Get
		Set(ByVal value As Double)
			_H = value
			If _H < 0 Then
				_H = 0
			ElseIf _H > 1 Then
				_H = 1
			End If
		End Set
	End Property

	Public Property S() As Double
		Get
			Return _S
		End Get
		Set(ByVal value As Double)
			_S = value
			If _S < 0 Then
				_S = 0
			ElseIf _S > 1 Then
				_S = 1
			End If
		End Set
	End Property

	Public Property L() As Double
		Get
			Return _L
		End Get
		Set(ByVal value As Double)
			_L = value
			If _L < 0 Then
				_L = 0
			ElseIf _L > 1 Then
				_L = 1
			End If
		End Set
	End Property
End Class
