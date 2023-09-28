Imports System

Module Program
    Sub Main(args As String())
        'Escribir un algoritmo que solicite una nota e imprima por pantalla la calificación
        'en formato “aprobó” o “no aprobó” según si la nota es mayor o igual que 7 o menor que 7.

        Console.WriteLine("Ingrese la nota")
        Dim nota As Integer = Console.ReadLine()

        If (nota < 7) Then
            Console.WriteLine("No aprobó")
        Else
            Console.WriteLine("Aprobó")
        End If

    End Sub
End Module
