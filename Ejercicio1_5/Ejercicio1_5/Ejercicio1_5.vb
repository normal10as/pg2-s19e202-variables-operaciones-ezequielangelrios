Imports System

Module Ejercicio1_5
    Sub Main()
        Dim a, b, c As Byte
        Dim Resta As Byte
        Dim MultiplicarNumerador As Byte
        Dim MultiplicarDenomindador As Byte
        Dim Division As Single

        a = 1
        b = 5 ^ 2
        c = 2
        MultiplicarNumerador = 4 * a * c
        Resta = b - MultiplicarNumerador
        MultiplicarDenomindador = 2 * a
        Division = Resta / MultiplicarDenomindador

        Console.WriteLine("x = " & Division)





    End Sub
End Module
