Imports Entidades

Module BancoTest
    Sub main()
        'Dim Banco As New Banco()
        Banco.Nombre = "Eicibisi"
        Banco.addCliente(New Cliente("Perez", "Juan", 123, Today))
        Banco.addCliente(New Cliente("Epson", "Pepe", 234, Today))
        Dim c As New Cliente("chau", "fue", 345, Today)
        Banco.addCliente(c)
        mostrarTodos()
        Console.Write("Busco " & c.ToString & " ")
        Console.WriteLine(Banco.ContainsCliente(c))
        Banco.removeCliente(c)
        mostrarTodos()
        Console.Write("Busco " & c.ToString & " ")
        Console.WriteLine(Banco.ContainsCliente(c))
        Console.WriteLine(Banco.ExistsCliente(345))
        Console.WriteLine(Banco.ExistsCliente(123))
        Dim x As Cliente = Banco.FindCliente(234)
        x.Apellido = "Xerox"
        Console.WriteLine(x)
        mostrarTodos()
        Dim valor As String = "r"
        Console.WriteLine("Mostrar los " & valor)
        For Each cliente In Banco.FindClienteByNombreOrApellido(valor)
            Console.WriteLine(cliente)
        Next
    End Sub

    Private Sub mostrarTodos()
        For Each cliente In Banco.GetAllClientes
            Console.WriteLine(cliente.ToString)
        Next
    End Sub
End Module
