Public Class agregar_mascota
    Public Foto As String = ""
    Public frmCall As pet
    Public Tipo As String = ""
    Public idMascota As Integer = 0
    Public LoadEdit As Boolean = False
    Public Nombre As String = ""
    Public FechaNacimiento As Date
    Private Vacunas As New Dictionary(Of Integer, String)
    Private Sub agregar_mascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.petadd_pic_close.Image = Image.FromFile(Application.StartupPath & "\Data\ico\close32x.png")
        Me.petadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        Me.petadd_pic_pet.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\picpet.png")
        Me.petadd_pic_edit.Image = Image.FromFile(Application.StartupPath & "\Data\ico\edit_96px.png")
        ' # ESTABLECEMOS PARAMETROS ADICIONES A LOS CONTROLES.
        Me.petadd_pic_edit.Visible = False
        Me.petadd_pic_close.Cursor = Cursors.Hand
        Call PGSQL_LOADTYPESPET(Me.petadd_cmb_type)
        Me.petadd_pic_add.Cursor = Cursors.Hand
        If LoadEdit = True Then
            Me.petadd_pic_pet.Image = Image.FromFile(ConfigParametros("path_avatar") & Foto)
            Me.petadd_txt_fnac.Value = FechaNacimiento
            Me.petadd_txt_nombre.Text = Nombre
            Dim SelectTIPO As Integer = Me.petadd_cmb_type.FindString(Tipo.ToString)
            Me.petadd_cmb_type.SelectedIndex = SelectTIPO
            Me.petadd_pic_add.Visible = False
            Vacunas = PGSQL_VACUNASPETLOAD(idMascota)
            If Vacunas.ContainsKey(1) = True Then
                Me.petadd_cb_sextuple1.Checked = True
            End If
            If Vacunas.ContainsKey(2) = True Then
                Me.petadd_cb_sextuple2.Checked = True
            End If
            If Vacunas.ContainsKey(3) = True Then
                Me.petadd_cb_sextuple3.Checked = True
            End If
            If Vacunas.ContainsKey(4) = True Then
                Me.petadd_cb_antirabica.Checked = True
            End If
            ' # ESTABLECEMOS LOS CONTROLES EN MODO SOLO LECTURA.! (PARA PODER EDITARLOS DEBE PRESIONAR EL BOTON DE EDICION).
            Me.petadd_txt_nombre.ReadOnly = True
            Me.petadd_gb_vacunas.Enabled = False
            Me.petadd_txt_fnac.Enabled = False
            Me.petadd_cmb_type.Enabled = False
            Me.petadd_pic_edit.Location = New Point(611, 278)
            Me.petadd_pic_edit.SizeMode = PictureBoxSizeMode.StretchImage
            Me.petadd_pic_edit.Cursor = Cursors.Hand
            Me.petadd_pic_edit.Visible = True
        End If
    End Sub
    Private Sub petadd_pic_close_Click(sender As Object, e As EventArgs) Handles petadd_pic_close.Click
        Me.Close()
    End Sub
    Private Sub petadd_pic_add_MouseMove(sender As Object, e As MouseEventArgs) Handles petadd_pic_add.MouseMove
        If LoadEdit = True Then
            Me.petadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_guardar_hover.png")
        Else
            Me.petadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_hoverl.png")
        End If
    End Sub
    Private Sub petadd_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles petadd_pic_add.MouseLeave
        If LoadEdit = True Then
            Me.petadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_guardar_normal.png")
        Else
            Me.petadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        End If
    End Sub
    Private Sub petadd_pic_add_Click(sender As Object, e As EventArgs) Handles petadd_pic_add.Click
        ' # CUANDO SE PRESIONA EL BOTON GUARDAR.(IMPROTANTE CONSIDERAR LA IMAGEN)
        ' # REALIZAMOS LA COMPROBACION DE CAMPOS PARA PROCEDER CON LA FUNCION DE GUARDADO A LA BASE DE DATOS.
        Dim vacuna1 As Integer = 0
        Dim vacuna2 As Integer = 0
        Dim vacuna3 As Integer = 0
        Dim vacunarabica As Integer = 0
        If Me.petadd_cmb_type.SelectedValue < 1 Then
            Exit Sub
        End If
        If Me.petadd_txt_nombre.Text = "" Or Me.petadd_txt_nombre.Text.Length < 4 Then
            Exit Sub
        End If
        ' # COMPROVAMOS Y CONVERTIMOS LOS VALORES DE CHECKBOX A INTEGER
        If Me.petadd_cb_sextuple1.Checked = True Then
            vacuna1 = 1
        End If
        If Me.petadd_cb_sextuple2.Checked = True Then
            vacuna2 = 2
        End If
        If Me.petadd_cb_sextuple3.Checked = True Then
            vacuna3 = 3
        End If
        If Me.petadd_cb_antirabica.Checked = True Then
            vacunarabica = 4
        End If
        If Foto = "" Then
            If MessageBox.Show("¿Esta seguro que desea guardar la mascota sin ingresar fotografia?", Application.ProductName, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        If LoadEdit = True Then
            If PGSQL_UPDATEPET(idMascota, Me.petadd_txt_nombre.Text, Me.petadd_txt_fnac.Value, Me.petadd_cmb_type.SelectedValue, vacuna1, _
                               vacuna2, vacuna3, vacunarabica, Foto, Vacunas) = True Then
                MessageBox.Show("Datos de la mascota actualizados exitosamente!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmCall.NuevaMascotaADD()
                Me.Close()
            End If
        Else
            If PGSQL_ADDPET(Me.petadd_txt_nombre.Text, Me.petadd_txt_fnac.Value, Me.petadd_cmb_type.SelectedValue, vacuna1, _
                       vacuna2, vacuna3, vacunarabica, Foto) = True Then
                MessageBox.Show("Mascota añadida exitosamente a la base de datos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmCall.NuevaMascotaADD()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub petadd_pic_pet_Click(sender As Object, e As EventArgs) Handles petadd_pic_pet.Click
        ' # RUTINA PARA CARGAR IMAGEN DE LA MASCOTA.
        If Foto <> "" Then
            Me.petadd_pic_pet.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\picpet.png")
            MISC_DELETEFILE(ConfigParametros("path_avatar") & Foto)
        End If
        Me.petadd_fd_imagen = New OpenFileDialog
        Me.petadd_fd_imagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Me.petadd_fd_imagen.Title = "CARGE FOTOGRAFIA DE LA MASCOTA"
        Me.petadd_fd_imagen.Filter = "Fotografias|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        Me.petadd_fd_imagen.Multiselect = False
        If Me.petadd_fd_imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Foto = MISC_COPYIMAGEPET(Me.petadd_fd_imagen.FileName, Me.petadd_pic_pet)
        End If
    End Sub
    Private Sub petadd_pic_edit_Click(sender As Object, e As EventArgs) Handles petadd_pic_edit.Click
        ' # ACTIVAMOS EL FORMULARIO PARA QUE SE PUEDA EDITAR.
        Me.petadd_txt_nombre.ReadOnly = False
        Me.petadd_gb_vacunas.Enabled = True
        Me.petadd_txt_fnac.Enabled = True
        Me.petadd_cmb_type.Enabled = True
        Me.petadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_guardar_normal.png")
        Me.petadd_pic_edit.Visible = False
        Me.petadd_pic_add.Visible = True
    End Sub
End Class