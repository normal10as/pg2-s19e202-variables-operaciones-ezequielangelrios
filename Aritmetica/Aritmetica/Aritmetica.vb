Imports System

Module Aritmetica
    Sub Main()
        Dim SumaEnteros As Int16
        Dim SumaPuntoFlotante As Single
        Dim SumaEnteroPuntoFlotante As Single
        Dim PuntoFlotante1 As Single = Math.PI
        Dim PuntoFlotante2 As Single = Math.PI
        Dim Entero1 As Int16 = 5
        Dim Entero2 As Int16 = 10

        SumaEnteros = Entero1 + Entero2
        SumaPuntoFlotante = PuntoFlotante1 + PuntoFlotante2
        SumaEnteroPuntoFlotante = PuntoFlotante1 + Entero1

        Console.WriteLine("Suma Enteros: " & SumaEnteros)
        Console.WriteLine("Suma Punto Flotante: " & SumaPuntoFlotante)
        Console.WriteLine("Suma Entero y Punto Flotante: " & SumaEnteroPuntoFlotante)



    End Sub
End Module
