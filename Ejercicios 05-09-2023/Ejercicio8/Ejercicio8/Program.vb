
Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer número")
        Dim num1 As Integer = Console.ReadLine
        Console.WriteLine("Ingrese el segundo número")
        Dim num2 As Integer = Console.ReadLine

        Dim multiplicacion As Integer = num1 * num2
        Dim division As Integer = num1 / num2

        Console.WriteLine("El resultado de la multiplicaciónes " & multiplicacion)
        Console.WriteLine("El resultado de la división es " & division)
    End Sub
End Module
