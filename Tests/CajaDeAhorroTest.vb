Imports Entidades

Module CajaDeAhorroTest
    Sub main()
        Dim c1 As New CajaDeAhorro(123, 0, 2)
        'c1.Numero = 2324
        Dim c2 As New CajaDeAhorro(234, 10000, 5)
        'c2.Numero = 1234
        Console.WriteLine("N° cuenta: " & c1.Numero)
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine("ToString(): " & c1.ToString())
        Console.WriteLine("N° cuenta: " & c2.Numero)
        Console.WriteLine("Saldo: " & c2.Saldo)
        Console.WriteLine("ToString(): " & c2.ToString())
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


    End Sub

End Module
