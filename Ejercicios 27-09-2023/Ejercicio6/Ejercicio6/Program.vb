Imports System
Imports System.Drawing

Module Program
    Sub Main(args As String())
        'Calcular la media de una serie de n�meros positivos, suponiendo que los datos se leen desde un terminal.
        'Un valor de cero como entrada indicar� que se ha alcanzado el final de la serie de n�meros positivos.

        Console.WriteLine("Ingrese un conjunto de n�meros positivos. Corta con cero (0)")
        Dim num As Integer = Console.ReadLine
        Dim suma As Double = 0
        Dim cont As Integer = 0

        While (num <> 0)

            suma += num
            cont += 1

            num = Console.ReadLine()
        End While

        Dim media As Double = suma / cont

        Console.WriteLine("La media de n�meros positivos ingresados es: " & media)
    End Sub
End Module
