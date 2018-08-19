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
        ImprimirValores(c2)
    End Sub

    Private Sub ImprimirValores(cliente As Cliente)
        Console.WriteLine("Apellido: " & cliente.Apellido)
        Console.WriteLine("Nombre: " & cliente.Nombre)
        Console.WriteLine("Documento: " & cliente.Documento)
        Console.WriteLine("Fecha Nacimiento: " & cliente.FechaNacimiento)
    End Sub
End Module
