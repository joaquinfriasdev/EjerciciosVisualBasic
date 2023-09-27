Imports System

Module Program
    Sub Main(args As String())

        'Declaracion del vector
        Dim vector(9) As Integer
        Console.WriteLine("Ingrese los 10 números")

        For i As Integer = 0 To 9
            Console.WriteLine("Elemento " & i + 1 & ": ")
            vector(i) = Integer.Parse(Console.ReadLine())
        Next

        Console.WriteLine("Los elementos cargados en el vector son: ")
        For i As Integer = 0 To 9
            Console.WriteLine("Elemento " & i + 1 & ": " & vector(i))
        Next
    End Sub
End Module
