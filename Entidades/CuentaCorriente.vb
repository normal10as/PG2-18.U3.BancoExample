Public Class CuentaCorriente
    Inherits Cuenta

    Private _montoSobregiro As Double

    Sub New(cliente As Cliente, Numero As Integer, saldo As Double, montoSobregiro As Double)
        MyBase.New(cliente, Numero, saldo)
        Me.MontoSobregiro = montoSobregiro
    End Sub

    Public Property MontoSobregiro As Double
        Get
            Return _montoSobregiro
        End Get
        Set(value As Double)
            _montoSobregiro = value
        End Set
    End Property

    Public Overrides Function Extraer(monto As Double) As Boolean
        If Saldo + MontoSobregiro >= monto Then
            Return ExtraerSiActiva(monto)
        Else
            Return False
        End If
    End Function

    Public Overrides Function ToString() As String
        Return "C.C." & Numero
    End Function
End Class
