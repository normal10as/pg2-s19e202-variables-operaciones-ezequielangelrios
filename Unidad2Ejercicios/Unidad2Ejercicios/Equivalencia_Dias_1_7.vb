Imports System

Module Equivalencia_Dias_1_7
    Const DiasPorSemana As Byte = 7
    Const HorasPorDia As Byte = 24
    Const MinutosPorHora As Byte = 60
    Sub Main()
        Dim IngresoDias As UShort
        Dim NumeroDeSemanas As UShort
        Dim NumeroHoras As UShort
        Dim NumeroMinutos As UInteger

        Console.WriteLine("Ingrese numero de dias: ")
        IngresoDias = Console.ReadLine
        NumeroDeSemanas = IngresoDias / DiasPorSemana
        NumeroHoras = IngresoDias * HorasPorDia
        NumeroMinutos = IngresoDias * HorasPorDia * MinutosPorHora
        Console.WriteLine("Numero de dias {0}, total de semanas {1}, total de horas {2}, total de minutos {3}
        ", IngresoDias, NumeroDeSemanas, NumeroHoras, NumeroMinutos)





    End Sub
End Module
