Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Escribe un nombre")
        Dim nombre As String = Console.ReadLine
        'Mostramos el mensaje
        Console.WriteLine("¡Hola " & nombre & "!")
    End Sub
End Module
