Imports System

Module Concatenacion
    Sub Main()
        Dim NombreEmpresa As String
        Dim NombreCalle As String
        Dim AlturaCalle As UShort
        Dim FechaInicioActividades As Date

        Dim AlturaCallExplicita As String
        Dim FechaInicioActividadesExplicita As String



        Console.WriteLine("Ingrese el Nombre de la Empresa")
        NombreEmpresa = Console.ReadLine
        Console.WriteLine("Ingrese el Nombre de la calle")
        NombreCalle = Console.ReadLine
        Console.WriteLine("Ingrese Altura de la Calle")
        AlturaCalle = Console.ReadLine
        Console.WriteLine("Igrese la fecha de Inicio de Actividades")
        FechaInicioActividades = Console.ReadLine

        'Conversion explicita
        Console.WriteLine("Conversion Implicita")



        Console.WriteLine("Nombre de la Empresa: " & NombreEmpresa & " , " & "Inicio de Actividades: " & FechaInicioActividades)
        Console.WriteLine("Domicilio: " & NombreCalle & " " & "N°" & AlturaCalle)

        'Conversion Explicita
        Console.WriteLine("Conversion Explicita")

        FechaInicioActividadesExplicita = Convert.ToString(FechaInicioActividades)
        AlturaCallExplicita = Convert.ToString(AlturaCalle)

        Console.WriteLine("Nombre de la calle " & "ToString: " & NombreCalle)
        Console.WriteLine("Nombre de la Empresa " & "ToString: " & NombreEmpresa)
        Console.WriteLine("Altura calle: " & "ToString: " & AlturaCallExplicita)
        Console.WriteLine("Fecha Inicio de Actividades: " & FechaInicioActividadesExplicita)


    End Sub
End Module
