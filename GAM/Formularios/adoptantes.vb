Public Class adoptantes
    Public PanelCarga As Panel
    Private Sub adoptantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGAMOS ELEMENTOS GRAFICOS DELFORMULARIO.
        Me.adopt_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        ' # ESTABLECEMOS PARAMETROS ADICIONALES AL FORMULARIO.
        Call PGSQL_LISTADOPTANTES(Me.adopt_dg_adoptantes)
    End Sub
    Private Sub adop_pic_add_Click(sender As Object, e As EventArgs) Handles adopt_pic_add.Click
        Dim frm_addadopt As New agregar_cliente
        frm_addadopt.frmCall = Me
        frm_addadopt.ShowDialog()
    End Sub
    Private Sub adop_pic_add_MouseMove(sender As Object, e As MouseEventArgs) Handles adopt_pic_add.MouseMove
        Me.adopt_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_hoverl.png")
    End Sub
    Private Sub adop_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles adopt_pic_add.MouseLeave
        Me.adopt_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
    End Sub
    Public Sub NuevoAdoptanteADD()
        Dim frm_adoptante As New adoptantes
        frm_adoptante.TopLevel = False
        frm_adoptante.PanelCarga = PanelCarga
        PanelCarga.Controls.Add(frm_adoptante)
        frm_adoptante.Dock = DockStyle.Fill
        frm_adoptante.Show()
        Me.Close()
    End Sub
    Private Sub adopt_dg_adoptantes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles adopt_dg_adoptantes.CellContentDoubleClick
        ' # AL PRESIONAR SOBRE UN REGISTRO DE LA TABLA.
        Dim frm_editdoptantes As New agregar_cliente
        frm_editdoptantes.frmCall = Me
        frm_editdoptantes.Foto = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(6).Value
        frm_editdoptantes.AdoptID = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(0).Value
        frm_editdoptantes.FechaNacimiento = Date.Parse(Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(7).Value)
        frm_editdoptantes.Nombre = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(8).Value
        frm_editdoptantes.ApellidoP = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(9).Value
        frm_editdoptantes.ApellidoM = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(10).Value
        frm_editdoptantes.Rut = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(1).Value
        frm_editdoptantes.Telefono = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(3).Value
        frm_editdoptantes.Celular = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(4).Value
        frm_editdoptantes.Direccion = Me.adopt_dg_adoptantes.Rows(e.RowIndex).Cells(5).Value
        frm_editdoptantes.LoadEdit = True
        frm_editdoptantes.ShowDialog()
    End Sub
End Class