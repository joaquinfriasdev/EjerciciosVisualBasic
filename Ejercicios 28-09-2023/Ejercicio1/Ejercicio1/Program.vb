Imports System

Module Program
    Sub Main(args As String())

        Dim mayoresDeEdad As Integer = 0
        Dim menoresDeEdad As Integer = 0

        For i As Integer = 1 To 20
            Console.WriteLine("Ingrese la edad de la persona " & i & ":")
            Dim edad As Integer = Console.ReadLine()

            If edad >= 18 Then
                mayoresDeEdad += 1
            Else
                menoresDeEdad += 1
            End If
        Next

        Console.WriteLine("La cantidad de personas mayores de edad es: " & mayoresDeEdad)
        Console.WriteLine("La cantidad de personas menores de edad es: " & menoresDeEdad)

    End Sub
End Module
