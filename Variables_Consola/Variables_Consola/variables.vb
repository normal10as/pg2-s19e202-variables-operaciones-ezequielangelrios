Imports System

Module variables
    Sub Main()

        Dim Nombre As String
        Dim Apellido As String
        Dim FechaNacimiento As Date
        Console.WriteLine("introduzca sus datos: Nombre, Apellido, Fecha de Nacimiento")
        Nombre = Console.ReadLine()
        Apellido = Console.ReadLine()
        FechaNacimiento = Console.ReadLine()
        Console.WriteLine(Apellido & " " & Nombre & " " & "nació el " & FechaNacimiento)
        Console.ReadKey()

    End Sub
End Module
