Imports System.Math
Module Mayor_1_13
    Sub Main()
        Dim Valor1 As Byte
        Dim Valor2 As Byte
        Dim Valor3 As Byte
        Dim Mayor12 As Byte
        Console.WriteLine("Ingrese tres valores: ")
        Valor1 = Console.ReadLine
        Valor2 = Console.ReadLine
        Valor3 = Console.ReadLine
        Mayor12 = Max(Valor1, Valor2)
        Console.WriteLine("Mayor: {0} ", Max(Mayor12, Valor3))

    End Sub
End Module
