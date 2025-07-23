<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateInformation.aspx.cs" Inherits="vanHeerden_35317906_June_Exam_Web_App.UpdateInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #4C4D4F; font-family: 'century Gothic'; color: #FFFFFF; font-size: 14px;">
<head runat="server">
    
    <title>Update Personal Information</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
            width: 665px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            text-align: center;
            width: 217px;
        }
        .auto-style8 {
            text-align: center;
            width: 17px;
        }
        .auto-style9 {
            text-align: right;
            width: 240px;
        }
        .auto-style10 {
            text-align: right;
        }
        .auto-style11 {
            text-align: right;
            width: 241px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblTitle" runat="server" Text="Update Your Personal Information" Font-Size="20pt"></asp:Label>
        </div>
        <table style="width:100%;" border-collapse:"collapse">
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style2">
                    <br />
                    <asp:Label ID="lblName" runat="server" Font-Size="14pt" Text="Name: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Size="14pt" Text="Surname: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Size="14pt" Text="Contact Number: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Size="14pt" Text="Email Address: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Font-Size="14pt" Text="Allergies: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Font-Size="14pt" Text="Emergency Contact: "></asp:Label>
                    <br />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style7">
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Font-Size="14pt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" Font-Size="14pt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None" Font-Size="14pt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox4" runat="server" BorderStyle="None" Font-Size="14pt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server" BorderStyle="None" Font-Size="14pt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox6" runat="server" BorderStyle="None" Font-Size="14pt"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="lblStatus0" runat="server"></asp:Label>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="btnUpdate" runat="server" BackColor="#48AEC6" BorderColor="#48AEC6" BorderStyle="None" CssClass="auto-style6" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="45px" Text="Update" Width="190px" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;" border-collapse:"collapse">
            <tr>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2">
                    <br />
                    <asp:Label ID="lblName0" runat="server" Font-Size="14pt" Text="Old Password:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Font-Size="14pt" Text="New Password: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label8" runat="server" Font-Size="14pt" Text="Confirm New Password: "></asp:Label>
                    <br />
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style7">
                    <br />
                    <asp:TextBox ID="TextBox7" runat="server" BorderStyle="None" Font-Size="14pt" ></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox8" runat="server" BorderStyle="None" Font-Size="14pt" TextMode="Password" ></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox9" runat="server" BorderStyle="None" Font-Size="14pt" TextMode="Password" ></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="btnUpdate0" runat="server" BackColor="#48AEC6" BorderColor="#48AEC6" BorderStyle="None" CssClass="auto-style6" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="45px" Text="Update" Width="190px" OnClick="btnUpdate0_Click" />
                    <br />
                </td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
        </table>
        <p class="auto-style10">
            <asp:LinkButton ID="Dashboard" runat="server" BorderColor="#48AEC6" BorderStyle="Outset" Font-Bold="False" Font-Names="century gothc" Font-Size="14pt" Font-Strikeout="False" Font-Underline="True" ForeColor="#48AEC6" OnClick="Dashboard_Click">Back to Dashboard</asp:LinkButton>
        </p>
    </form>
    </body>
</html>
