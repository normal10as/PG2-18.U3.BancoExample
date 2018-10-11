Imports Entidades

Module CuentaTest
    Sub main()
        Dim c1 As Cuenta
        Dim x As New Cliente("lele", "Pepe")
        c1 = New CuentaCorriente(x, 123, 1000, 500)
        c1.Numero = 2324
        'c1.Cliente = New Cliente("Pepe", "guqrdiola", 325354, Now)

        Dim cc As CuentaCorriente
        cc = c1
        'cc.

        Dim c2 As Cuenta
        c2 = New CajaDeAhorro(x, 234, 5000)

        c2.Numero = 1234
        Console.WriteLine("N° cuenta: " & c1.Numero)
        Console.WriteLine("Cliente: " & c1.Cliente.ToString)
        Console.WriteLine("N° cuenta: " & c1.Numero)
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine("N° cuenta: " & c2.Numero)
        Console.WriteLine("N° cuenta: " & c2.ToString)
        Console.WriteLine("Saldo: " & c2.Saldo)
        c1.Suspender()
        c1.Depositar(1000)
        c2.Depositar(3000)
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine(c1.Extraer(500))
        Console.WriteLine("Saldo: " & c1.Saldo)
        c1.Activar()
        Console.WriteLine(c1.Extraer(700))
        Console.WriteLine("Saldo: " & c1.Saldo)
        Console.WriteLine("Saldo: " & c2.Saldo)

    End Sub
End Module
