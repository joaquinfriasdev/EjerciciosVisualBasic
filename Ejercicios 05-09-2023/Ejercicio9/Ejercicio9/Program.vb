Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese la base del rect�ngulo")
        Dim base As Integer = Console.ReadLine
        Console.WriteLine("Ingrese la altura del rect�ngulo")
        Dim altura As Integer = Console.ReadLine

        Dim area As Integer = base * altura
        Dim perimetro As Integer = 2 * (base + altura)

        Console.WriteLine("El �rea es: " & area)
        Console.WriteLine("El per�metro es: " & perimetro)
    End Sub
End Module
