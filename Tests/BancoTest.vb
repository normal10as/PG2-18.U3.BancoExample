Imports Entidades

Module BancoTest
    Sub main()
        Dim icbsi As New Banco()
        icbsi.Nombre = "icbsi"
        icbsi.addCliente(New Cliente("Perez", "Juan"))
        icbsi.addCliente(New Cliente("Epson", "Pepe"))
        Dim c As New Cliente("chau", "fue")
        icbsi.addCliente(c)
        mostrarTodos(icbsi)
        icbsi.removeCliente(c)
        mostrarTodos(icbsi)
    End Sub

    Private Sub mostrarTodos(icbsi As Banco)
        For Each cliente In icbsi.GetAllClientes
            Console.WriteLine(cliente.ToString)
        Next
    End Sub
End Module
