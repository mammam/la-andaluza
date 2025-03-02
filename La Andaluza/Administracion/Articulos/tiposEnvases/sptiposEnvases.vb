Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class sptiposEnvases
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[tiposEnvasesSelect]", _
                      "[dbo].[tiposEnvasesInsert]", _
                      "[dbo].[tiposEnvasesUpdate]", _
                      "[dbo].[tiposEnvasesDelete]", _
                      "[dbo].[tiposEnvasesSelectDgv]", _
                      "[dbo].[tiposEnvasesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_tiposEnvases
        Dim dbo As New DBO_tiposEnvases
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_tiposEnvases
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_tiposEnvases(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("tiposEnvasesCbo", False, dtb)
    End Sub

End Class
