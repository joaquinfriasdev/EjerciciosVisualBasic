Imports System

Module Program
    Sub Main(args As String())
        Const valor_iva As Integer = 21
        Dim iva As Double
        Console.WriteLine("Escribe el valor de un producto")
        Dim producto As Double = Console.ReadLine

        'Invoco a la función
        iva = (valor_iva / 100) * producto

        'El valor final es el producto mas su iva
        Dim valor_final As Double = producto + iva
        Console.WriteLine("El valor final del producto es " & valor_final & " pesos")








    End Sub
End Module
