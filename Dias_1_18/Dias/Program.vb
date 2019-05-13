Imports System

Module Program
    Enum Dias
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
        Domingo = 7
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Dias de la Semana: ")
        Console.WriteLine("Dia 1 : " & Dias.Lunes.ToString())
        Console.WriteLine("Dia 2 : " & Dias.Martes.ToString())
        Console.WriteLine("Dia 3 : " & Dias.Miercoles.ToString())
        Console.WriteLine("Dia 4 : " & Dias.Jueves.ToString())
        Console.WriteLine("Dia 5 : " & Dias.Viernes.ToString())
        Console.WriteLine("Dia 6 : " & Dias.Sabado.ToString())
        Console.WriteLine("Dia 7 : " & Dias.Domingo.ToString())



    End Sub
End Module
