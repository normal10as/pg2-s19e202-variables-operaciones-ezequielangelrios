Imports System.Math

Module Resto_Division_1_10

    Sub Main()

        Dim Valor1 As UShort
        Dim Valor2 As Byte = 4
        Console.WriteLine("Ingrese un valor: ")
        Valor1 = Console.ReadLine
        Console.WriteLine("{0} Resto {1} " & (Valor1 Mod Valor2), Valor1, Valor2)


    End Sub
End Module
