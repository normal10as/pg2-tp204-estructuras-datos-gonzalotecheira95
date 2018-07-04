Module EJ4_5
    Dim paises As New Collection
    Enum funciones
        agregar = 1
        editar
        eliminar
        mostrar
    End Enum

    Sub Main()

        paises.Add("argentina", "ar")
        paises.Add("brasil", "br")
        paises.Add("peru", "pe")

        Princio_menu()

        Console.ReadKey()
    End Sub
    Sub Princio_menu()
        Dim opc As Integer


        Console.WriteLine("La cantidad de paises es de {0}.", paises.Count)
        For Each pais In paises
            Console.WriteLine(pais)
        Next
        Console.WriteLine("Elija una opcion del menu: " & vbCrLf & "1-agregar-2-editar-3-eliminar-4-mostrar")

        opc = FUNCINGRESO(opc)

        Select Case opc
            Case funciones.agregar
                Agregar_menu()
            Case funciones.editar
                Editar_menu()
            Case funciones.eliminar
                Eliminar_menu()
            Case funciones.mostrar
                Mostrar_menu()
        End Select
    End Sub
    Sub Editar_menu()
        Dim ing_pais As String
        Dim edit_pais, edit_dom As String

        Console.WriteLine("Ingrese clave del pais para editarlo: ")
        ing_pais = Console.ReadLine()

        If paises.Contains(ing_pais) Then
            paises.Remove(ing_pais)
            Console.WriteLine("Ingresar Nombre nuevo para el pais a editar:")
            edit_pais = Console.ReadLine()
            Console.WriteLine("Ingresar clave de dominio del pais: ")
            edit_dom = Console.ReadLine()
            paises.Add(edit_pais, edit_dom)
        Else
            Console.WriteLine("El pais es inexistente para editarlo.")
        End If

        Princio_menu()

    End Sub
    Sub Eliminar_menu()
        Dim elim_pais As String
        Console.WriteLine("Ingresar clave de dominio para eliminar pais:")
        elim_pais = Console.ReadLine()
        If paises.Contains(elim_pais) Then
            paises.Remove(elim_pais)
        Else
            Console.WriteLine("El pais es inexistente para borralo.")
        End If
        Princio_menu()
    End Sub
    Sub Agregar_menu()

        Dim nom_pais As String
        Dim clav_dom As String
        Console.WriteLine("Ingresar Nombre de pais:")
        nom_pais = Console.ReadLine()
        Console.WriteLine("Ingresar clave de dominio: ")
        clav_dom = Console.ReadLine()
        paises.Add(nom_pais, clav_dom)

        Princio_menu()
    End Sub
    Sub Mostrar_menu()

        Dim clave As String
        Console.Write("Ingrese clave de dominio: ")
        clave = Console.ReadLine()
        If paises.Contains(clave) Then
            Console.WriteLine(paises.Item(clave))
        Else
            Console.WriteLine("El dominio es inexistente, ingrese otro: ")
        End If

        Princio_menu()

    End Sub
    Friend Function FUNCINGRESO(ByRef X As Double) As Double
        X = Console.ReadLine()
        Do While X < 1
            Console.WriteLine("Ingresaste mal, esa opcion no esta en el menu.")
            X = Console.ReadLine()
        Loop
        Return X
    End Function
End Module
