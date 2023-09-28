Imports System

Module MainModule
    Sub Main()
        Console.Write("Ingrese el primer n�mero entero: ")
        Dim numero1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el segundo n�mero entero: ")
        Dim numero2 As Integer = CInt(Console.ReadLine())

        Console.WriteLine("Seleccione la operaci�n:")
        Console.WriteLine("(*) para multiplicaci�n")
        Console.WriteLine("(+) para suma")
        Console.WriteLine("(-) para resta")
        Console.WriteLine("(/) para divisi�n")

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
                Console.WriteLine(vbCrLf & "Operaci�n no v�lida.")
                Exit Sub
        End Select

        Console.WriteLine(vbCrLf & "El resultado de la operaci�n es: " & resultado)
    End Sub
End Module
