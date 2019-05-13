Imports System
Imports System.DateTime
Module Program
    Sub Main(args As String())
        Dim Fecha As Date
        Dim NuevaFecha As Byte


        Console.WriteLine("Ingrese una fecha (10/10/2019: ")
        Fecha = Console.ReadLine
        Console.WriteLine("Ingrese los dias a sumar: ")
        NuevaFecha = Console.ReadLine

        Console.WriteLine("La suma de las fechas ingresadas es: " & Fecha.AddDays(NuevaFecha))

    End Sub
End Module
