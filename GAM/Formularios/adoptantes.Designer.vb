<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adoptantes
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
        Me.adopt_dg_adoptantes = New System.Windows.Forms.DataGridView()
        Me.adopt_pic_add = New System.Windows.Forms.PictureBox()
        CType(Me.adopt_dg_adoptantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adopt_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adopt_dg_adoptantes
        '
        Me.adopt_dg_adoptantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adopt_dg_adoptantes.Location = New System.Drawing.Point(12, 140)
        Me.adopt_dg_adoptantes.Name = "adopt_dg_adoptantes"
        Me.adopt_dg_adoptantes.Size = New System.Drawing.Size(773, 304)
        Me.adopt_dg_adoptantes.TabIndex = 0
        '
        'adopt_pic_add
        '
        Me.adopt_pic_add.Location = New System.Drawing.Point(631, 95)
        Me.adopt_pic_add.Name = "adopt_pic_add"
        Me.adopt_pic_add.Size = New System.Drawing.Size(154, 39)
        Me.adopt_pic_add.TabIndex = 1
        Me.adopt_pic_add.TabStop = False
        '
        'adoptantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 456)
        Me.Controls.Add(Me.adopt_pic_add)
        Me.Controls.Add(Me.adopt_dg_adoptantes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adoptantes"
        Me.Text = "adoptantes"
        CType(Me.adopt_dg_adoptantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adopt_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adopt_dg_adoptantes As System.Windows.Forms.DataGridView
    Friend WithEvents adopt_pic_add As System.Windows.Forms.PictureBox
End Class
