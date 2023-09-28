Imports System

Module Program
    Sub Main(args As String())
        'Leyendo por terminal la fecha de nacimiento de dos hermanos determine cual es el mayor y muestre su
        'edad por pantalla.

        Console.WriteLine("Ingrese la fecha de nacimiento del primer hermano, separado por barras")
        Dim fechaNac1 As Date = Console.ReadLine
        Console.WriteLine("Ingrese la fecha de nacimiento del segundo hermano, separado por barras")
        Dim fechaNac2 As Date = Console.ReadLine

        Dim edad1 As Integer = 2023 - fechaNac1.Year
        Dim edad2 As Integer = 2023 - fechaNac2.Year

        If (edad1 > edad2) Then
            Console.WriteLine("La edad del mayor de los hermanos es: " & edad1)
        Else
            Console.WriteLine("La edad del mayor de los hermanos es: " & edad2)
        End If

    End Sub
End Module
