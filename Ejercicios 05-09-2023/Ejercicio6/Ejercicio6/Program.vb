Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer n�mero")
        Dim num1 As Integer = Console.ReadLine

        Console.WriteLine("Ingrese el segundo n�mero")
        Dim num2 As Integer = Console.ReadLine

        Dim suma As Integer = num1 + num2

        Console.WriteLine("La suma de ambos n�meros es: " & suma)
    End Sub
End Module
