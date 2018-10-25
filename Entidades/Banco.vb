Public Class Banco
    Private Shared _nombre As String
    Private Shared _clientes As List(Of Cliente)

    Shared Sub New()
        Nombre = ""
        _clientes = New List(Of Cliente)
    End Sub

    Public Shared Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Shared Sub addCliente(cliente As Cliente)
        _clientes.Add(cliente)
    End Sub

    Public Shared Sub removeCliente(cliente As Cliente)
        _clientes.Remove(cliente)
    End Sub

    Public Shared Function GetAllClientes() As List(Of Cliente)
        Return _clientes
    End Function

    Public Shared Function ContainsCliente(cliente As Cliente) As Boolean
        Return _clientes.Contains(cliente)
    End Function

    Public Shared Function ExistsCliente(dni As UInteger) As Boolean
        Return _clientes.Exists(Function(c) c.Documento = dni)
    End Function

    Public Shared Function FindCliente(dni As UInteger) As Cliente
        Return _clientes.Find(Function(c) c.Documento = dni)
    End Function

    Public Shared Function FindClienteByNombreOrApellido(value As String) As List(Of Cliente)
        Return _clientes.FindAll(Function(c) c.Apellido.Contains(value) _
            Or c.Nombre.Contains(value))
    End Function
End Class
