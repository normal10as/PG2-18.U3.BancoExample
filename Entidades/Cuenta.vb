Public MustInherit Class Cuenta
    Private _numero As Integer
    Protected _saldo As Double
    Private _cliente As Cliente

    'Public Sub New()
    '    Me.New(0, 0)
    'End Sub

    'Public Sub New(Numero As Integer)
    '    Me.New(Numero, 0)
    'End Sub

    Public Sub New(Numero As Integer, Saldo As Double)
        Me.Numero = Numero
        Depositar(Saldo)
        'Me.Cliente = Cliente
    End Sub

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public ReadOnly Property Saldo As Double
        Get
            Return _saldo
        End Get
    End Property

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Friend Set(value As Cliente)
            _cliente = value
        End Set
    End Property
    Public Sub Depositar(monto As Double)
        _saldo = Saldo + monto
    End Sub

    Public Overridable Function Extraer(monto As Double) As Boolean
        If Saldo >= monto Then
            _saldo = Saldo - monto
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ToString() As String
        Return Numero
    End Function
End Class
