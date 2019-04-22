Imports System

Module Semanas
    Const DiasDeLaSemana As Byte = 7
    Const DiasLaborables As Byte = 5
    Const DiasDelAnio As UShort = 365
    Sub Main()

        Dim SemanasDelAnio As Single
        Dim SemanasLaborables As Single

        SemanasDelAnio = DiasDelAnio / DiasDeLaSemana
        SemanasLaborables = SemanasDelAnio * DiasLaborables / DiasDeLaSemana
        Console.WriteLine("Semanas del Año: " & SemanasDelAnio)
        Console.WriteLine("Semanas Laborables: " & SemanasLaborables)

    End Sub
End Module
