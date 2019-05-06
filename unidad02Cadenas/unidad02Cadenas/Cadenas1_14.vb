Module Cadenas1_14

    Sub Main()
        Dim Palabra As String
        Dim BuscarCharA As String = "A"
        Dim BuscarCharO As String = "O"

        Console.WriteLine("Ingrese una palabra: ")
        Palabra = Console.ReadLine
        'Busqueda de A
        Console.WriteLine("Buscar {0} en {1}, en la posicion {2}", BuscarCharA, Palabra, 1)
        Console.WriteLine("La letra A aparece en la {0} posicion",
                          InStr(1, Palabra, BuscarCharA, CompareMethod.Text))
        'Busqueda de O
        Console.WriteLine("Buscar {0} en {1}, en la posicion {2}", BuscarCharO, Palabra, 1)
        Console.WriteLine("La letra O aparece en la {0} posicion",
                          InStr(1, Palabra, BuscarCharO, CompareMethod.Text))

        Console.WriteLine("Palabra Invertida: " & StrReverse(Palabra))

        Console.ReadKey()

    End Sub

End Module
