Imports System

Module Program
    Sub Main(args As String())
        Dim vstup As String
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Do
            Console.Write("Zadej èíslo: ")
            vstup = Console.ReadLine

            If Integer.TryParse(vstup, cislo) Then
                If cislo < 10 Then
                    If cislo > 0 Then
                        For i = 1 To cislo
                            soucet = soucet + i
                        Next
                        Console.WriteLine($"Součet od 1 do {cislo} je {soucet}")
                    Else
                        Console.WriteLine("číslo nesmí být záporné!")
                    End If
                Else
                        Console.WriteLine("Zadej číslo menší než 10!")
                End If

            Else
                Console.WriteLine("Napiš jen celé číslo!")
                End If


        Loop



    End Sub
End Module
