Imports System

Module Tablas

    Sub Main()
        Dim Tablas As Byte
        '-------------------------------------
        Console.WriteLine("Ingrese la tabla que desea ver:1=AND,2=NOT,3=OR,4=XOR ")
        Tablas = Console.ReadLine
        Select Case Tablas

            Case 1
                Console.WriteLine("tabla AND: Exp1  Exp2    Exp1 y Exp2")
                Console.WriteLine("             V   V       V")
                Console.WriteLine("             V   F       F")
                Console.WriteLine("             F   V       F")
                Console.WriteLine("             F   F       F")

            Case 2
                Console.WriteLine("tabla NOT:   Exp1 NO Exp1")
                Console.WriteLine("               V       F")
                Console.WriteLine("               F       V")

            Case 3
                Console.WriteLine("tabla OR:    Exp1  Exp2    Exp1 o Exp2")
                Console.WriteLine("             V       V       V")
                Console.WriteLine("             V       F       V")
                Console.WriteLine("             F       V       V")
                Console.WriteLine("             F       F       F")

            Case 4
                Console.WriteLine("tabla XOR:    Exp1  Exp2    Exp1 Y Exp2")
                Console.WriteLine("                V       V       F")
                Console.WriteLine("                V       F       T")
                Console.WriteLine("                F       V       T")
                Console.WriteLine("                F       F       F")

            Case Else
                Console.WriteLine("Numero fuera de rango ")
        End Select

    End Sub
End Module
