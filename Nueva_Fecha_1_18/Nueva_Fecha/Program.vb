Imports System
Imports System.DateTime
Module Program
    Sub Main(args As String())
        Dim Fecha As Date
        Dim AddFecha As Byte


        Console.WriteLine("Ingrese una fecha (10/10/2019: ")
        Fecha = Console.ReadLine
        Console.WriteLine("Ingrese los dias a sumar: ")
        AddFecha = Console.ReadLine

        Console.WriteLine("La suma de las fechas ingresadas es: " & Fecha.AddDays(AddFecha))

    End Sub
End Module
