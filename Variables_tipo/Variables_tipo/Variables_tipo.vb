Imports System

Module Program
    Sub Main()
        Dim NombreDeUnaPersona As String
        Dim NumeroDeDocumento As UInteger
        Dim LugarDeNacimiento As String
        Dim FechaDeNacimiento As Date
        Dim AlturaCorporal As Single
        Dim SiEsArgentino As Boolean
        Dim TemperaturaAmbiente As Single
        Dim NombreCalle As String
        Dim AlturaCalle As UShort
        Dim DistanciaEntreDosCiudades As UShort
        Dim ProfundidadDelMar As Decimal
        Dim CantidadDeHabitantes As ULong
        Dim PesoProducto As Decimal
        Dim MontoArticulo As Double
        NombreDeUnaPersona = "Ezequiel"
        NumeroDeDocumento = "40.563.890"
        LugarDeNacimiento = "Hospital Madariaga"
        FechaDeNacimiento = #2/20/1998 22:23#
        AlturaCorporal = 178
        SiEsArgentino = True
        TemperaturaAmbiente = 22.5
        NombreCalle = "San Ignacio"
        AlturaCalle = 5035
        DistanciaEntreDosCiudades = 12121
        ProfundidadDelMar = 11000
        CantidadDeHabitantes = 44000000
        PesoProducto = 1.546
        MontoArticulo = 540.5
        Console.WriteLine("Nombre de una Persona: " & NombreDeUnaPersona)
        Console.WriteLine("Numero de Documento: " & NumeroDeDocumento)
        Console.WriteLine("Lugar de Nacimiento: " & LugarDeNacimiento)
        Console.WriteLine("Fecha de Nacimiento: " & FechaDeNacimiento)
        Console.WriteLine("Altura corporal(cms): " & AlturaCorporal)
        Console.WriteLine("Si es Argentino: " & SiEsArgentino)
        Console.WriteLine("Temperatura Ambiente: " & TemperaturaAmbiente)
        Console.WriteLine("Nombre Calle: " & NombreCalle)
        Console.WriteLine("Altura Calle: " & AlturaCalle)
        Console.WriteLine("Distancia en Kms entre dos ciudades: " & DistanciaEntreDosCiudades)
        Console.WriteLine("Profundidad del mar en mts: " & ProfundidadDelMar)
        Console.WriteLine("Cantidad de Habitantes en un Territorio Nacional: " & CantidadDeHabitantes)
        Console.WriteLine("Peso de un producto de un supermercado en Kilogramos: " & PesoProducto)
        Console.WriteLine("Monto de un articulo de un supermercado: $" & MontoArticulo)



    End Sub
End Module
