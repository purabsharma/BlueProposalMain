Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        If FileUpload1.HasFile Then
            FileUpload1.SaveAs(MapPath("~/Image/" + FileUpload1.FileName))
            Dim img1 As System.Drawing.Image = System.Drawing.Image.FromFile(MapPath("~/image/") + FileUpload1.FileName)

            Dim bmp1 As System.Drawing.Image = img1.GetThumbnailImage(50, 50, Nothing, IntPtr.Zero)
            bmp1.Save(MapPath("~/thumbnail/S/") + FileUpload1.FileName)
            Dim bmp2 As System.Drawing.Image = img1.GetThumbnailImage(100, 100, Nothing, IntPtr.Zero)
            bmp2.Save(MapPath("~/thumbnail/L/") + FileUpload1.FileName)
            NormalImage.ImageUrl = "~/Image/" + FileUpload1.FileName
            ThumbnailImageS.ImageUrl = "~/thumbnail/S/" + FileUpload1.FileName
            ThumbnailImageM.ImageUrl = "~/thumbnail/L/" + FileUpload1.FileName
        End If
    End Sub
    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    'End Sub

End Class

