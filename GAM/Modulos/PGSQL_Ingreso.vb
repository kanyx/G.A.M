Imports Npgsql
Module PGSQL_Ingreso
#Region "AGREGAR MASCOTAS"
    Public Function PGSQL_ADDPET(ByVal Nombre As String, ByVal FechaNac As Date, ByVal idClase As String, ByVal Vacuna1 As Integer, _
                                 ByVal Vacuna2 As Integer, ByVal Vacuna3 As Integer, ByVal VacunaAntirabica As Integer,
                                 ByVal Foto As String) As Boolean
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                            ";Port=" & ConfigParametros("bdport") & _
                                            ";Username=" & ConfigParametros("bduser") & _
                                            ";Password=" & ConfigParametros("bdpass") & _
                                            ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLCommand As NpgsqlCommand
            Dim idMascota As Integer = 0
            Dim rd As NpgsqlDataReader
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "INSERT INTO mascotas (nombre, idclase, idraza, fnac, foto) VALUES (@nombre, @tipo, @raza, @fnac, @foto) returning id"
            PGSQLCommand.Parameters.AddWithValue("@nombre", Nombre.ToLower)
            PGSQLCommand.Parameters.AddWithValue("@tipo", Integer.Parse(idClase))
            PGSQLCommand.Parameters.AddWithValue("@raza", 1)
            PGSQLCommand.Parameters.AddWithValue("@fnac", Date.Parse(FechaNac))
            PGSQLCommand.Parameters.AddWithValue("@foto", Foto)
            rd = PGSQLCommand.ExecuteReader
            If rd.HasRows = False Then
                PGSQLConex.Close()
                Return False
            End If
            While rd.Read
                idMascota = Integer.Parse(rd(0))
            End While
            If idMascota = 0 Then
                PGSQLConex.Close()
                Return False
            End If
            If Vacuna1 = 0 And Vacuna2 = 0 And Vacuna3 = 0 And VacunaAntirabica = 0 Then
                PGSQLConex.Close()
                Return False
            End If
            PGSQLConex.Close()
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            If Vacuna1 <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idmascota, @idvacuna1, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna1", Integer.Parse(Vacuna1))
            End If
            If Vacuna2 <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idmascota, @idvacuna2, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna2", Integer.Parse(Vacuna2))
            End If
            If Vacuna3 <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idmascota, @idvacuna3, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna3", Integer.Parse(Vacuna3))
            End If
            If VacunaAntirabica <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idmascota, @idvacunarabica, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacunarabica", Integer.Parse(VacunaAntirabica))
            End If
            PGSQLCommand.Parameters.AddWithValue("@idmascota", Integer.Parse(idMascota))
            PGSQLCommand.Parameters.AddWithValue("@fechavacuna", Date.Now.Date)
            PGSQLCommand.ExecuteNonQuery()
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                         vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                         " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
    Public Function PGSQL_UPDATEPET(ByVal idMascota As Integer, ByVal Nombre As String, ByVal FechaNac As Date, ByVal idClase As String, ByVal Vacuna1 As Integer, _
                                 ByVal Vacuna2 As Integer, ByVal Vacuna3 As Integer, ByVal VacunaAntirabica As Integer,
                                 ByVal Foto As String, ByVal VacunasActivas As Dictionary(Of Integer, String)) As Boolean
        ' # ACTUALIZAMOS LA INFORMACION DE LA MASCOTA EN CASO DE REALIZAR ALGUN CAMBIO.
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                            ";Port=" & ConfigParametros("bdport") & _
                                            ";Username=" & ConfigParametros("bduser") & _
                                            ";Password=" & ConfigParametros("bdpass") & _
                                            ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "UPDATE mascotas SET nombre=@nombre, idclase=@tipo, fnac=@fnac, foto=@foto WHERE id=@idpet; "
            If Vacuna1 = 0 And VacunasActivas.ContainsKey(1) Then
                PGSQLCommand.CommandText += "DELETE FROM vacunatorio WHERE idpet=@idpet AND idvacuna=@vacuna1; "
                PGSQLCommand.Parameters.AddWithValue("@vacuna1", Integer.Parse(1))
            ElseIf VacunasActivas.ContainsKey(1) = False And Vacuna1 <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idpet, @idvacuna1, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna1", Integer.Parse(1))
                PGSQLCommand.Parameters.AddWithValue("@fechavacuna", Date.Now.Date)
            End If
            If Vacuna2 = 0 And VacunasActivas.ContainsKey(2) Then
                PGSQLCommand.CommandText += "DELETE FROM vacunatorio WHERE idpet=@idpet AND idvacuna=@vacuna2; "
                PGSQLCommand.Parameters.AddWithValue("@vacuna2", Integer.Parse(2))
            ElseIf VacunasActivas.ContainsKey(2) = False And Vacuna2 <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idpet, @idvacuna2, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna2", Integer.Parse(2))
                PGSQLCommand.Parameters.AddWithValue("@fechavacuna", Date.Now.Date)
            End If
            If Vacuna3 = 0 And VacunasActivas.ContainsKey(3) Then
                PGSQLCommand.CommandText += "DELETE FROM vacunatorio WHERE idpet=@idpet AND idvacuna=@vacuna3; "
                PGSQLCommand.Parameters.AddWithValue("@vacuna3", Integer.Parse(3))
            ElseIf VacunasActivas.ContainsKey(3) = False And Vacuna3 <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idpet, @idvacuna3, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna3", Integer.Parse(3))
                PGSQLCommand.Parameters.AddWithValue("@fechavacuna", Date.Now.Date)
            End If
            If VacunaAntirabica = 0 And VacunasActivas.ContainsKey(4) Then
                PGSQLCommand.CommandText += "DELETE FROM vacunatorio WHERE idpet=@idpet AND idvacuna=@vacuna4; "
                PGSQLCommand.Parameters.AddWithValue("@vacuna4", Integer.Parse(4))
            ElseIf VacunasActivas.ContainsKey(4) = False And VacunaAntirabica <> 0 Then
                PGSQLCommand.CommandText += "INSERT INTO vacunatorio (idpet, idvacuna, fecha) VALUES (@idpet, @idvacuna4, @fechavacuna); "
                PGSQLCommand.Parameters.AddWithValue("@idvacuna4", Integer.Parse(4))
                PGSQLCommand.Parameters.AddWithValue("@fechavacuna", Date.Now.Date)
            End If
            PGSQLCommand.Parameters.AddWithValue("@idpet", Integer.Parse(idMascota))
            PGSQLCommand.Parameters.AddWithValue("@nombre", Nombre.ToString.ToLower)
            PGSQLCommand.Parameters.AddWithValue("@tipo", Integer.Parse(idClase))
            PGSQLCommand.Parameters.AddWithValue("@fnac", Date.Parse(FechaNac))
            PGSQLCommand.Parameters.AddWithValue("@foto", Foto.ToString)
            PGSQLCommand.ExecuteNonQuery()
            PGSQLConex.Close()
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                        vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                        " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
#End Region
#Region "AGREGAR ADOPTANTES"
    Public Function PGSQL_ADDADOPTANTE(ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal Rut As String, _
                                       ByVal Fnac As Date, ByVal Telefono As String, ByVal Celular As String, ByVal Direccion As String, ByVal Foto As String) As Boolean
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                           ";Port=" & ConfigParametros("bdport") & _
                                           ";Username=" & ConfigParametros("bduser") & _
                                           ";Password=" & ConfigParametros("bdpass") & _
                                           ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "INSERT INTO clientes (nombres, apellido_p, apellido_m, telefono, celular, direccion, avatar, rut, fnacimiento) VALUES (@nombres, @apellidop, @apellidom, " & _
                "@telefono, @celular, @direccion, @foto, @rut, @fnac)"
            PGSQLCommand.Parameters.AddWithValue("@nombres", Nombre)
            PGSQLCommand.Parameters.AddWithValue("@apellidop", ApellidoP)
            PGSQLCommand.Parameters.AddWithValue("@apellidom", ApellidoM)
            PGSQLCommand.Parameters.AddWithValue("@telefono", Telefono)
            PGSQLCommand.Parameters.AddWithValue("@celular", Celular)
            PGSQLCommand.Parameters.AddWithValue("@direccion", Direccion)
            PGSQLCommand.Parameters.AddWithValue("@foto", Foto)
            PGSQLCommand.Parameters.AddWithValue("@rut", Rut)
            PGSQLCommand.Parameters.AddWithValue("@fnac", Fnac)
            PGSQLCommand.ExecuteNonQuery()
            PGSQLConex.Close()
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                        vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                        " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
    Public Function PGSQL_UPDATEADOPTANTE(ByVal idAdoptante As Integer, ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal Rut As String, _
                                       ByVal Fnac As Date, ByVal Telefono As String, ByVal Celular As String, ByVal Direccion As String, ByVal Foto As String) As Boolean
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                           ";Port=" & ConfigParametros("bdport") & _
                                           ";Username=" & ConfigParametros("bduser") & _
                                           ";Password=" & ConfigParametros("bdpass") & _
                                           ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "UPDATE clientes SET nombres=@nombres, apellido_p=@apellidop, apellido_m=@apellidom, " & _
                "telefono=@telefono, celular=@celular, direccion=@direccion, avatar=@foto, rut=@rut, fnacimiento=@fnac WHERE id=@iduser"
            PGSQLCommand.Parameters.AddWithValue("@iduser", idAdoptante)
            PGSQLCommand.Parameters.AddWithValue("@nombres", Nombre)
            PGSQLCommand.Parameters.AddWithValue("@apellidop", ApellidoP)
            PGSQLCommand.Parameters.AddWithValue("@apellidom", ApellidoM)
            PGSQLCommand.Parameters.AddWithValue("@telefono", Telefono)
            PGSQLCommand.Parameters.AddWithValue("@celular", Celular)
            PGSQLCommand.Parameters.AddWithValue("@direccion", Direccion)
            PGSQLCommand.Parameters.AddWithValue("@foto", Foto)
            PGSQLCommand.Parameters.AddWithValue("@rut", Rut)
            PGSQLCommand.Parameters.AddWithValue("@fnac", Fnac)
            PGSQLCommand.ExecuteNonQuery()
            PGSQLConex.Close()
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                        vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                        " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
#End Region
#Region "ADOPCIONES"
    Public Function PGSQL_ADDADOPCION(ByVal idMascota As Integer, ByVal idAdoptante As Integer) As Boolean
        Try
            Dim PGSQLConex As New NpgsqlConnection("Host=" & ConfigParametros("bdserver") & _
                                          ";Port=" & ConfigParametros("bdport") & _
                                          ";Username=" & ConfigParametros("bduser") & _
                                          ";Password=" & ConfigParametros("bdpass") & _
                                          ";Database=" & ConfigParametros("bdname"))
            Dim PGSQLCommand As NpgsqlCommand
            PGSQLConex.Open()
            PGSQLCommand = New NpgsqlCommand
            PGSQLCommand.Connection = PGSQLConex
            PGSQLCommand.CommandType = CommandType.Text
            PGSQLCommand.CommandText = "UPDATE mascotas SET "
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                       vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                       " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
#End Region
End Module