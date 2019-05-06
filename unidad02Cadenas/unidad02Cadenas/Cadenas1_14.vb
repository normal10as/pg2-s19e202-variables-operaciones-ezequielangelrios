Module Cadenas1_14

    Sub Main()
        Dim Palabra As String
        Dim BuscarCharA As String = "a"
        Dim BuscarCharO As String = "o"
        Dim BuscarPos As Byte = 1
        Console.WriteLine("Ingrese una palabra: ")
        Palabra = Console.ReadLine
        'Busqueda de A
        Console.WriteLine("Buscar {0} en {1}, en la posicion {2}", BuscarCharA, Palabra, BuscarPos)
        Console.WriteLine("La letra a aparece en la {0} posicion",
                          InStr(BuscarPos, Palabra, BuscarCharA, CompareMethod.Text))
        'Busqueda de O
        Console.WriteLine("Buscar {0} en {1}, en la posicion {2}", BuscarCharO, Palabra, BuscarPos)
        Console.WriteLine("La letra a aparece en la {0} posicion",
                          InStr(BuscarPos, Palabra, BuscarCharO, CompareMethod.Text))



        Console.ReadKey()

    End Sub

End Module
