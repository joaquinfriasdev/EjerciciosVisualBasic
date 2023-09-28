Imports System

Module Program
    Sub Main(args As String())
        'Calcule la edad de una persona, ingresando por terminal la fecha de nacimiento y la fecha actual.

        Console.WriteLine("Ingrese su fecha de nacimiento separado por barras")
        Dim fechaNac As Date = Console.ReadLine()
        Console.WriteLine("Ingrese la fecha actual separado por barras")
        Dim fechaAct As Date = Console.ReadLine()

        Dim edad As Integer = fechaAct.Year - fechaNac.Year
        Console.WriteLine("Su edad es: " & edad)

    End Sub
End Module
