Imports System.Data.SqlClient

Public Class AlertasPLD_Conexion

    Public Function GetConexion() As SqlConnection
        Return New SqlConnection("Data Source=DESKTOP-P24U9SO;Initial Catalog=dbCorreo;User ID=sa;password=admin123")
    End Function
End Class
