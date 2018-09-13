Public Class Cliente
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger
    Private _fechaNacimiento As Date

    Public Sub New()
        Me.Apellido = "Alcoholico"
        Nombre = "Anonimo"
        Documento = 1000
        FechaNacimiento = Date.Now()
    End Sub

    Public Sub New(Apellido As String, Nombre As String)
        Me.New()
        Me.Apellido = Apellido
        Me.Nombre = Nombre
    End Sub

    Public Sub New(Apellido As String, Nombre As String, Documento As UInteger, FechaNacimiento As Date)
        Me.New(Apellido, Nombre)
        Me.Documento = Documento
        Me.FechaNacimiento = FechaNacimiento
    End Sub

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Apellido & " " & Nombre
    End Function
End Class
