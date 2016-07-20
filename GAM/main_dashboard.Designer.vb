<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DASHBOARD", 0, 0)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MASCOTAS", 3, 3)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ADOPTANTES", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ADOPCIONES", 1, 1)
        Me.main_pic_logo = New System.Windows.Forms.PictureBox()
        Me.main_pn_loader = New System.Windows.Forms.Panel()
        Me.main_menu = New System.Windows.Forms.TreeView()
        Me.main_il_menu = New System.Windows.Forms.ImageList(Me.components)
        Me.main_lbl_title = New System.Windows.Forms.Label()
        Me.main_pic_close = New System.Windows.Forms.PictureBox()
        Me.main_lbl_menu = New System.Windows.Forms.Label()
        Me.main_pn_user = New System.Windows.Forms.Panel()
        Me.main_pic_user = New System.Windows.Forms.PictureBox()
        Me.main_lbl_usernombre = New System.Windows.Forms.Label()
        Me.main_lbl_welcome = New System.Windows.Forms.Label()
        Me.main_lbl_usernombrev = New System.Windows.Forms.Label()
        Me.main_lbl_userrut = New System.Windows.Forms.Label()
        Me.main_lbl_userrutv = New System.Windows.Forms.Label()
        CType(Me.main_pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.main_pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.main_pn_user.SuspendLayout()
        CType(Me.main_pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_pic_logo
        '
        Me.main_pic_logo.Location = New System.Drawing.Point(37, 12)
        Me.main_pic_logo.Name = "main_pic_logo"
        Me.main_pic_logo.Size = New System.Drawing.Size(139, 115)
        Me.main_pic_logo.TabIndex = 0
        Me.main_pic_logo.TabStop = False
        '
        'main_pn_loader
        '
        Me.main_pn_loader.Location = New System.Drawing.Point(197, 35)
        Me.main_pn_loader.Name = "main_pn_loader"
        Me.main_pn_loader.Size = New System.Drawing.Size(815, 577)
        Me.main_pn_loader.TabIndex = 1
        '
        'main_menu
        '
        Me.main_menu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.main_menu.Location = New System.Drawing.Point(25, 181)
        Me.main_menu.Name = "main_menu"
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "menu_item_home"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Text = "DASHBOARD"
        TreeNode2.ImageIndex = 3
        TreeNode2.Name = "menu_item_mascotas"
        TreeNode2.SelectedImageIndex = 3
        TreeNode2.Text = "MASCOTAS"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "menu_item_adoptantes"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "ADOPTANTES"
        TreeNode4.ImageIndex = 1
        TreeNode4.Name = "menu_item_adopciones"
        TreeNode4.SelectedImageIndex = 1
        TreeNode4.Text = "ADOPCIONES"
        Me.main_menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Me.main_menu.Size = New System.Drawing.Size(160, 107)
        Me.main_menu.TabIndex = 2
        '
        'main_il_menu
        '
        Me.main_il_menu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.main_il_menu.ImageSize = New System.Drawing.Size(16, 16)
        Me.main_il_menu.TransparentColor = System.Drawing.Color.Transparent
        '
        'main_lbl_title
        '
        Me.main_lbl_title.AutoSize = True
        Me.main_lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_lbl_title.Location = New System.Drawing.Point(416, 6)
        Me.main_lbl_title.Name = "main_lbl_title"
        Me.main_lbl_title.Size = New System.Drawing.Size(405, 24)
        Me.main_lbl_title.TabIndex = 3
        Me.main_lbl_title.Text = "GESTOR ADOPCION DE MASCOTAS (G.A.M)"
        '
        'main_pic_close
        '
        Me.main_pic_close.Location = New System.Drawing.Point(987, 2)
        Me.main_pic_close.Name = "main_pic_close"
        Me.main_pic_close.Size = New System.Drawing.Size(32, 32)
        Me.main_pic_close.TabIndex = 4
        Me.main_pic_close.TabStop = False
        '
        'main_lbl_menu
        '
        Me.main_lbl_menu.AutoSize = True
        Me.main_lbl_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_lbl_menu.Location = New System.Drawing.Point(34, 142)
        Me.main_lbl_menu.Name = "main_lbl_menu"
        Me.main_lbl_menu.Size = New System.Drawing.Size(56, 20)
        Me.main_lbl_menu.TabIndex = 5
        Me.main_lbl_menu.Text = "MENU"
        '
        'main_pn_user
        '
        Me.main_pn_user.Controls.Add(Me.main_lbl_userrutv)
        Me.main_pn_user.Controls.Add(Me.main_lbl_userrut)
        Me.main_pn_user.Controls.Add(Me.main_lbl_usernombrev)
        Me.main_pn_user.Controls.Add(Me.main_lbl_usernombre)
        Me.main_pn_user.Controls.Add(Me.main_pic_user)
        Me.main_pn_user.Location = New System.Drawing.Point(14, 337)
        Me.main_pn_user.Name = "main_pn_user"
        Me.main_pn_user.Size = New System.Drawing.Size(171, 220)
        Me.main_pn_user.TabIndex = 6
        '
        'main_pic_user
        '
        Me.main_pic_user.Location = New System.Drawing.Point(33, 12)
        Me.main_pic_user.Name = "main_pic_user"
        Me.main_pic_user.Size = New System.Drawing.Size(108, 103)
        Me.main_pic_user.TabIndex = 0
        Me.main_pic_user.TabStop = False
        '
        'main_lbl_usernombre
        '
        Me.main_lbl_usernombre.AutoSize = True
        Me.main_lbl_usernombre.Location = New System.Drawing.Point(8, 123)
        Me.main_lbl_usernombre.Name = "main_lbl_usernombre"
        Me.main_lbl_usernombre.Size = New System.Drawing.Size(54, 13)
        Me.main_lbl_usernombre.TabIndex = 1
        Me.main_lbl_usernombre.Text = "NOMBRE"
        '
        'main_lbl_welcome
        '
        Me.main_lbl_welcome.AutoSize = True
        Me.main_lbl_welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_lbl_welcome.Location = New System.Drawing.Point(34, 314)
        Me.main_lbl_welcome.Name = "main_lbl_welcome"
        Me.main_lbl_welcome.Size = New System.Drawing.Size(109, 20)
        Me.main_lbl_welcome.TabIndex = 7
        Me.main_lbl_welcome.Text = "BIENVENIDO"
        '
        'main_lbl_usernombrev
        '
        Me.main_lbl_usernombrev.AutoSize = True
        Me.main_lbl_usernombrev.Location = New System.Drawing.Point(8, 136)
        Me.main_lbl_usernombrev.Name = "main_lbl_usernombrev"
        Me.main_lbl_usernombrev.Size = New System.Drawing.Size(39, 13)
        Me.main_lbl_usernombrev.TabIndex = 2
        Me.main_lbl_usernombrev.Text = "Label1"
        '
        'main_lbl_userrut
        '
        Me.main_lbl_userrut.AutoSize = True
        Me.main_lbl_userrut.Location = New System.Drawing.Point(8, 149)
        Me.main_lbl_userrut.Name = "main_lbl_userrut"
        Me.main_lbl_userrut.Size = New System.Drawing.Size(30, 13)
        Me.main_lbl_userrut.TabIndex = 3
        Me.main_lbl_userrut.Text = "RUT"
        '
        'main_lbl_userrutv
        '
        Me.main_lbl_userrutv.AutoSize = True
        Me.main_lbl_userrutv.Location = New System.Drawing.Point(8, 162)
        Me.main_lbl_userrutv.Name = "main_lbl_userrutv"
        Me.main_lbl_userrutv.Size = New System.Drawing.Size(39, 13)
        Me.main_lbl_userrutv.TabIndex = 4
        Me.main_lbl_userrutv.Text = "Label1"
        '
        'main_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.main_lbl_welcome)
        Me.Controls.Add(Me.main_pn_user)
        Me.Controls.Add(Me.main_lbl_menu)
        Me.Controls.Add(Me.main_pic_close)
        Me.Controls.Add(Me.main_lbl_title)
        Me.Controls.Add(Me.main_menu)
        Me.Controls.Add(Me.main_pn_loader)
        Me.Controls.Add(Me.main_pic_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_dashboard"
        CType(Me.main_pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.main_pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.main_pn_user.ResumeLayout(False)
        Me.main_pn_user.PerformLayout()
        CType(Me.main_pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main_pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents main_pn_loader As System.Windows.Forms.Panel
    Friend WithEvents main_menu As System.Windows.Forms.TreeView
    Friend WithEvents main_il_menu As System.Windows.Forms.ImageList
    Friend WithEvents main_lbl_title As System.Windows.Forms.Label
    Friend WithEvents main_pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents main_lbl_menu As System.Windows.Forms.Label
    Friend WithEvents main_pn_user As System.Windows.Forms.Panel
    Friend WithEvents main_pic_user As System.Windows.Forms.PictureBox
    Friend WithEvents main_lbl_usernombre As System.Windows.Forms.Label
    Friend WithEvents main_lbl_welcome As System.Windows.Forms.Label
    Friend WithEvents main_lbl_usernombrev As System.Windows.Forms.Label
    Friend WithEvents main_lbl_userrutv As System.Windows.Forms.Label
    Friend WithEvents main_lbl_userrut As System.Windows.Forms.Label
End Class
