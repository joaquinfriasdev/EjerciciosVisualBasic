Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese su nombre")
        Dim nombre As String = Console.ReadLine
        Console.WriteLine("Ingrese su edad")
        Dim edad As Integer = Console.ReadLine

        Console.WriteLine("HOLA ME LLAMO " & nombre & ", TENGO LA EDAD DE " & edad & " AÑOS.")
    End Sub
End Module
