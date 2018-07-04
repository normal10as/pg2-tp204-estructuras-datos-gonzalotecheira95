'Crear un algoritmo que utilice arrays para almacenar las notas (0 a 10) de una serie de alumnos.
'Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un
'máximo de 40 alumnos y 4 notas.
' Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre
'y que no sea repetido y el rango de la nota.
' Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó
'teniendo en cuenta que aprueba con 6 o más.
' También informar quien es el mejor alumno (puede haber más de uno).
'Implementar procedimientos para resolver al menos las siguientes tareas:
'Uno para validad el nombre no sea vacío
'uno que valide la inexistencia de un nombre igual
'uno que valide el rango de la nota
'uno que determine el promedio
'uno que escriba si el alumno aprobó o no
'uno que devuelva la lista de mejores alumnos
Module EJ4_3
    Sub Main()
        Dim cant_alum As Byte
        Dim cant_notas As Byte


        FUNC_INGRESO(cant_alum, 40, "Ingrese cantidad de alumnos: ")
        FUNC_INGRESO(cant_notas, 4, "Ingrese cantidad de las notas de alumnos: ")

        Dim Alumnos(cant_alum - 1) As String

        For i = 0 To cant_alum - 1
            INGRESO_NOMBRE("INGRESE NOMBRE DEL ALUMNO :", i, Alumnos)
        Next

    End Sub

    Function FUNC_INGRESO(ByRef alum As Byte, ByRef max As Byte, ByRef msj As String) As Integer
        Do
            Console.WriteLine(msj)
            alum = Console.ReadLine()
        Loop While (alum > max)
        Return alum
    End Function

    Sub INGRESO_NOMBRE(ByRef msj As String, ByVal i As Byte, ByRef alumnos() As String)
        Dim band As Boolean

        Do
            Console.WriteLine(msj)
            alumnos(i) = Console.ReadLine()
            If alumnos(i) = "" Then
                Console.WriteLine("Error, Ingrese un nombre, no se permite el vacio!!")
                band = True
            Else
                For x = 0 To i - 1
                    If alumnos(i) = alumnos(x) Then
                        Console.WriteLine("Error, el nombre ya se ah ingresado, intente con otro nombre.")
                        band = True
                    End If
                Next
            End If
        Loop While band = True
    End Sub

End Module
