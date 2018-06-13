'3. Crear un algoritmo que utilice arrays para almacenar las notas (0 a 10) de una serie de alumnos.
'Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un
'máximo de 40 alumnos y 4 notas.
'Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre
'y que no sea repetido y el rango de la nota.
'Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó
'teniendo en cuenta que aprueba con 6 o más.
'También informar quien es el mejor alumno (puede haber más de uno).
' Implementar procedimientos para resolver al menos las siguientes tareas:
'Uno para validad el nombre no sea vacío
' uno que valide la inexistencia de un nombre igual
' uno que valide el rango de la nota
'uno que determine el promedio
' uno que escriba si el alumno aprobó o no1
' uno que devuelva la lista de mejores alumnos

Module EJ4_3


    Sub Main()
        Dim cant_alum, cant_notas As Byte
        Dim Alumnos(cant_alum - 1) As String
        Dim Notas(cant_alum - 1, cant_notas) As Single
        Dim valor As Boolean

        Console.WriteLine("Ingrese cantidad de alumnos: ")
        cant_alum = Console.ReadLine
        For i As Integer = 1 To (cant_alum - 1)
            Console.WriteLine("Ingrese la cantidad de notas del alumno N° {0}", i)
            cant_notas = Console.ReadLine()
            Do While cant_notas < 1 Or cant_notas > 4
                Console.WriteLine("ERROR el alumno puede tener de 1 a 4 notas" & vbCrLf & vbCrLf & "Ingrese la cantidad de notas del alumno N° {0}", (i + 1))
                cant_notas = Console.ReadLine()
            Loop
        Next
        For i = 0 To cant_alum - 1
            Do
                valor = False
                Console.Write("Ingrese nombre: ")
                Alumnos(i) = Console.ReadLine()
                If Alumnos(i) = "" Then
                    Console.WriteLine("No se ingreso el nombre")
                    valor = True
                Else
                    For x = 0 To i - 1
                        If Alumnos(i) = Alumnos(x) Then
                            Console.WriteLine("El nombre ingresado ya existe")
                            valor = True
                        End If
                    Next
                End If
            Loop While valor = True
        Next
        Console.ReadKey()
    End Sub
End Module
