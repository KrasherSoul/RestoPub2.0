Imports System.Data.SqlClient
Module Conexion2


    'Variables a Ocupar
    Public lector2 As SqlDataReader
    Dim conexion2 As SqlConnection
    Dim comando2 As New SqlCommand

    Public Sub SQLQuery2(ByVal Query As String, ByVal retornadatos As Boolean)
        Try
            conexion2 = New SqlConnection
            Dim string_conexion As String = "server=localhost; user id=pruebasTesis; password=pruebastesis; database=restobar"
            conexion2.ConnectionString = string_conexion
            conexion2.Open()
            comando2.Connection = conexion2
            comando2.CommandText = Query

            If retornadatos Then
                lector2 = comando2.ExecuteReader
            Else
                comando2.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error en Base de Datos, contacte a Administrador Error: " & ex.Message, MsgBoxStyle.Critical, "Error en Base de Datos")
        End Try

    End Sub

    Public Sub CerrarConexion()
        conexion2.Close()
    End Sub

End Module

