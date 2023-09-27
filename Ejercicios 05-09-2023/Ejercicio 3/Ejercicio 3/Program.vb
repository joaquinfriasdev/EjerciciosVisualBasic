Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese su nombre")
        Dim nombre As String = Console.ReadLine
        Console.WriteLine("Ingrese su lugar de estudio")
        Dim lugarEstudio As String = Console.ReadLine
        Console.WriteLine("Ingrese su edad")
        Dim edad As Integer = Console.ReadLine

        Console.WriteLine("-------------------")
        Console.WriteLine("HOLA")
        Console.WriteLine("MI NOMBRE ES: " & nombre)
        Console.WriteLine("ESTUDIO EN: " & lugarEstudio)
        Console.WriteLine("TENGO LA EDAD DE: " & edad)

    End Sub
End Module
