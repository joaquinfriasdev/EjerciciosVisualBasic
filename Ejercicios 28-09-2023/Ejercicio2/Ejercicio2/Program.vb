Imports System

Module MainModule
    Sub Main()
        Console.Write("Ingrese el primer número entero: ")
        Dim numero1 As Integer = Console.ReadLine()

        Console.Write("Ingrese el segundo número entero: ")
        Dim numero2 As Integer = Console.ReadLine()

        Dim producto As Integer = 0


        For i As Integer = 1 To Math.Abs(numero2)
            producto += Math.Abs(numero1)
        Next


        If (numero1 < 0 And numero2 > 0) Or (numero1 > 0 And numero2 < 0) Then
            producto = -producto
        End If

        Console.WriteLine("El producto de " & numero1 & " y " & numero2 & " es: " & producto)
    End Sub
End Module
