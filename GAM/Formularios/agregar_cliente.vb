Public Class agregar_cliente
    Public AdoptID As Integer = 0
    Public Foto As String = ""
    Public frmCall As adoptantes
    Public LoadEdit As Boolean = False
    Public FechaNacimiento As Date
    Public Nombre As String = ""
    Public ApellidoP As String = ""
    Public ApellidoM As String = ""
    Public Rut As String = ""
    Public Telefono As String = ""
    Public Celular As String = ""
    Public Direccion As String = ""
    Private Sub agregar_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.adoptadd_pic_close.Image = Image.FromFile(Application.StartupPath & "\Data\ico\close32x.png")
        Me.adoptadd_pic_avatar.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\adoptpic.png")
        Me.adoptadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        ' # ESTABLECE PARAMETROS ADICIONALES DEL FORMULARIO.
        Me.adoptadd_pic_add.Cursor = Cursors.Hand
        Me.adoptadd_pic_close.Cursor = Cursors.Hand
        ' # SI CARGA EL FORMULARIO EN MODO EDICION LLAMAMOS Y ESTABLECEMOS EL VALOR A LOS CONTROLES.
        If LoadEdit = True Then
            Me.adoptadd_pic_add.Visible = False
            Me.adoptadd_pic_avatar.Image = Image.FromFile(ConfigParametros("path_avatar") & Foto)
            Me.adoptadd_txt_nombre.Text = Nombre
            Me.adoptadd_txt_apellidop.Text = ApellidoP
            Me.adoptadd_txt_apellidom.Text = ApellidoM
            Me.adoptadd_txt_rut.Text = Rut
            Me.adoptadd_txt_telefono.Text = Telefono
            Me.adoptadd_txt_celular.Text = Celular
            Me.adoptadd_txt_direccion.Text = Direccion
            Me.adoptadd_txt_fnac.Value = FechaNacimiento
            ' # BLOQUEAMOS LOS CONTROLES PARA IMPEDIR SU EDICION.
            Me.adoptadd_gb_datos.Enabled = False
        End If
    End Sub
    Private Sub adoptadd_pic_close_Click(sender As Object, e As EventArgs) Handles adoptadd_pic_close.Click
        Me.Close()
    End Sub
    Private Sub adoptadd_pic_add_MouseMove(sender As Object, e As MouseEventArgs) Handles adoptadd_pic_add.MouseMove
        Me.adoptadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_hoverl.png")
    End Sub
    Private Sub adoptadd_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles adoptadd_pic_add.MouseLeave
        Me.adoptadd_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
    End Sub
    Private Sub adoptadd_pic_avatar_Click(sender As Object, e As EventArgs) Handles adoptadd_pic_avatar.Click
        ' # FUNCION QUE CARGA LA IMAGEN DEL CLIENTE
        If Foto <> "" Then
            MISC_DELETEFILE(ConfigParametros("path_avatar") & Foto)
        End If
        Me.adoptadd_fd_imagen = New OpenFileDialog
        Me.adoptadd_fd_imagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Me.adoptadd_fd_imagen.Title = "CARGE FOTOGRAFIA DE LA MASCOTA"
        Me.adoptadd_fd_imagen.Filter = "Fotografias|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        Me.adoptadd_fd_imagen.Multiselect = False
        If Me.adoptadd_fd_imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Foto = MISC_COPYIMAGECLIENTE(Me.adoptadd_fd_imagen.FileName, Me.adoptadd_pic_avatar)
        End If
    End Sub
    Private Sub adoptadd_pic_add_Click(sender As Object, e As EventArgs) Handles adoptadd_pic_add.Click
        ' # REALIZAMOS LA COMRPOBACION DE LOS CAMPOS Y PROCEDEMOS A GUARDAR LA INFORMACION.
        If Me.adoptadd_txt_nombre.Text.Length < 4 Then
            Exit Sub
        End If
        If Me.adoptadd_txt_apellidop.Text.Length < 4 Then
            Exit Sub
        End If
        If Me.adoptadd_txt_apellidom.Text.Length < 4 Then
            Exit Sub
        End If
        If Me.adoptadd_txt_rut.Text.Length < 9 Then
            Exit Sub
        End If
        If Me.adoptadd_txt_telefono.Text.Length < 5 Then
            Exit Sub
        End If
        If Me.adoptadd_txt_celular.Text.Length < 5 Then
            Exit Sub
        End If
        If Foto = "" Then
            If MessageBox.Show("¿Esta seguro que desea agregar al adoptante sin imagen de perfil?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        If LoadEdit = False Then
            If PGSQL_ADDADOPTANTE(Me.adoptadd_txt_nombre.Text, Me.adoptadd_txt_apellidop.Text, Me.adoptadd_txt_apellidom.Text, Me.adoptadd_txt_rut.Text, _
                                  Me.adoptadd_txt_fnac.Value, Me.adoptadd_txt_telefono.Text, Me.adoptadd_txt_celular.Text, Me.adoptadd_txt_direccion.Text, Foto) = True Then
                MessageBox.Show("Adoptante añadido exitosamente al sistema!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmCall.NuevoAdoptanteADD()
                Me.Close()
            End If
        Else

        End If
    End Sub
End Class