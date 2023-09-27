Imports System

Module Program
    Sub Main(args As String())

        'Declaración de la matriz
        Dim matriz(2, 2) As Double
        Console.WriteLine("Ingrese las notas de los alumnos para las materias")

        For fila As Integer = 0 To 2
            For columna As Integer = 0 To 2
                Console.Write("Alumno " & fila + 1 & ", Materia " & columna + 1 & ": ")
                matriz(fila, columna) = Double.Parse(Console.ReadLine())
            Next
        Next

        Console.WriteLine("Notas de los alumnos en las materias")
        For fila As Integer = 0 To 2
            For columna As Integer = 0 To 2
                Console.WriteLine("Alumno " & fila + 1 & ", Materia " & columna + 1 & ": " & matriz(fila, columna))
            Next
        Next


    End Sub
End Module
