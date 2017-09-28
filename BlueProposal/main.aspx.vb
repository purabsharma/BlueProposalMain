Imports System.IO



Public Class main_
    Inherits System.Web.UI.Page
    Dim arraylist1 As ArrayList = New ArrayList
    Dim arraylist2 As ArrayList = New ArrayList
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'test
        End If
    End Sub

    ''' <summary>
    ''' Button2_Click event is used to move single or multiple items from Listbox1 to Listbox2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbltxt.Visible = False
        If (ListBox1.SelectedIndex >= 0) Then
            Dim i As Integer = 0
            Do While (i < ListBox1.Items.Count)
                If ListBox1.Items(i).Selected Then
                    If Not arraylist1.Contains(ListBox1.Items(i)) Then
                        arraylist1.Add(ListBox1.Items(i))
                    End If

                End If

                i = (i + 1)
            Loop
            i = 0
            'Dim i As Integer = 0
            Do While (i < arraylist1.Count)
                If Not ListBox2.Items.Contains(CType(arraylist1(i), ListItem)) Then
                    ListBox2.Items.Add(CType(arraylist1(i), ListItem))
                End If

                ListBox1.Items.Remove(CType(arraylist1(i), ListItem))
                i = (i + 1)
            Loop

            ListBox2.SelectedIndex = -1
        Else
            lbltxt.Visible = True
            lbltxt.Text = "Please select atleast one in Listbox1 to move"
        End If
    End Sub

    ''' <summary>
    ''' Button3_Click event is used to move all items from Listbox1 to Listbox2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lbltxt.Visible = False

        While (ListBox1.Items.Count <> 0)
            Dim i As Integer = 0
            Do While (i < ListBox1.Items.Count)
                ListBox2.Items.Add(ListBox1.Items(i))
                ListBox1.Items.Remove(ListBox1.Items(i))
                i = (i + 1)
            Loop
        End While
    End Sub

    ''' <summary>
    ''' Button4_Click event is used to move single or multiple items from Listbox2 to Listbox1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lbltxt.Visible = False
        If (ListBox2.SelectedIndex >= 0) Then
            Dim i As Integer = 0
            Do While (i < ListBox2.Items.Count)
                If ListBox2.Items(i).Selected Then
                    If Not arraylist2.Contains(ListBox2.Items(i)) Then
                        arraylist2.Add(ListBox2.Items(i))
                    End If

                End If

                i = (i + 1)
            Loop

            i = 0
            Do While (i < arraylist2.Count)
                If Not ListBox1.Items.Contains(CType(arraylist2(i), ListItem)) Then
                    ListBox1.Items.Add(CType(arraylist2(i), ListItem))
                End If

                ListBox2.Items.Remove(CType(arraylist2(i), ListItem))
                i = (i + 1)
            Loop

            ListBox1.SelectedIndex = -1
        Else
            lbltxt.Visible = True
            lbltxt.Text = "Please select atleast one in target list box to move"
        End If
    End Sub


    ''' <summary>
    ''' Button5_Click event is used to move all items form Listbox2 to Listbox1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lbltxt.Visible = False
        While (ListBox2.Items.Count <> 0)
            Dim i As Integer = 0
            Do While (i < ListBox2.Items.Count)
                ListBox1.Items.Add(ListBox2.Items(i))
                ListBox2.Items.Remove(ListBox2.Items(i))
                i = (i + 1)
            Loop
        End While

    End Sub

    Protected Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'If Not IsPostBack Then
        Dim d As String() = Directory.GetFiles(Server.MapPath("/Repository/Ref1"))
        ' Dim f As String()
        Dim sd As String
        'Dim sf As String
        Dim li As Integer = 0
        'lbltxt.Visible = True
        'lbltxt.Text = Server.MapPath("/Repository")
        For Each sd In d
            '    f = Directory.GetFiles(sd)
            'For Each sf In f
            'li = sf.ToString().LastIndexOf("\")
            li = sd.ToString().LastIndexOf("\")
            li = li + 1
            'lbltxt.Text = sf.ToString().Substring(li).ToString().Replace(".htm", "")
            ListBox1.Items.Add(sd.ToString().Substring(li).ToString().Replace(".htm", "").ToString())
        Next
        'Next
        'End If
    End Sub

    Protected Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        tblOptionGrid.Visible = True
        'Dim i As Integer = 1
        'Dim r As New HtmlTableRow
        ''Dim c As New HtmlTableCell
        'Do While (i <= ListBox2.Items.Count)
        '    r.ID = "r" & i
        '    tblOptionGrid.Rows.Add(r)
        '    'r.InnerText = "Added" + i.ToString()
        '    i = (i + 1)
        'Loop


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Debug.Print(chkAmsScopeRef1.Checked.ToString())
        'Debug.Print(chkAmsScopeRef2.Checked.ToString())
        'Debug.Print(chkGovModelRef1.Checked.ToString())
        'Debug.Print(chkGovModelRef2.Checked.ToString())
        'Debug.Print(chkIBmSolRef1.Checked.ToString())
        'Debug.Print(chkIBmSolRef2.Checked.ToString())
        'Debug.Print(chkTranRef1.Checked.ToString())
        'Debug.Print(chkTranRef2.Checked.ToString())
        '' Dim w As Microsoft.Office.Interop.Word
        'Dim wordApp As New Microsoft.Office.Interop.Word.Application
        'Dim doc As Microsoft.Office.Interop.Word.Document
        'wordApp.ScreenUpdating = False
        Dim strRequest As String = Request.QueryString("file")
        '-- if something was passed to the file querystring
        'If strRequest <> "" Then
        '    'get absolute path of the file
        'Dim f As String() = Directory.GetFiles(Server.MapPath("/Repository/Output"))  'Server.MapPath(strRequest)
        'Dim s As String
        'Dim fileToBeDownloaded As String = ""
        'For Each s In f
        '    fileToBeDownloaded = s.ToString()
        'Next
        'Response.WriteFile(fileToBeDownloaded)
        'Response.End()
        Dim path As String = Server.MapPath("/Repository/Output/AutoProposal_Ora_AMS_2309_01.docx")
        Dim f As System.IO.FileInfo = New System.IO.FileInfo(path)
        Response.Clear()
        Response.AddHeader("Content-Disposition", "attachment; filename=" & f.Name)
        Response.AddHeader("Content-Length", f.Length.ToString())
        Response.ContentType = "application/octet-stream"
        Response.WriteFile(f.FullName)
        Response.End()




    End Sub

    'Protected Sub chkAmsScopeRef1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAmsScopeRef1.CheckedChanged
    '    chkAmsScopeRef2.Checked = False
    'End Sub

    'Protected Sub chkAmsScopeRef2_CheckedChanged(sender As Object, e As EventArgs) Handles chkAmsScopeRef2.CheckedChanged
    '    chkAmsScopeRef1.Checked = False
    'End Sub

    'Protected Sub chkGovModelRef1_CheckedChanged(sender As Object, e As EventArgs) Handles chkGovModelRef1.CheckedChanged
    '    chkGovModelRef2.Checked = False
    'End Sub

    'Protected Sub chkGovModelRef2_CheckedChanged(sender As Object, e As EventArgs) Handles chkGovModelRef2.CheckedChanged
    '    chkIBmSolRef1.Checked = False
    'End Sub

    'Protected Sub chkIBmSolRef1_CheckedChanged(sender As Object, e As EventArgs) Handles chkIBmSolRef1.CheckedChanged
    '    chkIBmSolRef2.Checked = False
    'End Sub

    'Protected Sub chkIBmSolRef2_CheckedChanged(sender As Object, e As EventArgs) Handles chkIBmSolRef2.CheckedChanged
    '    chkIBmSolRef1.Checked = False
    'End Sub

    'Protected Sub chkTranRef1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTranRef1.CheckedChanged
    '    chkTranRef2.Checked = False
    'End Sub

    'Protected Sub chkTranRef2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTranRef2.CheckedChanged
    '    chkTranRef1.Checked = False
    'End Sub
End Class