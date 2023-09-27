Imports System

Module Program
    Sub Main(args As String())
        Dim matriz(3, 3) As Double
        Console.WriteLine("Ingrese las notas de los alumnos para las materias")

        For fila As Integer = 0 To 3
            For columna As Integer = 0 To 3
                Console.Write("Alumno " & fila + 1 & ", Materia " & columna + 1 & ": ")
                matriz(fila, columna) = Double.Parse(Console.ReadLine())
            Next
        Next

        Console.WriteLine("Promedio de las notas de los alumnos: ")
        For fila As Integer = 0 To 3
            Dim sumaNotas As Double = 0
            For columna As Integer = 0 To 3
                sumaNotas += matriz(fila, columna)
            Next
            Dim promedio As Double = sumaNotas / 4
            Console.WriteLine("Alumno " & fila + 1 & ": Promedio = " & promedio)
        Next

    End Sub
End Module
