Imports Entidades

Module ClienteTest
    Sub Main()
        ' instanciación
        Dim c1 As Cliente
        ' inicialización
        c1 = New Cliente()
        c1.Nombre = "Pepe"
        c1.Documento = "534545"
        c1.FechaNacimiento = #2000-04-20#
        Console.WriteLine("Nombre: " & c1.Nombre)
        Console.WriteLine("Documento: " & c1.Documento)
        Console.WriteLine("Fecha Nacimiento: " & c1.FechaNacimiento)

        Dim c2 As New Cliente()
        Console.WriteLine("Nombre: " & c2.Nombre)
        Console.WriteLine("Documento: " & c2.Documento)
        Console.WriteLine("Fecha Nacimiento: " & c2.FechaNacimiento)

    End Sub
End Module
