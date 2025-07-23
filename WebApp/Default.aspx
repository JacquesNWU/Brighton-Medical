<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="vanHeerden_35317906_June_Exam_Web_App.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #4C4D4F; color: #FFFFFF; font-family: 'Century Gothic'; font-size: 14px">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            height: 150px;
        }
        .auto-style3 {
            margin-left: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div class="auto-style1">
            <asp:Label ID="lblTitle" runat="server" Text="Brighton Medical Client Login" BorderStyle="None" Font-Size="25pt"></asp:Label>
        </div>
        <table class="auto-style2">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Size="14pt" Text="Username"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username Required" ValidationGroup="Login"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Size="14pt" Text="Password"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Required" ValidationGroup="Login"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <br />
                    <asp:Button ID="btnLogin" runat="server" BackColor="#48AEC6" BorderStyle="None" CssClass="auto-style3" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="35px" Text="Login" Width="122px" OnClick="btnLogin_Click" ValidationGroup="Login" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
            <br />
            <br />
            <asp:Label ID="lblOut" runat="server" Font-Size="25pt"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
