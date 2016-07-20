<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pet
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
        Me.pet_dv_mascotas = New System.Windows.Forms.DataGridView()
        Me.pet_lbl_lista = New System.Windows.Forms.Label()
        Me.pet_pic_add = New System.Windows.Forms.PictureBox()
        CType(Me.pet_dv_mascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pet_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pet_dv_mascotas
        '
        Me.pet_dv_mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pet_dv_mascotas.Location = New System.Drawing.Point(12, 136)
        Me.pet_dv_mascotas.Name = "pet_dv_mascotas"
        Me.pet_dv_mascotas.Size = New System.Drawing.Size(773, 297)
        Me.pet_dv_mascotas.TabIndex = 0
        '
        'pet_lbl_lista
        '
        Me.pet_lbl_lista.AutoSize = True
        Me.pet_lbl_lista.Location = New System.Drawing.Point(12, 120)
        Me.pet_lbl_lista.Name = "pet_lbl_lista"
        Me.pet_lbl_lista.Size = New System.Drawing.Size(117, 13)
        Me.pet_lbl_lista.TabIndex = 1
        Me.pet_lbl_lista.Text = "LISTA DE MASCOTAS"
        '
        'pet_pic_add
        '
        Me.pet_pic_add.Location = New System.Drawing.Point(631, 91)
        Me.pet_pic_add.Name = "pet_pic_add"
        Me.pet_pic_add.Size = New System.Drawing.Size(154, 39)
        Me.pet_pic_add.TabIndex = 2
        Me.pet_pic_add.TabStop = False
        '
        'pet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 456)
        Me.Controls.Add(Me.pet_pic_add)
        Me.Controls.Add(Me.pet_lbl_lista)
        Me.Controls.Add(Me.pet_dv_mascotas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pet"
        Me.Text = "mascotas"
        CType(Me.pet_dv_mascotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pet_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pet_dv_mascotas As System.Windows.Forms.DataGridView
    Friend WithEvents pet_lbl_lista As System.Windows.Forms.Label
    Friend WithEvents pet_pic_add As System.Windows.Forms.PictureBox
End Class
