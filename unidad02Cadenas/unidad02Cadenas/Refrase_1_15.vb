Module Refrase_1_15
    Sub Main()
        Dim fecha As Date = Now

        Console.WriteLine("Es el dia {0} del año {1} ", fecha.Day, fecha.Year)
        Console.WriteLine("Mes {0} , hora y minuto {1} ", fecha.Month, fecha.TimeOfDay)
        Console.ReadKey()

    End Sub
End Module
