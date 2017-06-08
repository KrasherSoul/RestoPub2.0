Imports System.Data.SqlClient

Module conexion

    'Variables a Ocupar
    Public lector As SqlDataReader
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub SQLQuery(ByVal Query As String, ByVal retornadatos As Boolean)
        Try
            conexion = New SqlConnection
            Dim string_conexion As String = "server=localhost; user id=pruebasTesis; password=pruebastesis; database=restobar"
            conexion.ConnectionString = string_conexion
            conexion.Open()
            comando.Connection = conexion
            comando.CommandText = Query

            If retornadatos Then
                lector = comando.ExecuteReader
            Else
                comando.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error en Base de Datos, contacte a Administrador Error: " & ex.Message, MsgBoxStyle.Critical, "Error en Base de Datos")
        End Try

    End Sub

    Public Sub CerrarConexion()
        conexion.Close()
    End Sub

End Module
