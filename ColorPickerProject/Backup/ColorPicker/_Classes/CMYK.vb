Public Class CMYK
	Private _C As Double = 0
	Private _M As Double = 0
	Private _Y As Double = 0
	Private _K As Double = 0

	Public Property C() As Double
		Get
			Return _C
		End Get
		Set(ByVal value As Double)
			_C = value
			If _C < 0 Then
				_C = 0
			ElseIf _C > 1 Then
				_C = 1
			End If
		End Set
	End Property

	Public Property M() As Double
		Get
			Return _M
		End Get
		Set(ByVal value As Double)
			_M = value
			If _M < 0 Then
				_M = 0
			ElseIf _M > 1 Then
				_M = 1
			End If
		End Set
	End Property

	Public Property Y() As Double
		Get
			Return _Y
		End Get
		Set(ByVal value As Double)
			_Y = value
			If _Y < 0 Then
				_Y = 0
			ElseIf _Y > 1 Then
				_Y = 1
			End If
		End Set
	End Property

	Public Property K() As Double
		Get
			Return _K
		End Get
		Set(ByVal value As Double)
			_K = value
			If _K < 0 Then
				_K = 0
			ElseIf _K > 1 Then
				_K = 1
			End If
		End Set
	End Property

End Class