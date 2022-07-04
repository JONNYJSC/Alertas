Imports AlertasPLD.Logica

Public Class AlertasPLD
    Private Sub AlertasPLD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Load_grid()
    End Sub

    Public Sub Load_grid()
        dtPersona.DataSource = AlertasPLD_PersonaBIL.listarPersonas
    End Sub
End Class