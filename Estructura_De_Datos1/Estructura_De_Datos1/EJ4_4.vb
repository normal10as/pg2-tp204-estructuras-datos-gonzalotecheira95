'Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
'una Collection. A continuación, debe permitir realizar consultas: se introduce el nombre del
'dominio y se deberá mostrar el nombre del país. Salir cuando el valor ingresado es vacío.
Module EJ4_4
    Sub main()
        Dim paises As New Collection
        Dim clave As String
        paises.Add("Argentina", "ar")
        paises.Add("brasil", "br")
        paises.Add("peru", "pe")


        Do
            Console.Write("Ingrese clave de dominio: ")
            clave = Console.ReadLine
            If paises.Contains(clave) Then
                Console.WriteLine(paises.Item(clave))
            Else
                Console.WriteLine("El dominio es inexistente, ingrese otro: ")
            End If

        Loop Until (clave = "")
        Console.ReadKey()
    End Sub

End Module
