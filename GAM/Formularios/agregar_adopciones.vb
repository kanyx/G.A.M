Public Class agregar_adopciones
    Public Foto As String = ""
    Public frmCall As adopciones
    Public LoadEdit As Boolean = False
    Private Sub agregar_adopciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS GRAFICOS DEL FORMULARIO
        Me.adopciones_pic_close.Image = Image.FromFile(Application.StartupPath & "\Data\ico\close32x.png")
        Me.adopciones_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        Me.adopciones_pic_cliente.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\adoptpic.png")
        Me.adopciones_pic_pet.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\picpet.png")
        ' # ESTABLECEMOS PARAMETROS ADICIONALES DE LA APLICACION.
        Me.adopciones_pic_close.Cursor = Cursors.Hand
        Me.adopciones_pic_add.Cursor = Cursors.Hand
    End Sub
    Private Sub adopciones_pic_close_Click(sender As Object, e As EventArgs) Handles adopciones_pic_close.Click
        ' # AL PRESIONAL BOTON PARA CERRAR EL FORMULARIO.
        Me.Close()
    End Sub
    Private Sub adopciones_pic_add_MouseMove(sender As Object, e As MouseEventArgs) Handles adopciones_pic_add.MouseMove
        Me.adopciones_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_hoverl.png")
    End Sub
    Private Sub adopciones_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles adopciones_pic_add.MouseLeave
        Me.adopciones_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
    End Sub
End Class