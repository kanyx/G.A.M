Imports System.Drawing.Text
Public Class main_dashboard
    Private MyriadPro_Bold As New PrivateFontCollection()
    Private MyriadPro_Normal As New PrivateFontCollection()
    Private Sub main_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.main_pic_logo.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\logo.png")
        Me.main_pic_close.Image = Image.FromFile(Application.StartupPath & "\Data\ico\close32x.png")
        Me.main_il_menu.Images.Add(0, Image.FromFile(Application.StartupPath & "\Data\ico\desktop_24px.png"))
        Me.main_il_menu.Images.Add(1, Image.FromFile(Application.StartupPath & "\Data\ico\adoption_24px.png"))
        Me.main_il_menu.Images.Add(2, Image.FromFile(Application.StartupPath & "\Data\ico\clientes_24px.png"))
        Me.main_il_menu.Images.Add(3, Image.FromFile(Application.StartupPath & "\Data\ico\pet_24px.png"))
        Me.main_pic_user.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\nofoto.png")
        ' # ESTABLECEMOS PARAMETROS DE LOS CONTROLES.
        MyriadPro_Bold.AddFontFile(Application.StartupPath & "\Data\fonts\MyriadPro-BoldCond.ttf")
        MyriadPro_Normal.AddFontFile(Application.StartupPath & "\Data\fonts\MyriadPro-Cond.ttf")
        Me.main_lbl_title.Font = New Font(MyriadPro_Bold.Families(0), 16, FontStyle.Bold)
        Me.main_lbl_menu.Font = New Font(MyriadPro_Bold.Families(0), 20, FontStyle.Bold)
        Me.main_menu.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.main_lbl_usernombre.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.main_lbl_usernombrev.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.main_lbl_userrut.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.main_lbl_userrutv.Font = New Font(MyriadPro_Bold.Families(0), 8, FontStyle.Bold)
        Me.main_lbl_welcome.Font = New Font(MyriadPro_Bold.Families(0), 20, FontStyle.Bold)
        Me.main_il_menu.ColorDepth = ColorDepth.Depth32Bit
        Me.main_il_menu.ImageSize = New Size(24, 24)
        Me.main_menu.ImageList = Me.main_il_menu
        Me.main_lbl_title.ForeColor = ColorTranslator.FromHtml("#023d76")
        Me.main_lbl_menu.ForeColor = ColorTranslator.FromHtml("#fbab00")
        Me.main_lbl_welcome.ForeColor = ColorTranslator.FromHtml("#fbab00")
        Me.main_lbl_usernombre.ForeColor = ColorTranslator.FromHtml("#023d76")
        Me.main_lbl_userrut.ForeColor = ColorTranslator.FromHtml("#023d76")
        Me.main_pic_logo.BackColor = Color.Transparent
        Me.main_pic_close.BackColor = Color.Transparent
        Me.main_lbl_menu.BackColor = Color.Transparent
        Me.main_lbl_welcome.BackColor = Color.Transparent
        Me.main_lbl_usernombre.BackColor = Color.Transparent
        Me.main_pic_logo.SizeMode = PictureBoxSizeMode.StretchImage
        Me.main_pic_close.SizeMode = PictureBoxSizeMode.StretchImage
        Me.main_pic_close.Cursor = Cursors.Hand
        ' # CARGAMOS PARAMETROS DESDE LA BASE DE DATOS.
        Dim SplitUser() As String = UserActive("nombres").Split(" ")
        Me.main_lbl_usernombrev.Text = SplitUser(0).ToUpper & " " & UserActive("apellido_p").ToUpper & _
            " " & UserActive("apellido_m").ToUpper
        Me.main_lbl_userrutv.Text = UserActive("rut")
    End Sub
    Private Sub main_pic_close_Click(sender As Object, e As EventArgs) Handles main_pic_close.Click
        ' # FUNCION PARA CERRAR LA APLICACION.
        main_login.Close()
    End Sub
    Private Sub main_menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles main_menu.AfterSelect
        If e.Node.Name = "menu_item_mascotas" Then
            Me.main_pn_loader.Controls.Clear()
            Dim frm_mascotas As New pet
            frm_mascotas.TopLevel = False
            Me.main_pn_loader.Controls.Add(frm_mascotas)
            frm_mascotas.PanelCarga = Me.main_pn_loader
            frm_mascotas.Dock = DockStyle.Fill
            frm_mascotas.Show()
        ElseIf e.Node.Name = "menu_item_adoptantes" Then
            Me.main_pn_loader.Controls.Clear()
            Dim frm_adoptantes As New adoptantes
            frm_adoptantes.TopLevel = False
            Me.main_pn_loader.Controls.Add(frm_adoptantes)
            frm_adoptantes.PanelCarga = Me.main_pn_loader
            frm_adoptantes.Dock = DockStyle.Fill
            frm_adoptantes.Show()
        ElseIf e.Node.Name = "menu_item_adopciones" Then
            Me.main_pn_loader.Controls.Clear()
            Dim frm_adopciones As New adopciones
            frm_adopciones.TopLevel = False
            Me.main_pn_loader.Controls.Add(frm_adopciones)
            frm_adopciones.PanelCarga = main_pn_loader
            frm_adopciones.Dock = DockStyle.Fill
            frm_adopciones.Show()
        End If
    End Sub
    Private Function CheckForm(_form As Form) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next
        Return False
    End Function
End Class