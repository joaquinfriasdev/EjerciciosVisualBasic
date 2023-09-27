Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese la base del rectángulo")
        Dim base As Integer = Console.ReadLine
        Console.WriteLine("Ingrese la altura del rectángulo")
        Dim altura As Integer = Console.ReadLine

        Dim area As Integer = base * altura
        Dim perimetro As Integer = 2 * (base + altura)

        Console.WriteLine("El área es: " & area)
        Console.WriteLine("El perímetro es: " & perimetro)
    End Sub
End Module
