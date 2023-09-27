Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer valor")
        Dim valor1 As Integer = Console.ReadLine

        Console.WriteLine("Ingrese el segundo valor")
        Dim valor2 As Integer = Console.ReadLine

        Console.WriteLine("Ingrese el tercer valor")
        Dim valor3 As Integer = Console.ReadLine

        Dim resultado As Integer = valor1 + valor2 - (valor3 - valor1)

        Console.WriteLine("-----------------------------------")
        Console.WriteLine("El resultado es: " & resultado)

    End Sub
End Module
