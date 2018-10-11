Imports Entidades

Module ClienteTest
    Sub Main()
        ' instanciación
        Dim c1 As Cliente
        ' inicialización
        c1 = New Cliente()
        ImprimirValores(c1)
        c1.Nombre = "Pepe"
        c1.Documento = "534545"
        c1.FechaNacimiento = #2000-04-20#
        ImprimirValores(c1)
        Dim c2 As New Cliente("De Arco", "Juana")
        c2.Suspender()
        Dim ca1 As New CajaDeAhorro(c2, 12323, 0)
        'c1.addCuenta(ca)
        Console.WriteLine(ca1.Cliente)
        Console.ReadKey()
        ImprimirValores(c2)
        c2.Activar()
        Dim ca2 As New CajaDeAhorro(c2, 12323, 0)
        ImprimirValores(c2)
    End Sub

    Private Sub ImprimirValores(cliente As Cliente)
        Console.WriteLine("Apellido: " & cliente.Apellido)
        Console.WriteLine("Nombre: " & cliente.Nombre)
        Console.WriteLine("Documento: " & cliente.Documento)
        Console.WriteLine("Fecha Nacimiento: " & cliente.FechaNacimiento)
        For Each cuenta In cliente.getAllCuentas()
            Console.WriteLine(cuenta)
        Next
    End Sub
End Module
