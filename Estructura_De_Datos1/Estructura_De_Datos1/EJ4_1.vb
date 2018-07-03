Module EJ4_1
    Sub Main()
        Dim num(4) As Integer
        Dim Media As Integer

        For i = 0 To 4
            Console.WriteLine("Ingrese el N° " & i + 1 & " para ver los resultados: ")
            num(i) = Console.ReadLine()
            Media += num(i)
        Next
        Media = Media / 5

        Console.WriteLine(vbCrLf & "La media de los numeros es : {0}", Media & vbCrLf)

        For i = 0 To 4
            Console.WriteLine("La desviacion del arreglo N° {0} es {1}: ", i + 1, num(i) - Media)
        Next

        Console.ReadLine()
    End Sub
End Module
