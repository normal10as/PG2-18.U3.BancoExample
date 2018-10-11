Imports Entidades

Module CajaDeAhorroTest
    Sub main()
        CajaDeAhorro.InteresMensual = 2
        Dim x As New Cliente("lele", "Pepe")
        'Dim c1 As New CajaDeAhorro(x, 123, 0, 2)
        Dim c1 As New CajaDeAhorro(x, 123, 0)
        'c1.Numero = 2324
        Dim c2 As New CajaDeAhorro(x, 234, 10000)
        'Dim c2 As New CajaDeAhorro(x, 234, 10000, 5)
        'c2.Numero = 1234
        Console.WriteLine("Int. menusal:" & CajaDeAhorro.InteresMensual)
        mostrarTodo(c1)
        mostrarTodo(c2)

        c1.Depositar(1000)
        c2.Depositar(3000)
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine(c1.Extraer(500))
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine(c1.Extraer(700))
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine("Saldo: " & c2.Saldo)
        c2.Capitalizar()
        Console.WriteLine("Saldo: " & c2.Saldo)

        Console.WriteLine("Cuentas de x:")
        For Each cuenta In x.getAllCuentas
            Console.WriteLine(cuenta.ToString)
        Next
    End Sub

    Private Sub mostrarTodo(c1 As CajaDeAhorro)
        Console.WriteLine("Cliente: " & c1.Cliente.ToString)
        Console.WriteLine("N° cuenta: " & c1.Numero)
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine("ToString(): " & c1.ToString())
    End Sub
End Module
