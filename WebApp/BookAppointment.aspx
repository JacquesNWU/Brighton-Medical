<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookAppointment.aspx.cs" Inherits="vanHeerden_35317906_June_Exam_Web_App.BookAppointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="font-family: 'century gothic'; font-size: 14px; color: #FFFFFF; background-color: #4C4D4F;">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 139px;
        }
        .auto-style3 {
            height: 139px;
            text-align: center;
            width: 773px;
        }
        .auto-style4 {
            width: 773px;
        }
        .auto-style5 {
            width: 773px;
            text-align: center;
        }
        .auto-style6 {
            width: 773px;
            text-align: center;
            height: 57px;
        }
        .auto-style7 {
            height: 57px;
        }
        .auto-style8 {
            height: 57px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Size="20pt" Text="Book Appointment"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Size="14pt" Text="Time"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderStyle="None" CellPadding="10" CellSpacing="1" Height="63px" RepeatDirection="Horizontal" TabIndex="1" TextAlign="Left" ViewStateMode="Enabled" Width="270px">
                        <asp:ListItem>8:00</asp:ListItem>
                        <asp:ListItem>8:30</asp:ListItem>
                        <asp:ListItem>9:00</asp:ListItem>
                        <asp:ListItem>9:30</asp:ListItem>
                        <asp:ListItem>10:00</asp:ListItem>
                        <asp:ListItem>11:00</asp:ListItem>
                        <asp:ListItem>11:30</asp:ListItem>
                        <asp:ListItem>12:00</asp:ListItem>
                        <asp:ListItem>13:30</asp:ListItem>
                        <asp:ListItem>14:00</asp:ListItem>
                        <asp:ListItem>14:30</asp:ListItem>
                        <asp:ListItem>15:00</asp:ListItem>
                        <asp:ListItem>15:30</asp:ListItem>
                        <asp:ListItem>16:00</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <div class="auto-style1">
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Size="14pt" Text="Date"  ></asp:Label>
                        <br />
                    <br />
                    <asp:Calendar ID="Calendar1" runat="server" Font-Names="century gothic" Font-Size="14pt" ForeColor="White" ShowGridLines="True" Width="776px">
                        <SelectorStyle BorderStyle="Dotted" Font-Names="Century Gothic" Font-Size="14pt" />
                    </asp:Calendar>
                    </div>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Size="14pt" Text="Time"></asp:Label>
                    <br />
                    <br />
                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Century Gothic" Font-Size="12pt" Height="36px" Width="304px">
                        <asp:ListItem>Surgical appointment</asp:ListItem>
                        <asp:ListItem>Laboratory / medical result analysis</asp:ListItem>
                        <asp:ListItem>Routine Check-up </asp:ListItem>
                        <asp:ListItem>Urgent Medical Check-up</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <br />
                    <asp:Button ID="btnBook" runat="server" BackColor="#48AEC6" BorderStyle="None" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="35px" Text="Book" Width="205px" OnClick="btnBook_Click" />
                    <br />
                    <br />
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8">
            <asp:LinkButton ID="Dashboard" runat="server" BorderColor="#48AEC6" BorderStyle="Outset" Font-Bold="False" Font-Names="century gothic" Font-Size="14pt" Font-Strikeout="False" Font-Underline="True" ForeColor="#48AEC6" OnClick="Dashboard_Click">Back to Dashboard</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
