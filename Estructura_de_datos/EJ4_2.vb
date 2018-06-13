Module EJ4_2
    Dim Codigo = New UShort() {0, 1, 2, 3}
    Dim Nombre = New String() {"remera", "buzo", "campera", "jeans"}
    Dim Precio = New Single() {225, 600, 900, 1500}
    Sub Main()
        Dim opc As Integer
        Dim acum, acum2, total, total2 As Integer
        Do
            opc = FUNCINGRESO(Codigo)


            If opc = 0 Then
                Exit Do
            End If
            For Each cod As Integer In Codigo
                If cod = opc Then
                    Console.WriteLine("Descripcion: " & Nombre(cod))
                    Console.WriteLine("Precio unitario: " & Precio(cod))
                    Console.Write("Ingrese la cantidad de productos: ")
                    acum = Console.ReadLine()
                    acum2 = acum2 + acum
                    total = acum * Precio(cod)
                    Console.Write("Precio total de la cantidad de productos: ${0}", total & vbCrLf)
                    total2 = total2 + total
                End If
            Next
        Loop While (True)

        Console.WriteLine("Cantidad de productos adquiridos: {0}", acum2)
        Console.WriteLine("Precio total a pagar: ${0}", total2)
        Console.ReadKey()

    End Sub
    Function FUNCINGRESO(arrays() As UShort) As UShort
        Dim cod As Integer
        Do
            Console.WriteLine("Ingrese el codigo del producto para ver su descripcion: ")
            cod = Console.ReadLine()

            For Each ing As Integer In arrays
                If ing = cod Then
                    Return cod
                End If
            Next
            Console.WriteLine("Codigo de producto inexistente, ingrese uno que exista!!.")
        Loop Until (True)
    End Function
End Module