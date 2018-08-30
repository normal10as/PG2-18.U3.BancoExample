﻿Public Class CuentaCorriente
    Inherits Cuenta

    Private _montoSobregiro As Double

    Sub New(Numero As Integer, saldo As Double, montoSobregiro As Double)
        MyBase.New(Numero, saldo)
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
            _saldo = Saldo - monto
            Return True
        Else
            Return False
        End If
    End Function
End Class
