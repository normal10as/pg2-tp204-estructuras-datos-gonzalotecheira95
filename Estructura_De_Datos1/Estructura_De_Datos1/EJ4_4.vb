'Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
'una Collection. A continuación, debe permitir realizar consultas: se introduce el nombre del
'dominio y se deberá mostrar el nombre del país. Salir cuando el valor ingresado es vacío.
Module EJ4_4
    Sub main()
        Dim paises As New Collection
        Dim clave As String
        paises.Add("ar")
        paises.Add("br")
        paises.Add("pe")

        Console.Write("Ingrese clave de dominio: ")
        clave = Console.ReadLine()

        For Each dominio In paises
            Console.WriteLine(dominio)
            If (clave = dominio) Then
                Console.WriteLine(dominio)
            End If

        Next
        Console.ReadKey()
    End Sub

End Module
