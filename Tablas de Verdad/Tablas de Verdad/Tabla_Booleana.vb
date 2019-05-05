Imports System

Module Tabla_Booleana
    Sub Main()
        Dim V, F As Boolean

        V = True
        F = False

        Console.WriteLine("Tabla AND  Exp1, Exp2 Exp1 AND Exp2")
        Console.WriteLine("             V    V      " & (V And V))
        Console.WriteLine("             V    F      " & (V And F))
        Console.WriteLine("             F    V      " & (F And V))
        Console.WriteLine("             F    F      " & (F And F))
        Console.WriteLine("Tabla OR  Exp1, Exp2 Exp1 OR Exp2")
        Console.WriteLine("             V    V      " & (V Or V))
        Console.WriteLine("             V    F      " & (V Or F))
        Console.WriteLine("             F    V      " & (F Or V))
        Console.WriteLine("             F    F      " & (F Or F))
        Console.WriteLine("Tabla Xor  Exp1, Exp2 Exp1 Xor Exp2")
        Console.WriteLine("             V    V      " & (V Xor V))
        Console.WriteLine("             V    F      " & (V Xor F))
        Console.WriteLine("             F    V      " & (F Xor V))
        Console.WriteLine("             F    F      " & (F Xor F))
        Console.WriteLine("Tabla Not  Exp1, NO Exp1 ")
        Console.WriteLine("           V       " & (Not V))
        Console.WriteLine("           F       " & (Not F))




    End Sub



End Module
