Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer número")
        Dim num1 As Integer = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo número")
        Dim num2 As Integer = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer número")
        Dim num3 As Integer = Console.ReadLine()

        If (num1 > num2 And num1 > num3) Then
            Console.WriteLine(num1)
            If (num2 > num3) Then
                Console.WriteLine(num2)
                Console.WriteLine(num3)
            Else
                Console.WriteLine(num3)
                Console.WriteLine(num2)
            End If
        ElseIf (num2 > num3) Then
            Console.WriteLine(num2)
            If (num1 > num3) Then
                Console.WriteLine(num1)
                Console.WriteLine(num3)
            Else
                Console.WriteLine(num3)
                Console.WriteLine(num1)
            End If
        Else
            Console.WriteLine(num3)
            Console.WriteLine(num2)
            Console.WriteLine(num1)
        End If
    End Sub
End Module
