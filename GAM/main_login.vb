Imports System.Drawing.Text
Public Class main_login
    Private MyriadPro_Bold As New PrivateFontCollection()
    Private Sub main_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS GRAFICOS DEL FORMULARIO
        Me.login_pic_logo.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\logo.png")
        Me.login_pic_close.Image = Image.FromFile(Application.StartupPath & "\Data\ico\close32x.png")
        Me.login_pic_enter.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_entrar_normal.png")
        ' # ESTABLECE PARAMETROS A LOS CONTROLES.
        MyriadPro_Bold.AddFontFile(Application.StartupPath & "\Data\fonts\MyriadPro-BoldCond.ttf")
        Me.BackColor = ColorTranslator.FromHtml("#ffffff")
        Me.login_lbl_user.Font = New Font(MyriadPro_Bold.Families(0), 12, FontStyle.Bold)
        Me.login_lbl_pass.Font = New Font(MyriadPro_Bold.Families(0), 12, FontStyle.Bold)
        Me.login_txt_user.Font = New Font(MyriadPro_Bold.Families(0), 12, FontStyle.Bold)
        Me.login_txt_pass.Font = New Font(MyriadPro_Bold.Families(0), 12, FontStyle.Bold)
        Me.login_lbl_footer.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.login_txt_pass.PasswordChar = "*"
        Me.login_pic_logo.SizeMode = PictureBoxSizeMode.StretchImage
        Me.login_lbl_user.ForeColor = ColorTranslator.FromHtml("#023d76")
        Me.login_lbl_pass.ForeColor = ColorTranslator.FromHtml("#023d76")
        Me.login_txt_user.ForeColor = ColorTranslator.FromHtml("#ca5100")
        Me.login_txt_pass.ForeColor = ColorTranslator.FromHtml("#ca5100")
        Me.login_lbl_footer.ForeColor = ColorTranslator.FromHtml("#023d76")
        Me.login_lbl_user.BackColor = Color.Transparent
        Me.login_lbl_pass.BackColor = Color.Transparent
        Me.login_pic_logo.BackColor = Color.Transparent
        Me.login_pic_close.BackColor = Color.Transparent
        Me.login_pic_enter.BackColor = Color.Transparent
        Me.login_pic_close.Cursor = Cursors.Hand
        Me.login_pic_enter.Cursor = Cursors.Hand
        ' # CARGAMOS LOS PARAMETROS DE LA CONFIGURACION DE LA APLICACION.
        Me.login_lbl_footer.Text = "VERSION DE GAM " & Application.ProductVersion
        ConfigParametros.Add("bdserver", "localhost")
        ConfigParametros.Add("bdport", "5432")
        ConfigParametros.Add("bdname", "ambita")
        ConfigParametros.Add("bduser", "postgres")
        ConfigParametros.Add("bdpass", "kanmc267")
        ConfigParametros.Add("path_avatar", Application.StartupPath & "\Data\upload\profilepictures\")
    End Sub
    Private Sub ProcesarLogin()
        ' # COMPROBAMOS LOS VALORES Y PROCEDEMOS CON EL LOGEO DEL USUARIO.
        If Me.login_txt_user.Text.Length < 3 Then
            Me.login_txt_user.ForeColor = ColorTranslator.FromHtml("#ffffff")
            Me.login_txt_user.BackColor = ColorTranslator.FromHtml("#f22c1d")
            Exit Sub
        End If
        If Me.login_txt_pass.Text.Length < 3 Then
            Me.login_txt_pass.ForeColor = ColorTranslator.FromHtml("#ffffff")
            Me.login_txt_pass.BackColor = ColorTranslator.FromHtml("#f22c1d")
            Exit Sub
        End If
        If PGSQL_EXECUTELOGIN(Me.login_txt_user, Me.login_txt_pass) = True Then
            ' # MOSTRAMOS EL FORMULARIO PRINCIPAL DE LA APLICACION
            main_dashboard.Show()
            Me.Hide()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub login_pic_enter_Click(sender As Object, e As EventArgs) Handles login_pic_enter.Click
        Call ProcesarLogin()
    End Sub
    Private Sub login_pic_enter_MouseMove(sender As Object, e As MouseEventArgs) Handles login_pic_enter.MouseMove
        ' # CUANDO PASAMOS EL MAUSE SOBRE EL BOTON ENTRAR.
        Me.login_pic_enter.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_entrar_hover.png")
    End Sub
    Private Sub login_pic_enter_MouseLeave(sender As Object, e As EventArgs) Handles login_pic_enter.MouseLeave
        ' # CUANDO EL BOTON ENTRAR PIERDE EL FOCUS.
        Me.login_pic_enter.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_entrar_normal.png")
    End Sub
    Private Sub login_txt_user_KeyUp(sender As Object, e As KeyEventArgs) Handles login_txt_user.KeyUp
        If e.KeyCode <> Keys.Enter Then
            Me.login_txt_user.ForeColor = ColorTranslator.FromHtml("#ca5100")
            Me.login_txt_user.BackColor = ColorTranslator.FromHtml("#ffffff")
        End If
    End Sub
    Private Sub login_txt_pass_KeyUp(sender As Object, e As KeyEventArgs) Handles login_txt_pass.KeyUp
        If e.KeyCode <> Keys.Enter Then
            Me.login_txt_pass.ForeColor = ColorTranslator.FromHtml("#ca5100")
            Me.login_txt_pass.BackColor = ColorTranslator.FromHtml("#ffffff")
        End If
    End Sub
    Private Sub login_pic_close_Click(sender As Object, e As EventArgs) Handles login_pic_close.Click
        Me.Close()
    End Sub
    Private Sub login_txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles login_txt_pass.KeyDown
        ' # EJECUTAMOS EL LOGIN CUANDO EL USUARIO PRESIONE LA TECLA ENTER.
        If e.KeyCode = Keys.Enter Then
            Call ProcesarLogin()
        End If
    End Sub
End Class