Imports System

Module Program
    Sub Main(args As String())
        'Escribir un algoritmo que pida, nombre, apellido, teléfono
        'y edad de una persona y luego lo muestre por pantalla.
        Console.WriteLine("Ingrese su nombre")
        Dim nombre As String = Console.ReadLine()

        Console.WriteLine("Ingrese su apellido")
        Dim apellido As String = Console.ReadLine()

        Console.WriteLine("Ingrese su edad")
        Dim edad As Integer = Console.ReadLine()

        Console.WriteLine("Ingrese su teléfono")
        Dim telefono As String = Console.ReadLine()

        Console.WriteLine("Su nombre es: " & nombre)
        Console.WriteLine("Su apellido es: " & apellido)
        Console.WriteLine("Su edad es: " & edad)
        Console.WriteLine("Su teléfono es: " & telefono)

    End Sub
End Module
