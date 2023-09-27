
Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese la longitud en metros")
        Dim metros As Double = Console.ReadLine

        Dim centimetros As Double = 100 * metros
        Dim pulgadas As Double = centimetros / 2.54
        Dim pies As Double = pulgadas / 12
        Dim yarda As Double = pies / 3

        Console.WriteLine("-------------------")
        Console.WriteLine("Centímetros: " & centimetros)
        Console.WriteLine("Pulgadas: " & pulgadas)
        Console.WriteLine("Pies: " & pies)
        Console.WriteLine("Yarda: " & yarda)

    End Sub
End Module
