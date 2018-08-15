Public Class Cuenta
    Private _numero As Integer
    Private _saldo As Double

    Public Sub New()
        Me.Numero = 0
        _saldo = 0
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

    Public Sub Depositar(monto As Double)
        _saldo = Saldo + monto
    End Sub

    Public Function Extraer(monto As Double) As Boolean
        If Saldo >= monto Then
            _saldo = Saldo - monto
            Return True
        Else
            Return False
        End If
    End Function
End Class
