Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese su nombre")
        Dim nombre As String = Console.ReadLine
        Console.WriteLine("Ingrese su apellido")
        Dim apellido As String = Console.ReadLine

        Dim nombreApellido As String = nombre & " " & apellido
        Console.WriteLine("Hola, mi nombre es " & nombreApellido)

    End Sub
End Module
