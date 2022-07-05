Imports AlertasPLD.Datos

Public Module AlertasPLD_PersonaBIL
    Public Function listarPersonas() As DataTable
        Return AlertasPLD_PersonaDAL.mostrarPersonas
    End Function

    Public Function listarPersonasListView() As DataTable
        Return AlertasPLD_PersonaDAL.mostrarPersonasListViiew
    End Function
End Module
