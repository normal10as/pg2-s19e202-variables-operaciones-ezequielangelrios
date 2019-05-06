Imports System.Math
Module Redondeo_1_12
    Sub Main()
        Dim Valor1 As Double
        Console.WriteLine("Ingrese un valor: ")
        Valor1 = Console.ReadLine
        Console.WriteLine("Valor aproximado por Exceso de {0} = {1}", Valor1, Ceiling(Valor1))
        Console.WriteLine("Valor aproximado por Defecto de {0} = {1}", Valor1, Floor(Valor1))
        Console.WriteLine("Valor Redondeado de {0} = {1}", Valor1, Round(Valor1))
    End Sub
End Module
