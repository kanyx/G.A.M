<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_mascota
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
        Me.petadd_pic_close = New System.Windows.Forms.PictureBox()
        Me.petadd_gb_dates = New System.Windows.Forms.GroupBox()
        Me.petadd_gb_vacunas = New System.Windows.Forms.GroupBox()
        Me.petadd_cb_antirabica = New System.Windows.Forms.CheckBox()
        Me.petadd_cb_sextuple3 = New System.Windows.Forms.CheckBox()
        Me.petadd_cb_sextuple2 = New System.Windows.Forms.CheckBox()
        Me.petadd_cb_sextuple1 = New System.Windows.Forms.CheckBox()
        Me.petadd_txt_fnac = New System.Windows.Forms.DateTimePicker()
        Me.petadd_lbl_fnac = New System.Windows.Forms.Label()
        Me.petadd_txt_nombre = New System.Windows.Forms.TextBox()
        Me.petadd_lbl_nombre = New System.Windows.Forms.Label()
        Me.petadd_lbl_type = New System.Windows.Forms.Label()
        Me.petadd_cmb_type = New System.Windows.Forms.ComboBox()
        Me.petadd_pic_pet = New System.Windows.Forms.PictureBox()
        Me.petadd_pic_add = New System.Windows.Forms.PictureBox()
        Me.petadd_fd_imagen = New System.Windows.Forms.OpenFileDialog()
        Me.petadd_pic_edit = New System.Windows.Forms.PictureBox()
        CType(Me.petadd_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.petadd_gb_dates.SuspendLayout()
        Me.petadd_gb_vacunas.SuspendLayout()
        CType(Me.petadd_pic_pet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.petadd_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.petadd_pic_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'petadd_pic_close
        '
        Me.petadd_pic_close.Location = New System.Drawing.Point(681, 6)
        Me.petadd_pic_close.Name = "petadd_pic_close"
        Me.petadd_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.petadd_pic_close.TabIndex = 0
        Me.petadd_pic_close.TabStop = False
        '
        'petadd_gb_dates
        '
        Me.petadd_gb_dates.Controls.Add(Me.petadd_gb_vacunas)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_txt_fnac)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_lbl_fnac)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_txt_nombre)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_lbl_nombre)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_lbl_type)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_cmb_type)
        Me.petadd_gb_dates.Controls.Add(Me.petadd_pic_pet)
        Me.petadd_gb_dates.Location = New System.Drawing.Point(12, 46)
        Me.petadd_gb_dates.Name = "petadd_gb_dates"
        Me.petadd_gb_dates.Size = New System.Drawing.Size(697, 229)
        Me.petadd_gb_dates.TabIndex = 1
        Me.petadd_gb_dates.TabStop = False
        '
        'petadd_gb_vacunas
        '
        Me.petadd_gb_vacunas.Controls.Add(Me.petadd_cb_antirabica)
        Me.petadd_gb_vacunas.Controls.Add(Me.petadd_cb_sextuple3)
        Me.petadd_gb_vacunas.Controls.Add(Me.petadd_cb_sextuple2)
        Me.petadd_gb_vacunas.Controls.Add(Me.petadd_cb_sextuple1)
        Me.petadd_gb_vacunas.Location = New System.Drawing.Point(439, 112)
        Me.petadd_gb_vacunas.Name = "petadd_gb_vacunas"
        Me.petadd_gb_vacunas.Size = New System.Drawing.Size(252, 111)
        Me.petadd_gb_vacunas.TabIndex = 7
        Me.petadd_gb_vacunas.TabStop = False
        Me.petadd_gb_vacunas.Text = "VACUNAS"
        '
        'petadd_cb_antirabica
        '
        Me.petadd_cb_antirabica.AutoSize = True
        Me.petadd_cb_antirabica.Location = New System.Drawing.Point(10, 89)
        Me.petadd_cb_antirabica.Name = "petadd_cb_antirabica"
        Me.petadd_cb_antirabica.Size = New System.Drawing.Size(90, 17)
        Me.petadd_cb_antirabica.TabIndex = 3
        Me.petadd_cb_antirabica.Text = "ANTIRABICA"
        Me.petadd_cb_antirabica.UseVisualStyleBackColor = True
        '
        'petadd_cb_sextuple3
        '
        Me.petadd_cb_sextuple3.AutoSize = True
        Me.petadd_cb_sextuple3.Location = New System.Drawing.Point(10, 66)
        Me.petadd_cb_sextuple3.Name = "petadd_cb_sextuple3"
        Me.petadd_cb_sextuple3.Size = New System.Drawing.Size(149, 17)
        Me.petadd_cb_sextuple3.TabIndex = 2
        Me.petadd_cb_sextuple3.Text = "SEXTUPLE / OCUPLE 3°"
        Me.petadd_cb_sextuple3.UseVisualStyleBackColor = True
        '
        'petadd_cb_sextuple2
        '
        Me.petadd_cb_sextuple2.AutoSize = True
        Me.petadd_cb_sextuple2.Location = New System.Drawing.Point(10, 43)
        Me.petadd_cb_sextuple2.Name = "petadd_cb_sextuple2"
        Me.petadd_cb_sextuple2.Size = New System.Drawing.Size(149, 17)
        Me.petadd_cb_sextuple2.TabIndex = 1
        Me.petadd_cb_sextuple2.Text = "SEXTUPLE / OCUPLE 2°"
        Me.petadd_cb_sextuple2.UseVisualStyleBackColor = True
        '
        'petadd_cb_sextuple1
        '
        Me.petadd_cb_sextuple1.AutoSize = True
        Me.petadd_cb_sextuple1.Location = New System.Drawing.Point(10, 20)
        Me.petadd_cb_sextuple1.Name = "petadd_cb_sextuple1"
        Me.petadd_cb_sextuple1.Size = New System.Drawing.Size(149, 17)
        Me.petadd_cb_sextuple1.TabIndex = 0
        Me.petadd_cb_sextuple1.Text = "SEXTUPLE / OCUPLE 1°"
        Me.petadd_cb_sextuple1.UseVisualStyleBackColor = True
        '
        'petadd_txt_fnac
        '
        Me.petadd_txt_fnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.petadd_txt_fnac.Location = New System.Drawing.Point(222, 104)
        Me.petadd_txt_fnac.Name = "petadd_txt_fnac"
        Me.petadd_txt_fnac.Size = New System.Drawing.Size(182, 20)
        Me.petadd_txt_fnac.TabIndex = 6
        '
        'petadd_lbl_fnac
        '
        Me.petadd_lbl_fnac.AutoSize = True
        Me.petadd_lbl_fnac.Location = New System.Drawing.Point(219, 88)
        Me.petadd_lbl_fnac.Name = "petadd_lbl_fnac"
        Me.petadd_lbl_fnac.Size = New System.Drawing.Size(130, 13)
        Me.petadd_lbl_fnac.TabIndex = 5
        Me.petadd_lbl_fnac.Text = "FECHA DE NACIMIENTO"
        '
        'petadd_txt_nombre
        '
        Me.petadd_txt_nombre.Location = New System.Drawing.Point(222, 56)
        Me.petadd_txt_nombre.Name = "petadd_txt_nombre"
        Me.petadd_txt_nombre.Size = New System.Drawing.Size(182, 20)
        Me.petadd_txt_nombre.TabIndex = 4
        '
        'petadd_lbl_nombre
        '
        Me.petadd_lbl_nombre.AutoSize = True
        Me.petadd_lbl_nombre.Location = New System.Drawing.Point(219, 40)
        Me.petadd_lbl_nombre.Name = "petadd_lbl_nombre"
        Me.petadd_lbl_nombre.Size = New System.Drawing.Size(54, 13)
        Me.petadd_lbl_nombre.TabIndex = 3
        Me.petadd_lbl_nombre.Text = "NOMBRE"
        '
        'petadd_lbl_type
        '
        Me.petadd_lbl_type.AutoSize = True
        Me.petadd_lbl_type.Location = New System.Drawing.Point(477, 19)
        Me.petadd_lbl_type.Name = "petadd_lbl_type"
        Me.petadd_lbl_type.Size = New System.Drawing.Size(87, 13)
        Me.petadd_lbl_type.TabIndex = 2
        Me.petadd_lbl_type.Text = "TIPO MASCOTA"
        '
        'petadd_cmb_type
        '
        Me.petadd_cmb_type.FormattingEnabled = True
        Me.petadd_cmb_type.Location = New System.Drawing.Point(570, 16)
        Me.petadd_cmb_type.Name = "petadd_cmb_type"
        Me.petadd_cmb_type.Size = New System.Drawing.Size(121, 21)
        Me.petadd_cmb_type.TabIndex = 1
        '
        'petadd_pic_pet
        '
        Me.petadd_pic_pet.Location = New System.Drawing.Point(6, 19)
        Me.petadd_pic_pet.Name = "petadd_pic_pet"
        Me.petadd_pic_pet.Size = New System.Drawing.Size(207, 188)
        Me.petadd_pic_pet.TabIndex = 0
        Me.petadd_pic_pet.TabStop = False
        '
        'petadd_pic_add
        '
        Me.petadd_pic_add.Location = New System.Drawing.Point(555, 283)
        Me.petadd_pic_add.Name = "petadd_pic_add"
        Me.petadd_pic_add.Size = New System.Drawing.Size(154, 39)
        Me.petadd_pic_add.TabIndex = 2
        Me.petadd_pic_add.TabStop = False
        '
        'petadd_fd_imagen
        '
        Me.petadd_fd_imagen.FileName = "OpenFileDialog1"
        '
        'petadd_pic_edit
        '
        Me.petadd_pic_edit.Location = New System.Drawing.Point(18, 281)
        Me.petadd_pic_edit.Name = "petadd_pic_edit"
        Me.petadd_pic_edit.Size = New System.Drawing.Size(48, 48)
        Me.petadd_pic_edit.TabIndex = 3
        Me.petadd_pic_edit.TabStop = False
        '
        'agregar_mascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 334)
        Me.Controls.Add(Me.petadd_pic_edit)
        Me.Controls.Add(Me.petadd_pic_add)
        Me.Controls.Add(Me.petadd_gb_dates)
        Me.Controls.Add(Me.petadd_pic_close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agregar_mascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregar_mascota"
        CType(Me.petadd_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.petadd_gb_dates.ResumeLayout(False)
        Me.petadd_gb_dates.PerformLayout()
        Me.petadd_gb_vacunas.ResumeLayout(False)
        Me.petadd_gb_vacunas.PerformLayout()
        CType(Me.petadd_pic_pet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.petadd_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.petadd_pic_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents petadd_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents petadd_gb_dates As System.Windows.Forms.GroupBox
    Friend WithEvents petadd_pic_pet As System.Windows.Forms.PictureBox
    Friend WithEvents petadd_cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents petadd_lbl_type As System.Windows.Forms.Label
    Friend WithEvents petadd_lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents petadd_txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents petadd_gb_vacunas As System.Windows.Forms.GroupBox
    Friend WithEvents petadd_txt_fnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents petadd_lbl_fnac As System.Windows.Forms.Label
    Friend WithEvents petadd_cb_sextuple3 As System.Windows.Forms.CheckBox
    Friend WithEvents petadd_cb_sextuple2 As System.Windows.Forms.CheckBox
    Friend WithEvents petadd_cb_sextuple1 As System.Windows.Forms.CheckBox
    Friend WithEvents petadd_cb_antirabica As System.Windows.Forms.CheckBox
    Friend WithEvents petadd_pic_add As System.Windows.Forms.PictureBox
    Friend WithEvents petadd_fd_imagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents petadd_pic_edit As System.Windows.Forms.PictureBox
End Class
