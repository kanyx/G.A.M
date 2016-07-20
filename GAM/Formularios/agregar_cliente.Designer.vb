<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_cliente
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
        Me.adoptadd_pic_avatar = New System.Windows.Forms.PictureBox()
        Me.adoptadd_pic_close = New System.Windows.Forms.PictureBox()
        Me.adoptadd_gb_datos = New System.Windows.Forms.GroupBox()
        Me.adoptadd_txt_direccion = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_direccion = New System.Windows.Forms.Label()
        Me.adoptadd_txt_fnac = New System.Windows.Forms.DateTimePicker()
        Me.adoptadd_lbl_fnac = New System.Windows.Forms.Label()
        Me.adoptadd_txt_telefono = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_celular = New System.Windows.Forms.Label()
        Me.adoptadd_txt_celular = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_telefono = New System.Windows.Forms.Label()
        Me.adoptadd_txt_rut = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_rut = New System.Windows.Forms.Label()
        Me.adoptadd_txt_apellidom = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_apellidom = New System.Windows.Forms.Label()
        Me.adoptadd_txt_apellidop = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_apellidop = New System.Windows.Forms.Label()
        Me.adoptadd_txt_nombre = New System.Windows.Forms.TextBox()
        Me.adoptadd_lbl_nombre = New System.Windows.Forms.Label()
        Me.adoptadd_pic_add = New System.Windows.Forms.PictureBox()
        Me.adoptadd_fd_imagen = New System.Windows.Forms.OpenFileDialog()
        Me.adoptadd_pic_edit = New System.Windows.Forms.PictureBox()
        CType(Me.adoptadd_pic_avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adoptadd_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adoptadd_gb_datos.SuspendLayout()
        CType(Me.adoptadd_pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adoptadd_pic_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adoptadd_pic_avatar
        '
        Me.adoptadd_pic_avatar.Location = New System.Drawing.Point(12, 52)
        Me.adoptadd_pic_avatar.Name = "adoptadd_pic_avatar"
        Me.adoptadd_pic_avatar.Size = New System.Drawing.Size(207, 188)
        Me.adoptadd_pic_avatar.TabIndex = 0
        Me.adoptadd_pic_avatar.TabStop = False
        '
        'adoptadd_pic_close
        '
        Me.adoptadd_pic_close.Location = New System.Drawing.Point(686, 12)
        Me.adoptadd_pic_close.Name = "adoptadd_pic_close"
        Me.adoptadd_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.adoptadd_pic_close.TabIndex = 1
        Me.adoptadd_pic_close.TabStop = False
        '
        'adoptadd_gb_datos
        '
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_direccion)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_direccion)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_fnac)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_fnac)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_telefono)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_celular)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_celular)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_telefono)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_rut)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_rut)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_apellidom)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_apellidom)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_apellidop)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_apellidop)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_txt_nombre)
        Me.adoptadd_gb_datos.Controls.Add(Me.adoptadd_lbl_nombre)
        Me.adoptadd_gb_datos.Location = New System.Drawing.Point(225, 50)
        Me.adoptadd_gb_datos.Name = "adoptadd_gb_datos"
        Me.adoptadd_gb_datos.Size = New System.Drawing.Size(493, 190)
        Me.adoptadd_gb_datos.TabIndex = 2
        Me.adoptadd_gb_datos.TabStop = False
        Me.adoptadd_gb_datos.Text = "DATOS ADOPTANTE"
        '
        'adoptadd_txt_direccion
        '
        Me.adoptadd_txt_direccion.Location = New System.Drawing.Point(9, 122)
        Me.adoptadd_txt_direccion.Name = "adoptadd_txt_direccion"
        Me.adoptadd_txt_direccion.Size = New System.Drawing.Size(248, 20)
        Me.adoptadd_txt_direccion.TabIndex = 15
        '
        'adoptadd_lbl_direccion
        '
        Me.adoptadd_lbl_direccion.AutoSize = True
        Me.adoptadd_lbl_direccion.Location = New System.Drawing.Point(6, 106)
        Me.adoptadd_lbl_direccion.Name = "adoptadd_lbl_direccion"
        Me.adoptadd_lbl_direccion.Size = New System.Drawing.Size(66, 13)
        Me.adoptadd_lbl_direccion.TabIndex = 14
        Me.adoptadd_lbl_direccion.Text = "DIRECCION"
        '
        'adoptadd_txt_fnac
        '
        Me.adoptadd_txt_fnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.adoptadd_txt_fnac.Location = New System.Drawing.Point(142, 83)
        Me.adoptadd_txt_fnac.Name = "adoptadd_txt_fnac"
        Me.adoptadd_txt_fnac.Size = New System.Drawing.Size(115, 20)
        Me.adoptadd_txt_fnac.TabIndex = 13
        '
        'adoptadd_lbl_fnac
        '
        Me.adoptadd_lbl_fnac.AutoSize = True
        Me.adoptadd_lbl_fnac.Location = New System.Drawing.Point(139, 67)
        Me.adoptadd_lbl_fnac.Name = "adoptadd_lbl_fnac"
        Me.adoptadd_lbl_fnac.Size = New System.Drawing.Size(109, 13)
        Me.adoptadd_lbl_fnac.TabIndex = 12
        Me.adoptadd_lbl_fnac.Text = "FECHA NACIMENTO"
        '
        'adoptadd_txt_telefono
        '
        Me.adoptadd_txt_telefono.Location = New System.Drawing.Point(263, 83)
        Me.adoptadd_txt_telefono.Name = "adoptadd_txt_telefono"
        Me.adoptadd_txt_telefono.Size = New System.Drawing.Size(103, 20)
        Me.adoptadd_txt_telefono.TabIndex = 11
        '
        'adoptadd_lbl_celular
        '
        Me.adoptadd_lbl_celular.AutoSize = True
        Me.adoptadd_lbl_celular.Location = New System.Drawing.Point(372, 67)
        Me.adoptadd_lbl_celular.Name = "adoptadd_lbl_celular"
        Me.adoptadd_lbl_celular.Size = New System.Drawing.Size(56, 13)
        Me.adoptadd_lbl_celular.TabIndex = 10
        Me.adoptadd_lbl_celular.Text = "CELULAR"
        '
        'adoptadd_txt_celular
        '
        Me.adoptadd_txt_celular.Location = New System.Drawing.Point(372, 83)
        Me.adoptadd_txt_celular.Name = "adoptadd_txt_celular"
        Me.adoptadd_txt_celular.Size = New System.Drawing.Size(87, 20)
        Me.adoptadd_txt_celular.TabIndex = 9
        '
        'adoptadd_lbl_telefono
        '
        Me.adoptadd_lbl_telefono.AutoSize = True
        Me.adoptadd_lbl_telefono.Location = New System.Drawing.Point(260, 67)
        Me.adoptadd_lbl_telefono.Name = "adoptadd_lbl_telefono"
        Me.adoptadd_lbl_telefono.Size = New System.Drawing.Size(64, 13)
        Me.adoptadd_lbl_telefono.TabIndex = 8
        Me.adoptadd_lbl_telefono.Text = "TELEFONO"
        '
        'adoptadd_txt_rut
        '
        Me.adoptadd_txt_rut.Location = New System.Drawing.Point(9, 83)
        Me.adoptadd_txt_rut.Name = "adoptadd_txt_rut"
        Me.adoptadd_txt_rut.Size = New System.Drawing.Size(127, 20)
        Me.adoptadd_txt_rut.TabIndex = 7
        '
        'adoptadd_lbl_rut
        '
        Me.adoptadd_lbl_rut.AutoSize = True
        Me.adoptadd_lbl_rut.Location = New System.Drawing.Point(6, 67)
        Me.adoptadd_lbl_rut.Name = "adoptadd_lbl_rut"
        Me.adoptadd_lbl_rut.Size = New System.Drawing.Size(30, 13)
        Me.adoptadd_lbl_rut.TabIndex = 6
        Me.adoptadd_lbl_rut.Text = "RUT"
        '
        'adoptadd_txt_apellidom
        '
        Me.adoptadd_txt_apellidom.Location = New System.Drawing.Point(332, 44)
        Me.adoptadd_txt_apellidom.Name = "adoptadd_txt_apellidom"
        Me.adoptadd_txt_apellidom.Size = New System.Drawing.Size(127, 20)
        Me.adoptadd_txt_apellidom.TabIndex = 5
        '
        'adoptadd_lbl_apellidom
        '
        Me.adoptadd_lbl_apellidom.AutoSize = True
        Me.adoptadd_lbl_apellidom.Location = New System.Drawing.Point(329, 28)
        Me.adoptadd_lbl_apellidom.Name = "adoptadd_lbl_apellidom"
        Me.adoptadd_lbl_apellidom.Size = New System.Drawing.Size(116, 13)
        Me.adoptadd_lbl_apellidom.TabIndex = 4
        Me.adoptadd_lbl_apellidom.Text = "APELLIDO MATERNO"
        '
        'adoptadd_txt_apellidop
        '
        Me.adoptadd_txt_apellidop.Location = New System.Drawing.Point(196, 44)
        Me.adoptadd_txt_apellidop.Name = "adoptadd_txt_apellidop"
        Me.adoptadd_txt_apellidop.Size = New System.Drawing.Size(127, 20)
        Me.adoptadd_txt_apellidop.TabIndex = 3
        '
        'adoptadd_lbl_apellidop
        '
        Me.adoptadd_lbl_apellidop.AutoSize = True
        Me.adoptadd_lbl_apellidop.Location = New System.Drawing.Point(193, 28)
        Me.adoptadd_lbl_apellidop.Name = "adoptadd_lbl_apellidop"
        Me.adoptadd_lbl_apellidop.Size = New System.Drawing.Size(114, 13)
        Me.adoptadd_lbl_apellidop.TabIndex = 2
        Me.adoptadd_lbl_apellidop.Text = "APELLIDO PATERNO"
        '
        'adoptadd_txt_nombre
        '
        Me.adoptadd_txt_nombre.Location = New System.Drawing.Point(9, 44)
        Me.adoptadd_txt_nombre.Name = "adoptadd_txt_nombre"
        Me.adoptadd_txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.adoptadd_txt_nombre.TabIndex = 1
        '
        'adoptadd_lbl_nombre
        '
        Me.adoptadd_lbl_nombre.AutoSize = True
        Me.adoptadd_lbl_nombre.Location = New System.Drawing.Point(6, 28)
        Me.adoptadd_lbl_nombre.Name = "adoptadd_lbl_nombre"
        Me.adoptadd_lbl_nombre.Size = New System.Drawing.Size(61, 13)
        Me.adoptadd_lbl_nombre.TabIndex = 0
        Me.adoptadd_lbl_nombre.Text = "NOMBRES"
        '
        'adoptadd_pic_add
        '
        Me.adoptadd_pic_add.Location = New System.Drawing.Point(564, 246)
        Me.adoptadd_pic_add.Name = "adoptadd_pic_add"
        Me.adoptadd_pic_add.Size = New System.Drawing.Size(154, 39)
        Me.adoptadd_pic_add.TabIndex = 3
        Me.adoptadd_pic_add.TabStop = False
        '
        'adoptadd_fd_imagen
        '
        Me.adoptadd_fd_imagen.FileName = "OpenFileDialog1"
        '
        'adoptadd_pic_edit
        '
        Me.adoptadd_pic_edit.Location = New System.Drawing.Point(29, 246)
        Me.adoptadd_pic_edit.Name = "adoptadd_pic_edit"
        Me.adoptadd_pic_edit.Size = New System.Drawing.Size(48, 48)
        Me.adoptadd_pic_edit.TabIndex = 4
        Me.adoptadd_pic_edit.TabStop = False
        '
        'agregar_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 294)
        Me.Controls.Add(Me.adoptadd_pic_edit)
        Me.Controls.Add(Me.adoptadd_pic_add)
        Me.Controls.Add(Me.adoptadd_gb_datos)
        Me.Controls.Add(Me.adoptadd_pic_close)
        Me.Controls.Add(Me.adoptadd_pic_avatar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agregar_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregar_cliente"
        CType(Me.adoptadd_pic_avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adoptadd_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adoptadd_gb_datos.ResumeLayout(False)
        Me.adoptadd_gb_datos.PerformLayout()
        CType(Me.adoptadd_pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adoptadd_pic_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adoptadd_pic_avatar As System.Windows.Forms.PictureBox
    Friend WithEvents adoptadd_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents adoptadd_gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents adoptadd_txt_apellidom As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_apellidom As System.Windows.Forms.Label
    Friend WithEvents adoptadd_txt_apellidop As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_apellidop As System.Windows.Forms.Label
    Friend WithEvents adoptadd_txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents adoptadd_txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents adoptadd_txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_rut As System.Windows.Forms.Label
    Friend WithEvents adoptadd_txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_celular As System.Windows.Forms.Label
    Friend WithEvents adoptadd_txt_fnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents adoptadd_lbl_fnac As System.Windows.Forms.Label
    Friend WithEvents adoptadd_pic_add As System.Windows.Forms.PictureBox
    Friend WithEvents adoptadd_txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents adoptadd_lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents adoptadd_fd_imagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents adoptadd_pic_edit As System.Windows.Forms.PictureBox
End Class
