Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMuestrasMedidas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboMuestrasMedidas As DBO_MuestrasMedidas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMuestrasMedidas, MaestroID)
        InitializeComponent()

        dboMuestrasMedidas = New DBO_MuestrasMedidas


        MyBase.newRegForm = CType(New frmEntMuestrasMedidas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboMuestrasMedidas, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboMuestrasMedidas = CType(sp, spMuestrasMedidas).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboMuestrasMedidas Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboMuestrasMedidas, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
