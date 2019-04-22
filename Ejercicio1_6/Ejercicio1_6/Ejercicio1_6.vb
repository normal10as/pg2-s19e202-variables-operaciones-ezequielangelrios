Imports System

Module Ejercicio1_6
    Sub Main()
        Dim Num1, Num2, Num3, Num4 As Short
        Dim Sumar As Short
        Dim Media As Single
        Console.WriteLine("Debe ingresar Cuatro Numeros: ")
        Console.WriteLine("Ingrese el primer Numero: ")
        Num1 = Console.ReadLine
        Console.WriteLine("Ingrese el Segundo Numero: ")
        Num2 = Console.ReadLine
        Console.WriteLine("Ingrse el Tercer Numero: ")
        Num3 = Console.ReadLine
        Console.WriteLine("Ingrese el Cuarto Numero: ")
        Num4 = Console.ReadLine

        Sumar = Num1 + Num2 + Num3 + Num4
        Media = Sumar / 4
        Console.WriteLine("Sumatoria: " & Sumar)
        Console.WriteLine("Media: " & Media)
    End Sub
End Module
