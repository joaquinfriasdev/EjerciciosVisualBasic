Imports System
Imports System.Drawing

Module Program
    Sub Main(args As String())
        'Calcular la media de una serie de números positivos, suponiendo que los datos se leen desde un terminal.
        'Un valor de cero como entrada indicará que se ha alcanzado el final de la serie de números positivos.

        Console.WriteLine("Ingrese un conjunto de números positivos. Corta con cero (0)")
        Dim num As Integer = Console.ReadLine
        Dim suma As Double = 0
        Dim cont As Integer = 0

        While (num <> 0)

            suma += num
            cont += 1

            num = Console.ReadLine()
        End While

        Dim media As Double = suma / cont

        Console.WriteLine("La media de números positivos ingresados es: " & media)
    End Sub
End Module
