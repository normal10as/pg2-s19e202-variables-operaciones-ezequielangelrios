Imports System.Runtime.CompilerServices

Module Cadenas1_14
    Sub Main()
        Dim Palabra As String
        Dim BuscarChar As String = "a"
        Dim BuscarPos As Byte = 1
        Console.WriteLine("Ingrese una palabra: ")
        Palabra = Console.ReadLine
        Console.WriteLine("Buscar {0} en {1}, en la posision {2}", BuscarChar, Palabra, BuscarPos)
        Console.WriteLine(Instr(BuscarPos, Palabra, BuscarChar, CompareMethod.text))


    End Sub
End Module
