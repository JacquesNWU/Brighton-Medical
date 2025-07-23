<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="vanHeerden_35317906_June_Exam_Web_App.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="color: #FFFFFF; font-family: 'Century Gothic'; font-size: 14px; background-color: #4C4D4F;">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 48px;
        }
        .auto-style3 {
            text-align: center;
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Client Dashboard" Font-Size="20pt"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style2"></td>
                            <td class="auto-style3">
                                <asp:Label ID="lblWelcome" runat="server" Font-Size="14pt"></asp:Label>
                            </td>
                            <td class="auto-style2"></td>
                        </tr>
                        <tr>
                            <td class="auto-style2"></td>
                            <td class="auto-style3">
                                <asp:Label ID="lblView" runat="server" Font-Size="14pt" Text="View your upcoming appointments below"></asp:Label>
                            </td>
                            <td class="auto-style2"></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
                                </asp:GridView>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="btnUpdate" runat="server" BackColor="#48AEC6" BorderStyle="None" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="50px" Text="Update Personal Information" Width="270px" OnClick="btnUpdate_Click" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    <br />
                    <asp:Button ID="btnBook" runat="server" BackColor="#48AEC6" BorderStyle="None" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="50px" Text="Book Appointment" Width="270px" OnClick="btnBook_Click" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
