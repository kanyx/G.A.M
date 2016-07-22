<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adopciones
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
        Me.adopcion_dg_adopciones = New System.Windows.Forms.DataGridView()
        Me.adopcion_pic_add = New System.Windows.Forms.PictureBox()
        CType(Me.adopcion_dg_adopciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adopcion_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adopcion_dg_adopciones
        '
        Me.adopcion_dg_adopciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adopcion_dg_adopciones.Location = New System.Drawing.Point(12, 159)
        Me.adopcion_dg_adopciones.Name = "adopcion_dg_adopciones"
        Me.adopcion_dg_adopciones.Size = New System.Drawing.Size(773, 285)
        Me.adopcion_dg_adopciones.TabIndex = 0
        '
        'adopcion_pic_add
        '
        Me.adopcion_pic_add.Location = New System.Drawing.Point(631, 114)
        Me.adopcion_pic_add.Name = "adopcion_pic_add"
        Me.adopcion_pic_add.Size = New System.Drawing.Size(154, 39)
        Me.adopcion_pic_add.TabIndex = 1
        Me.adopcion_pic_add.TabStop = False
        '
        'adopciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 456)
        Me.Controls.Add(Me.adopcion_pic_add)
        Me.Controls.Add(Me.adopcion_dg_adopciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adopciones"
        Me.Text = "adopciones"
        CType(Me.adopcion_dg_adopciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adopcion_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adopcion_dg_adopciones As System.Windows.Forms.DataGridView
    Friend WithEvents adopcion_pic_add As System.Windows.Forms.PictureBox
End Class
