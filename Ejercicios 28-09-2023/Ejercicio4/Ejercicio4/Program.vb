Imports System

Module MainModule
    Sub Main()
        Console.Write("Ingrese el primer número entero: ")
        Dim numero1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero: ")
        Dim numero2 As Integer = CInt(Console.ReadLine())

        Console.WriteLine("Seleccione la operación:")
        Console.WriteLine("(*) para multiplicación")
        Console.WriteLine("(+) para suma")
        Console.WriteLine("(-) para resta")
        Console.WriteLine("(/) para división")

        Dim operacion As Char = Console.ReadKey().KeyChar

        Dim resultado As Double

        Select Case operacion
            Case "*"
                resultado = numero1 * numero2
            Case "+"
                resultado = numero1 + numero2
            Case "-"
                resultado = numero1 - numero2
            Case "/"
                If numero2 = 0 Then
                    Console.WriteLine(vbCrLf & "No se puede dividir por cero.")
                    Exit Sub
                Else
                    resultado = CDbl(numero1) / numero2
                End If
            Case Else
                Console.WriteLine(vbCrLf & "Operación no válida.")
                Exit Sub
        End Select

        Console.WriteLine(vbCrLf & "El resultado de la operación es: " & resultado)
    End Sub
End Module
