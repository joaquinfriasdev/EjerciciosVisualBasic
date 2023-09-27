Imports System

Module Program
    Sub Main(args As String())
        Dim base As Double
        Dim altura As Double
        Dim area As Double

        Console.WriteLine("Ingrese la base")
        base = Console.ReadLine
        Console.WriteLine("Ingrese la altura")
        altura = Console.ReadLine

        area = base * altura

        Console.WriteLine("El área del triángulo es " & area)
    End Sub
End Module
