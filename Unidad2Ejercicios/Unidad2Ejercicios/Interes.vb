Module Interes
    Sub Main()
        Dim Monto As Double
        Dim InteresAnual As Double
        Dim Dias As UShort
        Dim InteresProducido As Double
        Dim CapitalAcumulado As Double

        Console.WriteLine("Ingrese el Monto: ")
        Monto = Console.ReadLine
        Console.WriteLine("Ingrese el Interes Anual: ")
        InteresAnual = Console.ReadLine
        Console.WriteLine("Ingrese el tiempo en dias: ")
        Dias = Console.ReadLine

        InteresProducido = Monto * InteresAnual * Dias / (360 * 100)
        CapitalAcumulado = Monto * InteresProducido / 100

        Console.WriteLine("Interes Producido: " & InteresProducido)
        Console.Write("Capital Acumulado: " & CapitalAcumulado)

    End Sub
End Module
