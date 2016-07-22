Public Class adopciones
    Public PanelCarga As Panel
    Private Sub adopciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA ELEMENTOS GRAFICOS DEL FORMULARIO.
        Me.adopcion_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        ' # ESTABLECE PARAMETROS ADICIONALES A LOS CONTROLES.
        Me.adopcion_pic_add.Cursor = Cursors.Hand
    End Sub
    Private Sub adopcion_pic_add_MouseMove(sender As Object, e As MouseEventArgs) Handles adopcion_pic_add.MouseMove
        Me.adopcion_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_hoverl.png")
    End Sub
    Private Sub adopcion_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles adopcion_pic_add.MouseLeave
        Me.adopcion_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
    End Sub
    Private Sub adopcion_pic_add_Click(sender As Object, e As EventArgs) Handles adopcion_pic_add.Click
        ' # CARGAMOS EL FORMULARIO PARA AÑADIR UNA NUEVA ADOPCION.
        Dim frm_addadopt As New agregar_adopciones
        frm_addadopt.frmCall = Me
        frm_addadopt.ShowDialog()
    End Sub
End Class