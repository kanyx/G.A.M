Imports System.IO
Module MiscFUNCTIONS
    Public Function MISC_COPYIMAGEPET(ByVal Imagen As String, ByVal Control As PictureBox) As String
        Try
            ' # ConfigParametros("path_avatar") -> RUTA DONDE SE ALMACENARAN LAS IMAGENES DE LAS MASCOTAS
            Dim NameFile As String = ""
            Dim NuevaImagen As Bitmap
            If File.Exists(Imagen) = False Then
                Return ""
            End If
            Dim infoFile As New IO.FileInfo(Imagen)
            NameFile = Date.Now.Date.Year.ToString & Date.Now.Day.ToString & Date.Now.Date.Month.ToString & Date.Now.Hour.ToString & _
                Date.Now.Minute.ToString & Date.Now.Second.ToString & Date.Now.Millisecond.ToString & UserActive("id").ToString & _
                "_" & UserActive("usuario").ToString & infoFile.Extension
            NuevaImagen = MISC_SCALEIMAGE(Image.FromFile(Imagen), 188, 207)
            Control.Image = NuevaImagen
            If infoFile.Extension.ToLower = ".jpg" Or infoFile.Extension.ToLower = ".jpeg" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf infoFile.Extension.ToLower = ".png" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Png)
            ElseIf infoFile.Extension.ToLower = ".bmp" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Bmp)
            ElseIf infoFile.Extension.ToLower = ".tif" Or infoFile.Extension.ToLower = ".tiff" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Tiff)
            End If
            Return NameFile
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                          vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                          " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return ""
        End Try
    End Function
    Public Function MISC_COPYIMAGECLIENTE(ByVal Imagen As String, ByVal Control As PictureBox) As String
        Try
            ' # ConfigParametros("path_avatar") -> RUTA DONDE SE ALMACENARAN LAS IMAGENES DE LAS MASCOTAS
            Dim NameFile As String = ""
            Dim NuevaImagen As Bitmap
            If File.Exists(Imagen) = False Then
                Return ""
            End If
            Dim infoFile As New IO.FileInfo(Imagen)
            NameFile = Date.Now.Date.Year.ToString & Date.Now.Day.ToString & Date.Now.Date.Month.ToString & Date.Now.Hour.ToString & _
                Date.Now.Minute.ToString & Date.Now.Second.ToString & Date.Now.Millisecond.ToString & UserActive("id").ToString & _
                "_" & UserActive("usuario").ToString & infoFile.Extension
            NuevaImagen = MISC_SCALEIMAGE(Image.FromFile(Imagen), 188, 207)
            Control.Image = NuevaImagen
            If infoFile.Extension.ToLower = ".jpg" Or infoFile.Extension.ToLower = ".jpeg" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf infoFile.Extension.ToLower = ".png" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Png)
            ElseIf infoFile.Extension.ToLower = ".bmp" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Bmp)
            ElseIf infoFile.Extension.ToLower = ".tif" Or infoFile.Extension.ToLower = ".tiff" Then
                Control.Image.Save(ConfigParametros("path_avatar") & NameFile, Drawing.Imaging.ImageFormat.Tiff)
            End If
            Return NameFile
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                          vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                          " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return ""
        End Try
    End Function
    Public Function MISC_SCALEIMAGE(ByVal OldImage As Image, ByVal TargetHeight As Integer, ByVal TargetWidth As Integer) As System.Drawing.Image
        Dim NewHeight As Integer = TargetHeight
        Dim NewWidth As Integer = NewHeight / OldImage.Height * OldImage.Width
        If NewWidth > TargetWidth Then
            NewWidth = TargetWidth
            NewHeight = NewWidth / OldImage.Width * OldImage.Height
        End If
        Return New Bitmap(OldImage, NewWidth, NewHeight)
    End Function
    Public Function MISC_DELETEFILE(ByVal FileFULL As String) As Boolean
        Try
            If File.Exists(FileFULL) = False Then
                Return True
            End If
            My.Computer.FileSystem.DeleteFile(FileFULL, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
            Return True
        Catch err As Exception
            MessageBox.Show("Ocurrió un error al realizar la operación solicitada, el detalle del error se muestra a continuación: " & _
                          vbNewLine & vbNewLine & "[DETALLE DEL ERROR]" & vbNewLine & vbNewLine & err.ToString, Application.ProductName & _
                          " - " & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function
End Module
