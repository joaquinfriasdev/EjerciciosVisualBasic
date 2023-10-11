Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        opcion = 0
        Do While opcion < 3
            Console.WriteLine("Sistema de ventas")
            Console.WriteLine("[1] Aparatos sanitarios")
            Console.WriteLine("[2] Materiales de construcción")
            Console.WriteLine("[3] Terminar")
            Console.WriteLine("Elija la opción de la ferretería")
            opcion = Console.ReadLine()
            Select Case opcion
                Case Is = 1
                    aparatos()
                Case Is = 2
                    materiales()
            End Select
        Loop
    End Sub

    Private Sub aparatos()
        Dim pagar As Decimal
        Dim vta As Decimal
        Dim ttarifa As Integer
        Dim vtarifa As Decimal

        Console.WriteLine("Aparatos sanitarios")
        Console.WriteLine("[1] Equipos italianos")
        Console.WriteLine("[2] Equipos brasileros")
        Console.WriteLine("[3] Equipos americanos")
        Console.WriteLine("Elegir las clases de equipos sanitarios")
        vta = Console.ReadLine()
        Select Case ttarifa
            Case Is = 1
                vtarifa = 150
                pagar = vta * vtarifa
            Case Is = 2
                vtarifa = 130
                pagar = vta * vtarifa
            Case Is = 3
                vtarifa = 200
                pagar = vta * vtarifa
        End Select
        Console.WriteLine("Se pagará: " + Str(pagar))
        Console.ReadLine()
    End Sub

    Private Sub materiales()
        Dim pagar As Decimal
        Dim vtm As Decimal
        Dim ttarifa As Integer
        Dim vtarifa As Decimal

        Console.WriteLine("Materiales dee construcción")
        Console.WriteLine("[1] Ladrillos")
        Console.WriteLine("[2] Cemento")
        Console.WriteLine("[3] Bolsa de arena")
        Console.WriteLine("[4] Agregados")
        Console.WriteLine("[5] Madera")
        Console.WriteLine("Elegir que material de construcción desea comprar")
        ttarifa = Console.ReadLine()
        Console.WriteLine("Que cantidad de materiales desea comprar")
        vtm = Console.ReadLine()

        Select Case ttarifa
            Case Is = 1
                vtarifa = 150
                pagar = vtm * vtarifa
            Case Is = 2
                vtarifa = 17
                pagar = vtm * vtarifa
            Case Is = 3
                vtarifa = 15
                pagar = vtm * vtarifa
            Case Is = 4
                vtarifa = 25
                pagar = vtm * vtarifa
            Case Is = 5
                vtarifa = 3
                pagar = vtm * vtarifa
        End Select
        Console.WriteLine("Se pagará: " + Str(pagar))
        Console.ReadLine()

    End Sub

End Module
