Imports Npgsql
Imports System.Security.Cryptography
Module PGSQL_Query
#Region "INGRESO DE USUARIO"
    Public Function PGSQL_EXECUTELOGIN(ByVal UserTXT As TextBox, ByVal PassTXT As TextBox) As Boolean
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                             ";Port=" & ConfigParametros("bdport") & _
                                             ";Username=" & ConfigParametros("bduser") & _
                                             ";Password=" & ConfigParametros("bdpass") & _
                                             ";Database=" & ConfigParametros("bdname"))
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, username, password, nombres, apellido_p, apellido_m, telefono, celular, direccion, idcomuna, idregion, avatar, rut, fnacimiento FROM usuarios WHERE username=@USUARIO LIMIT 1"
            PGSQLCommand.Parameters.AddWithValue("@USUARIO", Trim(UserTXT.Text))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                ' # SI NO EXISTE EL USUARIO.
                PGSQLConex.Close()
                UserTXT.BackColor = ColorTranslator.FromHtml("#f22c1d")
                UserTXT.ForeColor = ColorTranslator.FromHtml("#ffffff")
                UserTXT.Focus()
                Return False
            End If
            rd.Read()
            If rd(2).ToString <> Md5Encrypt(Trim(PassTXT.Text)) Then
                ' # SI LA CLAVE ES INCORRECTA.
                PGSQLConex.Close()
                PassTXT.BackColor = ColorTranslator.FromHtml("#f22c1d")
                PassTXT.ForeColor = ColorTranslator.FromHtml("#ffffff")
                PassTXT.Focus()
                Return False
            End If
            UserActive.Add("id", rd(0).ToString)
            UserActive.Add("usuario", rd(1).ToString)
            UserActive.Add("password", rd(2).ToString)
            UserActive.Add("nombres", rd(3).ToString)
            UserActive.Add("apellido_p", rd(4).ToString)
            UserActive.Add("apellido_m", rd(5).ToString)
            UserActive.Add("telefono", rd(6).ToString)
            UserActive.Add("celular", rd(7).ToString)
            UserActive.Add("direccion", rd(8).ToString)
            UserActive.Add("comuna", rd(9).ToString)
            UserActive.Add("region", rd(10).ToString)
            UserActive.Add("avatar", rd(11).ToString)
            UserActive.Add("rut", rd(12).ToString)
            UserActive.Add("fnac", rd(13).ToString)
            PGSQLConex.Close()
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                           vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                           " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
    Function Md5Encrypt(ByVal Password As String) As String
        Dim PassEncrypt As String = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer
        Try
            bytValue = System.Text.Encoding.UTF8.GetBytes(Password)
            bytHash = md5.ComputeHash(bytValue)
            md5.Clear()
            For i = 0 To bytHash.Length - 1
                PassEncrypt &= bytHash(i).ToString("x").PadLeft(2, "0")
            Next
            Return PassEncrypt
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error con la rutina de Criptografía de la aplicación, muy probablemente no pueda iniciar " & _
                            "sección en la aplicación contacte al equipo de desarrollo.", Application.ProductName, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "error"
        End Try
    End Function
#End Region
#Region "MASCOTAS"
    Public Sub PGSQL_LISTMASCOTAS(ByVal DGV As DataGridView)
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                              ";Port=" & ConfigParametros("bdport") & _
                                              ";Username=" & ConfigParametros("bduser") & _
                                              ";Password=" & ConfigParametros("bdpass") & _
                                              ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombre, tipo, idclase, raza, fnac, fadopcion, foto FROM vista_listamascotas"
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                PGSQLConex.Close()
                Exit Sub
            End If
            PGSQLDataTable.Load(rd)
            DGV.DataSource = PGSQLDataTable
            PGSQLConex.Close()
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                           vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                           " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub PGSQL_LOADTYPESPET(ByVal CMB As ComboBox)
        ' # CARGAMOS LA LISTA DE CLASES DE MASCOTAS A UN COMBOBOX.
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                             ";Port=" & ConfigParametros("bdport") & _
                                             ";Username=" & ConfigParametros("bduser") & _
                                             ";Password=" & ConfigParametros("bdpass") & _
                                             ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, nombre FROM tiposmascotas"
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                PGSQLConex.Close()
                Exit Sub
            End If
            PGSQLDataTable.Load(rd)
            CMB.DataSource = PGSQLDataTable
            CMB.ValueMember = "id"
            CMB.DisplayMember = "nombre"
            PGSQLConex.Close()
            Exit Sub
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                          vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                          " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Function PGSQL_VACUNASPETLOAD(ByVal idMascota As Integer) As Dictionary(Of Integer, String)
        Dim ReturnArray As New Dictionary(Of Integer, String)
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                            ";Port=" & ConfigParametros("bdport") & _
                                            ";Username=" & ConfigParametros("bduser") & _
                                            ";Password=" & ConfigParametros("bdpass") & _
                                            ";Database=" & ConfigParametros("bdname"))
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT idvacuna, idpet FROM vacunatorio WHERE idpet=@idmascota"
            PGSQLCommand.Parameters.AddWithValue("@idmascota", Integer.Parse(idMascota))
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                PGSQLConex.Close()
                ReturnArray.Add(0, "")
                Return ReturnArray
            End If
            While rd.Read
                ReturnArray.Add(Integer.Parse(rd(0).ToString), rd(1).ToString)
            End While
            PGSQLConex.Close()
            Return ReturnArray
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                          vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & Err.ToString, Application.ProductName & _
                          " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ReturnArray.Add(0, "error")
            Return ReturnArray
        End Try
    End Function
#End Region
#Region "ADOPTANTES"
    Public Sub PGSQL_LISTADOPTANTES(ByVal DGV As DataGridView)
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                              ";Port=" & ConfigParametros("bdport") & _
                                              ";Username=" & ConfigParametros("bduser") & _
                                              ";Password=" & ConfigParametros("bdpass") & _
                                              ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLDataTable As DataTable = New DataTable
            Dim rd As NpgsqlDataReader
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "SELECT id, rut, concat(nombres, ' ', apellido_p, ' ', apellido_m) as nombre, telefono, celular, direccion, avatar, fnacimiento, nombres, apellido_p, apellido_m FROM clientes"
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                PGSQLConex.Close()
                Exit Sub
            End If
            PGSQLDataTable.Load(rd)
            DGV.DataSource = PGSQLDataTable
            PGSQLConex.Close()
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                           vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                           " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
#End Region
End Module
