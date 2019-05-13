Imports System
Imports System.DateTime

Module Program
    Sub Main(args As String())
        Dim Dia As Date = #2019/05/13#
        Dim Hora As Date = #10:23:03 PM#
        Dim AjustarReloj As Date
        AjustarReloj = New DateTime(2019, 5, 13, 9, 22, 33)
        Console.WriteLine("Dia : " & AjustarReloj.Day)
        Console.WriteLine("Hora: " & AjustarReloj.Hour)
        Console.WriteLine("Mes y Año: " & Now.Month & "/" & Now.Year)
    End Sub
End Module
