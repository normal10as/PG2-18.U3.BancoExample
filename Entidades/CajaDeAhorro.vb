Public Class CajaDeAhorro
    Inherits Cuenta

    Private _interesMensual As Single

    Sub New(numero As Integer, saldo As Double, interesMensual As Single)
        MyBase.New(numero, saldo)
        Me.InteresMensual = interesMensual
    End Sub

    Public Property InteresMensual As Single
        Get
            Return _interesMensual
        End Get
        Set(value As Single)
            _interesMensual = value
        End Set
    End Property

    Public Sub Capitalizar()
        'Depositar(Saldo * InteresMensual / 100)
        _saldo = Saldo + Saldo * InteresMensual / 100
    End Sub

    Public Overrides Function ToString() As String
        Return "C.A. " & Numero
    End Function
End Class
