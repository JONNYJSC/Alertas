Imports AlertasPLD.Logica

Public Class AlertasPLD
    Private Sub AlertasPLD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Load_grid()
        Me.Load_listView()
    End Sub

    Public Sub Load_grid()
        dtPersona.DataSource = AlertasPLD_PersonaBIL.listarPersonas
    End Sub

    Public Sub Load_listView()
        Dim checkBox(0) As String
        checkBox(0) = "A"
        AlertaListView.View = View.Details
        AlertaListView.CheckBoxes = True

        'Esto es el Header el encabezado
        AlertaListView.Columns.Add("Id", 75, HorizontalAlignment.Center)
        AlertaListView.Columns.Add("Nombre", 100, HorizontalAlignment.Center)
        AlertaListView.Columns.Add("Cuenta Tercero", 100, HorizontalAlignment.Center)

        For Each i In AlertasPLD_PersonaBIL.listarPersonasListView.Rows
            Dim obj As New ListViewItem(i(0).ToString)
            obj.SubItems.Add(i(1).ToString)
            AlertaListView.Items.Add(obj)
        Next
    End Sub
End Class