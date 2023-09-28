Imports System

Module MainModule
    Sub Main()
        Console.Write("Ingrese un número entero (1 al 10): ")
        Dim numero As Integer = CInt(Console.ReadLine())

        Dim numeroRomano As String = ""

        Select Case numero
            Case 1
                numeroRomano = "I"
            Case 2
                numeroRomano = "II"
            Case 3
                numeroRomano = "III"
            Case 4
                numeroRomano = "IV"
            Case 5
                numeroRomano = "V"
            Case 6
                numeroRomano = "VI"
            Case 7
                numeroRomano = "VII"
            Case 8
                numeroRomano = "VIII"
            Case 9
                numeroRomano = "IX"
            Case 10
                numeroRomano = "X"
            Case Else
                Console.WriteLine("Número fuera de rango (1 al 10).")
                Exit Sub
        End Select

        Console.WriteLine("El número romano equivalente es: " & numeroRomano)
    End Sub
End Module
