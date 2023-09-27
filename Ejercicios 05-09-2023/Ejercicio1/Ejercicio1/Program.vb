Imports System

Module Program
    Sub Main(args As String())
        Dim cadena As String
        Console.WriteLine("POR FAVOR, INTRODUZCA SU NOMBRE")
        cadena = Console.ReadLine()
        cadena = "EL NOMBRE INTRODUCIDO ES: " & cadena
        Console.WriteLine(cadena)
    End Sub
End Module
