Imports Entidades

Public MustInherit Class Cuenta
    Implements Suspendible

    Private _activa As Boolean
    Private _numero As Integer
    Protected _saldo As Double
    Private _cliente As Cliente

    'Public Sub New()
    '    Me.New(0, 0)
    'End Sub

    'Public Sub New(Numero As Integer)
    '    Me.New(Numero, 0)
    'End Sub
    Public Sub New(cliente As Cliente, Numero As Integer)
        Me.New(cliente, Numero, 0)
    End Sub

    Public Sub New(cliente As Cliente, Numero As Integer, Saldo As Double)
        Me.Numero = Numero
        Me.Cliente = cliente
        _activa = True
        Depositar(Saldo)
    End Sub

    Protected Overrides Sub Finalize()
        Cliente.removeCuenta(Me)
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
        'Friend Set(value As Cliente)
        Set(value As Cliente)
            value.addCuenta(Me)
            _cliente = value
        End Set
    End Property
    Public Sub Depositar(monto As Double)
        If activa() Then
            _saldo = Saldo + monto
        End If
    End Sub

    Public Overridable Function Extraer(monto As Double) As Boolean
        If Saldo >= monto Then
            Return ExtraerSiActiva(monto)
        Else
            Return False
        End If
    End Function

    Protected Function ExtraerSiActiva(monto As Double) As Boolean
        If activa() Then
            _saldo = Saldo - monto
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ToString() As String
        Return Numero
    End Function

    Public Sub Suspender() Implements Suspendible.Suspender
        _activa = False
    End Sub

    Public Sub Activar() Implements Suspendible.Activar
        _activa = True
    End Sub

    Protected Function activa() As Boolean
        Return _activa And Cliente.Activo
    End Function
End Class
