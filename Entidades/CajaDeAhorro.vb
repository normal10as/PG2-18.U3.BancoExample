Public Class CajaDeAhorro
    Inherits Cuenta

    Private Shared _interesMensual As Single

    'Sub New(cliente As Cliente, numero As Integer, saldo As Double, interesMensual As Single)
    Sub New(cliente As Cliente, numero As Integer, saldo As Double)
        MyBase.New(cliente, numero, saldo)
        'Me.InteresMensual = InteresMensual
    End Sub

    Public Shared Property InteresMensual As Single
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
