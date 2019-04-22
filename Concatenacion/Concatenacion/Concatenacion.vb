Imports System

Module Concatenacion
    Sub Main()
        Dim NombreEmpresa As String
        Dim NombreCalle As String
        Dim AlturaCalle As UShort
        Dim FechaInicioActividades As Date

        Dim AlturaCalleImplicita As Integer



        Console.WriteLine("Ingrese el Nombre de la Empresa")
        NombreEmpresa = Console.ReadLine
        Console.WriteLine("Ingrese el Nombre de la calle")
        NombreCalle = Console.ReadLine
        Console.WriteLine("Ingrese Altura de la Calle")
        AlturaCalle = Console.ReadLine
        Console.WriteLine("Igrese la fecha de Inicio de Actividades")
        FechaInicioActividades = Console.ReadLine

        'Conversion Implicita
        Console.WriteLine("Conversion Implicita")

        AlturaCalleImplicita = AlturaCalle

        Console.WriteLine("Nombre de la Empresa: " & NombreEmpresa & " , " & "Inicio de Actividades: " & FechaInicioActividades)
        Console.WriteLine("Domicilio: " & NombreCalle & " " & "N°" & AlturaCalleImplicita)

        'Conversion Explicita
        Console.WriteLine("Conversion Explicita")

        NombreEmpresa = Convert.ToString("sancor")
        NombreCalle = Convert.ToString("Corrientes")
        AlturaCalle = Convert.ToByte(255)

        Console.WriteLine("Nombre de la calle " & "ToString: " & NombreCalle)
        Console.WriteLine("Nombre de la Empresa " & "ToString: " & NombreEmpresa)
        Console.WriteLine("Altura calle: " & "ToByte: " & AlturaCalle)
        Console.WriteLine("Fecha Inicio de Actividades: " & FechaInicioActividades)


    End Sub
End Module
