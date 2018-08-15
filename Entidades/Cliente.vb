Public Class Cliente
    Private _nombre As String
    Private _documento As UInteger
    Private _fechaNacimiento As Date

    Public Sub New()
        Nombre = "Anonimo"
        Documento = 1000
        FechaNacimiento = Date.Now()
    End Sub

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
End Class
