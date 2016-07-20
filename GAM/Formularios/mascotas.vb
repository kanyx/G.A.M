Imports System.Drawing.Text
Public Class pet
    Private MyriadPro_Bold As New PrivateFontCollection()
    Public PanelCarga As Panel
    Private Sub mascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' # CARGA DE ELEMENTOS GRAFICOS DEL FORMULARIO
        Me.pet_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
        ' # ESTABLECEMOS PARAMETROS EXTRAS A LOS CONTROLES DEL FORMULARIO.
        Call PGSQL_LISTMASCOTAS(Me.pet_dv_mascotas)
        MyriadPro_Bold.AddFontFile(Application.StartupPath & "\Data\fonts\MyriadPro-BoldCond.ttf")
    End Sub
    Private Sub pet_pic_add_Click(sender As Object, e As EventArgs) Handles pet_pic_add.Click
        Dim frm_addpet As New agregar_mascota
        frm_addpet.frmCall = Me
        frm_addpet.ShowDialog()
    End Sub
    Private Sub pet_pic_add_MouseMove(sender As Object, e As MouseEventArgs) Handles pet_pic_add.MouseMove
        ' # CUANDO EL USUAIO PASA EL MAUSE SOBRE EL OBJETO.
        Me.pet_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_hoverl.png")
    End Sub
    Private Sub pet_pic_add_MouseLeave(sender As Object, e As EventArgs) Handles pet_pic_add.MouseLeave
        ' # CUANDO SE PEIRDE EL CONTROL FOCUS SOBRE EL OBJETO.
        Me.pet_pic_add.Image = Image.FromFile(Application.StartupPath & "\Data\grafica\btn_agregar_normal.png")
    End Sub
    Private Sub pet_dv_mascotas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles pet_dv_mascotas.CellContentDoubleClick
        ' # CUANDO SE LE HACE DOBLE CLICK A UNA MASCOTA EN LA LISTA.
        Dim frm_addpet As New agregar_mascota
        frm_addpet.frmCall = Me
        frm_addpet.Foto = Me.pet_dv_mascotas.Rows(e.RowIndex).Cells(7).Value
        frm_addpet.idMascota = Me.pet_dv_mascotas.Rows(e.RowIndex).Cells(0).Value
        frm_addpet.Tipo = Me.pet_dv_mascotas.Rows(e.RowIndex).Cells(2).Value
        frm_addpet.FechaNacimiento = Date.Parse(Me.pet_dv_mascotas.Rows(e.RowIndex).Cells(5).Value)
        frm_addpet.Nombre = Me.pet_dv_mascotas.Rows(e.RowIndex).Cells(1).Value
        frm_addpet.LoadEdit = True
        frm_addpet.ShowDialog()
    End Sub
    Public Sub NuevaMascotaADD()
        Dim frm_mascotas As New pet
        frm_mascotas.TopLevel = False
        frm_mascotas.PanelCarga = PanelCarga
        PanelCarga.Controls.Add(frm_mascotas)
        frm_mascotas.Dock = DockStyle.Fill
        frm_mascotas.Show()
        Me.Close()
    End Sub
End Class