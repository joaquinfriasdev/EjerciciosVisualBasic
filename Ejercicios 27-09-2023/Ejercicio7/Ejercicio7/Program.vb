Imports System

Module Program
    Sub Main(args As String())
        'Sumar los n�meros pares comprendidos entre 2 y 100.
        Dim suma As Integer = 0
        For i As Integer = 2 To 100 Step 2
            suma += i
        Next

        Console.WriteLine("La suma de los n�meros pares entre 2 y 100 es: " & suma)
    End Sub
End Module
