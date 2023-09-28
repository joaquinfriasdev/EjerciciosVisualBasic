Imports System

Module MainModule
    Sub Main()

        Dim totalElectores As Integer = 16
        Dim votosCandidatos(2) As Integer
        Dim votosNulos As Integer = 0


        For i As Integer = 1 To totalElectores
            Console.WriteLine("Elector #" & i)
            Console.WriteLine("Seleccione su candidato (1, 2 o 3), o ingrese 0 para voto nulo:")
            Dim voto As Integer = CInt(Console.ReadLine())

            Select Case voto
                Case 1 To 3
                    votosCandidatos(voto - 1) += 1
                Case 0
                    votosNulos += 1
                Case Else
                    Console.WriteLine("Voto no válido.")
            End Select
        Next


        Dim votosMaximos As Integer = Math.Max(Math.Max(votosCandidatos(0), votosCandidatos(1)), votosCandidatos(2))

        If votosNulos > votosMaximos Then
            Console.WriteLine("Se necesita una nueva elección debido a la mayoría de votos nulos.")
        Else
            Dim ganador As Integer = Array.IndexOf(votosCandidatos, votosMaximos) + 1
            Console.WriteLine("El candidato #" & ganador & " es el ganador con " & votosMaximos & " votos.")
        End If
    End Sub
End Module

