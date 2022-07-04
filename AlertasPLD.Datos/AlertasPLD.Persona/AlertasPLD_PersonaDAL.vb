Imports System.Data.SqlClient
Imports AlertasPLD.Datos
Public Module AlertasPLD_PersonaDAL
    Dim Conexion = New AlertasPLD_Conexion

    Public Function mostrarPersonas() As DataTable
        Using connection = Conexion.GetConexion()
            connection.Open()
            Using comando = New SqlCommand()
                comando.Connection = connection
                comando.CommandText = "SP_SEL_Persona"
                comando.CommandType = CommandType.StoredProcedure
                Dim SqlAdapter = New SqlDataAdapter(comando)
                Dim tabla = New DataTable("Persona")
                SqlAdapter.Fill(tabla)
                comando.Parameters.Clear()
                Return tabla
            End Using
        End Using
    End Function

End Module
