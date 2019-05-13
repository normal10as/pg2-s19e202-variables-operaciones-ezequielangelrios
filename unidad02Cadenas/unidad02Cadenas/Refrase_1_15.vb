Module Refrase_1_15
    Sub Main()
        Dim Frase As String = "Aunque la cadena sea de oro, sirve para lo mismo"
        Dim Reemplazar1 As String
        Dim Reemplazar2 As String

        Console.WriteLine("Ingrese dos palabras :")
        Reemplazar1 = Console.ReadLine()
        Reemplazar2 = Console.ReadLine()
        Console.WriteLine("Frase original: {0}", Frase)
        Console.WriteLine(Replace(Frase, "Aunque", Reemplazar2))
        Console.WriteLine(Replace(Frase, "la", Reemplazar1))
        Console.ReadKey()
    End Sub
End Module
