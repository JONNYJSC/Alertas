<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertasPLD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtPersona = New System.Windows.Forms.DataGridView()
        Me.btnAlerta = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tercero = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dtPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtPersona
        '
        Me.dtPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtPersona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.tercero})
        Me.dtPersona.Location = New System.Drawing.Point(12, 22)
        Me.dtPersona.Name = "dtPersona"
        Me.dtPersona.Size = New System.Drawing.Size(361, 169)
        Me.dtPersona.TabIndex = 0
        '
        'btnAlerta
        '
        Me.btnAlerta.Location = New System.Drawing.Point(51, 217)
        Me.btnAlerta.Name = "btnAlerta"
        Me.btnAlerta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlerta.TabIndex = 1
        Me.btnAlerta.Text = "Enviar"
        Me.btnAlerta.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'tercero
        '
        Me.tercero.HeaderText = "Cuenta Tercero"
        Me.tercero.Name = "tercero"
        '
        'AlertasPLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAlerta)
        Me.Controls.Add(Me.dtPersona)
        Me.Name = "AlertasPLD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlertasPLD"
        CType(Me.dtPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtPersona As DataGridView
    Friend WithEvents btnAlerta As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents tercero As DataGridViewCheckBoxColumn
End Class
