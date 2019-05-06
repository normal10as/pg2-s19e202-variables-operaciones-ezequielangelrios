Imports System.Math
Module MatematicaI_1_11
    Sub Main()
        Dim Valor1 As Short
        Console.WriteLine("Ingrese un valor: ")
        Valor1 = Console.ReadLine
        Console.WriteLine("Valor Absoluto de {0} = {1} ", Valor1, Abs(Valor1))
        Console.WriteLine("Valor {0} elevado a la décima potencia = {1}", Valor1, Pow(Valor1, 10))
        Console.WriteLine("Raiz cuadrada de {0} = {1}", Valor1, Sqrt(Valor1))
    End Sub
End Module
