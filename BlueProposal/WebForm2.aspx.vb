
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GenerateThumbnail(sender As Object, e As EventArgs)
        Dim path As String = Server.MapPath("~/Jellyfish.jpg")
        Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
        Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(100, 100, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
            Using memoryStream As New MemoryStream()
                thumbnail.Save(memoryStream, ImageFormat.Png)
                Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
                memoryStream.Position = 0
                memoryStream.Read(bytes, 0, CInt(bytes.Length))
                Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                Image2.ImageUrl = "data:image/png;base64," & base64String
                Image2.Visible = True
            End Using
        End Using
    End Sub

    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function

End Class