<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="BlueProposal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="labelMessage" runat="server" Text="Browse Image:" ForeColor="navy" Width="220"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Upload" runat="server" Text="Upload" OnClick="Upload_Click" />
    </div>

    <div>
        <asp:Label ID="label1" runat="server" Text="Normal Image (Full size): " ForeColor="navy" Width="220"></asp:Label>
        <asp:Image ID="NormalImage" runat="server" />
    </div>

    <div>
        <asp:Label ID="label2" runat="server" Text="Thumbnail Small Image (50x50)px: " ForeColor="navy" Width="220"></asp:Label>
        <asp:Image ID="ThumbnailImageS" runat="server" />
    </div>

    <div>
        <asp:Label ID="label3" runat="server" Text="Thumbnail Large Image (100x100)px: "
ForeColor="navy" Width="220"></asp:Label>
        <asp:Image ID="ThumbnailImageM" runat="server" />
    </div>
    </form>
</body>
</html>
