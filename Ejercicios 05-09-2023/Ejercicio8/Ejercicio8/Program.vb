
Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer n�mero")
        Dim num1 As Integer = Console.ReadLine
        Console.WriteLine("Ingrese el segundo n�mero")
        Dim num2 As Integer = Console.ReadLine

        Dim multiplicacion As Integer = num1 * num2
        Dim division As Integer = num1 / num2

        Console.WriteLine("El resultado de la multiplicaci�nes " & multiplicacion)
        Console.WriteLine("El resultado de la divisi�n es " & division)
    End Sub
End Module
