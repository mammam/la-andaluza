<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosDocumentos
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosDocumentos))
        Me.txtArticuloDocumentoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloID = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFuente = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblArticuloDocumentoID = New System.Windows.Forms.Label()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFuente = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.butRuta = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtArticuloDocumentoID
        '
        Me.txtArticuloDocumentoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloDocumentoID.EsUnicoCampo = ""
        Me.txtArticuloDocumentoID.EsUnicoCampoID = ""
        Me.txtArticuloDocumentoID.EsUnicoID = 0
        Me.txtArticuloDocumentoID.EsUnicoTabla = ""
        Me.txtArticuloDocumentoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloDocumentoID.Location = New System.Drawing.Point(175, 4)
        Me.txtArticuloDocumentoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArticuloDocumentoID.MaxLength = 9
        Me.txtArticuloDocumentoID.Minimo = 0
        Me.txtArticuloDocumentoID.Modificado = False
        Me.txtArticuloDocumentoID.Name = "txtArticuloDocumentoID"
        Me.txtArticuloDocumentoID.Numerico_EsNumerico = False
        Me.txtArticuloDocumentoID.Numerico_NumeroDoublees = 0
        Me.txtArticuloDocumentoID.Numerico_SeparadorMiles = False
        Me.txtArticuloDocumentoID.Obligatorio = False
        Me.txtArticuloDocumentoID.ParametroID = 0
        Me.txtArticuloDocumentoID.Size = New System.Drawing.Size(73, 24)
        Me.txtArticuloDocumentoID.TabIndex = 0
        Me.txtArticuloDocumentoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloDocumentoID.ValorMaximo = 0.0!
        Me.txtArticuloDocumentoID.ValorMinimo = 0.0!
        Me.txtArticuloDocumentoID.Visible = False
        '
        'cboArticuloID
        '
        Me.cboArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloID.Location = New System.Drawing.Point(175, 36)
        Me.cboArticuloID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticuloID.Name = "cboArticuloID"
        Me.cboArticuloID.Size = New System.Drawing.Size(645, 26)
        Me.cboArticuloID.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(175, 70)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(1233, 24)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(175, 102)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(125, 24)
        Me.dtpFecha.TabIndex = 3
        '
        'txtFuente
        '
        Me.txtFuente.BackColor = System.Drawing.SystemColors.Window
        Me.txtFuente.EsUnicoCampo = ""
        Me.txtFuente.EsUnicoCampoID = ""
        Me.txtFuente.EsUnicoID = 0
        Me.txtFuente.EsUnicoTabla = ""
        Me.txtFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuente.Location = New System.Drawing.Point(175, 134)
        Me.txtFuente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFuente.MaxLength = 4000
        Me.txtFuente.Minimo = 0
        Me.txtFuente.Modificado = False
        Me.txtFuente.Name = "txtFuente"
        Me.txtFuente.Numerico_EsNumerico = False
        Me.txtFuente.Numerico_NumeroDoublees = 0
        Me.txtFuente.Numerico_SeparadorMiles = False
        Me.txtFuente.Obligatorio = False
        Me.txtFuente.ParametroID = 0
        Me.txtFuente.Size = New System.Drawing.Size(645, 24)
        Me.txtFuente.TabIndex = 4
        Me.txtFuente.ValorMaximo = 0.0!
        Me.txtFuente.ValorMinimo = 0.0!
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRuta.Enabled = False
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(175, 166)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(1233, 24)
        Me.txtRuta.TabIndex = 5
        Me.txtRuta.ValorMaximo = 0.0!
        Me.txtRuta.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(175, 204)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(1233, 68)
        Me.txtObservaciones.TabIndex = 6
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblArticuloDocumentoID
        '
        Me.lblArticuloDocumentoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloDocumentoID.Location = New System.Drawing.Point(16, 0)
        Me.lblArticuloDocumentoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloDocumentoID.Name = "lblArticuloDocumentoID"
        Me.lblArticuloDocumentoID.Size = New System.Drawing.Size(151, 26)
        Me.lblArticuloDocumentoID.TabIndex = 0
        Me.lblArticuloDocumentoID.Text = "ArticuloDocumentoID"
        Me.lblArticuloDocumentoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloDocumentoID.Visible = False
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloID.Location = New System.Drawing.Point(16, 32)
        Me.lblArticuloID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(151, 26)
        Me.lblArticuloID.TabIndex = 1
        Me.lblArticuloID.Text = "ArticuloID"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 66)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(151, 26)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Location = New System.Drawing.Point(16, 98)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(151, 26)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFuente
        '
        Me.lblFuente.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFuente.Location = New System.Drawing.Point(16, 130)
        Me.lblFuente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(151, 26)
        Me.lblFuente.TabIndex = 4
        Me.lblFuente.Text = "Fuente"
        Me.lblFuente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRuta.Location = New System.Drawing.Point(16, 162)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(151, 26)
        Me.lblRuta.TabIndex = 5
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(16, 200)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(151, 26)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9345794!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.99237!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.149666!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMiddle.Controls.Add(Me.lblArticuloDocumentoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloDocumentoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblFuente, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtFuente, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 5)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1569, 287)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'butRuta
        '
        Me.butRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(1447, 166)
        Me.butRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(44, 30)
        Me.butRuta.TabIndex = 1000000004
        Me.butRuta.UseVisualStyleBackColor = True
        '
        '
        'frmEntArticulosDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1585, 336)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntArticulosDocumentos"
        Me.Text = "ArticulosDocumentos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtArticuloDocumentoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticuloID As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtFuente As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblArticuloDocumentoID As System.Windows.Forms.Label
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblFuente As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
End Class
