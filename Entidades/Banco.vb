Public Class Banco
    Private _nombre As String
    Private _clientes As List(Of Cliente)

    Sub New()
        Nombre = ""
        _clientes = New List(Of Cliente)
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Sub addCliente(cliente As Cliente)
        _clientes.Add(cliente)
    End Sub

    Public Sub removeCliente(cliente As Cliente)
        _clientes.Remove(cliente)
    End Sub

    Public Function GetAllClientes() As List(Of Cliente)
        Return _clientes
    End Function
End Class
