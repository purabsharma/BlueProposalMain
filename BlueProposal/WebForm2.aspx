<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="BlueProposal.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <asp:Image ID="Image1" runat="server" ImageUrl = "~/Jellyfish.jpg" Height = "400px" Width = "400px"/>
<br />
<asp:Button ID="btnGenerate" OnClick = "GenerateThumbnail" runat="server" Text="Generate Thumbnail" />
<hr />
<asp:Image ID="Image2" runat="server" Visible = "false"/>
    </form>
</body>
</html>
