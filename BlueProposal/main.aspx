<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="main.aspx.vb" Inherits="BlueProposal.main_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Auto Proposal Tool from Proposal Hub</title>
    <style type="text/css">
        .auto-style1 {
            width: 1497px;
            height: 165px;
        }
    </style>
</head>
<body>
    <script type="text/javascript">
        function dealChecks(){
        var chkStatus1 = document.getElementById("chkAmsScopeRef1");
        var chkStatus2 = document.getElementById("chkAmsScopeRef2");

        if (chkStatus1.checked) {
            // do your implementation for if part
            chkStatus2.checked = false;
            chkStatus1.checked = true;
        }
        else if (chkStatus2.checked) {
            // do your implementation for else if part for checkbox2
            chkStatus1.checked = false;
            chkStatus2.checked = true;
        }
        //else if (chkStatus2.checked && chkStatus2.checked) {
        //    // do your implementation when two chechbox status is checked.
        //}
        //else {
        //    // do your implementation for else part.
        //}
        }
    </script>
    <form id="form1" runat="server">
        <img alt="header" class="auto-style1" src="/img/head.JPG" />
   <table>
       <tr>
           <td><asp:Label ID="lblStream" runat="server" Text="Stream:"></asp:Label></td>
           <td>
               <asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem>Oracle</asp:ListItem>
                   <asp:ListItem>SAP</asp:ListItem>
                   <asp:ListItem>Dynamics</asp:ListItem>
                   <asp:ListItem>SalesForce</asp:ListItem>
               </asp:DropDownList>
           </td>

           <td><asp:Label ID="Label1" runat="server" Text="Category:"></asp:Label></td>
           <td>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>AMS</asp:ListItem>
            <asp:ListItem>Implementation</asp:ListItem>
            <asp:ListItem>Migration</asp:ListItem>
            <asp:ListItem>Upgrade</asp:ListItem>
            <asp:ListItem>Rollout</asp:ListItem>
        </asp:DropDownList>
           </td>
           <td> <asp:Button ID="btnLoad" runat="server" Text="Load options" /></td>
       </tr>
   </table>
        <table><tr>
            <td> <asp:ListBox ID="ListBox1" runat="server" Height="235px" Width="167px"></asp:ListBox></td>
            <td><table><tr>
                <td><asp:Button ID="Button2" runat="server" Text=">" Width="34px" /></td></tr>
                <tr><td><asp:Button ID="Button3" runat="server" Text=">>" /></td></tr>
                <tr><td><asp:Button ID="Button4" runat="server" Text="<" Width="35px" /></td></tr>
                <tr><td><asp:Button ID="Button5" runat="server" Text="<<" /></td>
                </tr></table>
            </td>
            <td><asp:ListBox ID="ListBox2" runat="server" Height="235px" Width="167px"></asp:ListBox>

            </td>
            <td>
                <asp:Label ID="lbltxt" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="#CC3300" Visible="False"></asp:Label></td>
                   
        </tr>
            <tr><td>
                    <asp:Button ID="btnGo" runat="server" Text="Go"/></td> </tr>
        
        </table>
        <table runat="server" id="tblOptionGrid" visible="false">

            <tr><td></td><td>
                <asp:Label ID="Label2" runat="server" Text="Source-1"></asp:Label>
                </td><td>
                    <asp:Label ID="Label3" runat="server" Text="Source-2"></asp:Label>
                </td></tr>
            <tr id="trAMSScope" runat="server"><td id="tdAMSScope" runat="server">AMSScope</td><td>
                <asp:CheckBox ID="chkAmsScopeRef1" runat="server" onchange="chkAmsScopeRef2.checked=false;" Checked="True" />
                <asp:Image ID="imgAmsScopeRef1" runat="server" ImageUrl="~/thumbnail/L/Ref1/AmsScopeRef1.JPG" onclick="window.open('../Repository/Ref1/AMSScope.htm', '_blank', 'WIDTH=1080,HEIGHT=790,scrollbars=yes, menubar=no,resizable=yes,directories=no,location=no');" />
                </td>
               
                <td> <asp:CheckBox ID="chkAmsScopeRef2" runat="server" onchange="chkAmsScopeRef1.checked=false;" Enabled="false" />

                </td></tr> 
            <tr id="trGovernanceModel" runat="server"><td id="tdGovernanceModel" runat="server">GovernanceModel</td>
                <td>
                <asp:CheckBox ID="chkGovModelRef1" runat="server" onchange="chkGovModelRef2.checked=false;"/>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/thumbnail/L/Ref1/GovernanceModel.JPG" onclick="window.open('../Repository/Ref1/GovernanceModel.htm', '_blank', 'WIDTH=1080,HEIGHT=790,scrollbars=yes, menubar=no,resizable=yes,directories=no,location=no');" />
                    
                </td><td>
                    <asp:CheckBox ID="chkGovModelRef2" runat="server" onchange="chkGovModelRef1.checked=false;" />
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/thumbnail/L/Ref2/GovernanceModel_Ref2.JPG" onclick="window.open('../Repository/Ref2/GovernanceModel.htm', '_blank', 'WIDTH=1080,HEIGHT=790,scrollbars=yes, menubar=no,resizable=yes,directories=no,location=no');"  />
                </td></tr>
            <tr id="trIBMsSolutionOverview" runat="server"><td id="tdIBMsSolutionOverview" runat="server">IBMsSolutionOverview</td><td>
                <asp:CheckBox ID="chkIBmSolRef1" runat="server" onchange="chkIBmSolRef2.checked=false;" Checked="True"/>
                <asp:Image ID="Image3" runat="server" ImageUrl="~/thumbnail/L/Ref1/IBMsSolutionOverview.JPG" onclick="window.open('../Repository/Ref1/IBMsSolutionOverview.htm', '_blank', 'WIDTH=1080,HEIGHT=790,scrollbars=yes, menubar=no,resizable=yes,directories=no,location=no');"  />
                </td><td>
                    <asp:CheckBox ID="chkIBmSolRef2" runat="server" onchange="chkIBmSolRef1.checked=false;" Enabled="false" />
                </td></tr>
            <tr id="trTransition" runat="server"><td id="tdTransition" runat="server">Transition</td><td>
                <asp:CheckBox ID="chkTranRef1" runat="server" onchange="chkTranRef2.checked=false;" />
                <asp:Image ID="Image4" runat="server" ImageUrl="~/thumbnail/L/Ref1/Transition.JPG" onclick="window.open('../Repository/Ref1/Transition.htm', '_blank', 'WIDTH=1080,HEIGHT=790,scrollbars=yes, menubar=no,resizable=yes,directories=no,location=no');" />
                </td><td>
                    <asp:CheckBox ID="chkTranRef2" runat="server" onchange="chkTranRef1.checked=false;"/>
                    <asp:Image ID="Image5" runat="server" ImageUrl="~/thumbnail/L/Ref2/Transition_ref2.JPG" onclick="window.open('../Repository/Ref2/Transition.htm', '_blank', 'WIDTH=1080,HEIGHT=790,scrollbars=yes, menubar=no,resizable=yes,directories=no,location=no');"  />
                </td></tr>
            <tr><td><asp:Button ID="Button1" runat="server" Text="Generate Doc" /></td><td></td><td></td></tr>
            
        </table>
     </form>
   
</body>
</html>
