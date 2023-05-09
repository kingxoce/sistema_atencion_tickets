<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularios.aspx.cs" Inherits="Login_SistemadeTickets.formularios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>FORMULARIOS</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 191px;
            height: 181px;
        }
        .auto-style3 {
            width: 204px;
        }
    </style>
</head>
<body style="background-color: #CC99FF">
    <form id="form1" runat="server" style="text-align: center; background-color: #CCCCFF">
        <div style="background-color: #CC99FF">
            <table style="width:100%;">
                <tr>
                    <td colspan="3" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: xx-large; background-color: #CCCCFF; font-weight: bolder; text-align: center;">FORMULARIOS</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="border: thin double #FFFFFF">&nbsp;</td>
                    <td style="border: thin double #FFFFFF">&nbsp;</td>
                    <td style="border: thin double #FFFFFF">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="border: thin double #FFFFFF">&nbsp;</td>
                    <td style="border: thin double #FFFFFF">&nbsp;</td>
                    <td style="border: thin double #FFFFFF">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="border: thin double #FFFFFF">
                        <img alt="Formularios | BizMarketing | Conceptos básicos de Inbound Marketing" class="auto-style2" src="https://bizmarketing.xyz/wp-content/uploads/2019/01/test.png" /></td>
                    <td style="border: thin double #FFFFFF">
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td style="border: thin double #FFFFFF">&nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="auto-style1">
            <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" Height="35px" OnClick="Button1_Click" Text="ATENCION DEL TICKET" Width="190px" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="36px" ImageUrl="~/images/bg-01.jpg" Width="53px" />
            <br />
            <br />
&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" Height="35px" Text="EMPLEADO" Width="190px" OnClick="Button2_Click" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="36px" ImageUrl="~/images/bg-01.jpg" Width="53px" />
            <br />
            <br />
        </div>
        <div class="auto-style1">
            <asp:Button ID="Button4" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" Height="35px" Text="ESCRITORIO VIRTUAL" Width="190px" OnClick="Button4_Click" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="36px" ImageUrl="~/images/bg-01.jpg" Width="53px" />
            <br />
            <br />
&nbsp;
            <asp:Button ID="Button3" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" Height="35px" Text="MOTIVO DE ATENCION" Width="190px" OnClick="Button3_Click" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" Height="36px" ImageUrl="~/images/bg-01.jpg" Width="53px" />
            <br />
            <br />
        </div>
        <div class="auto-style1">
            <asp:Button ID="Button5" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" Height="35px" Text="SOLICITANTE" Width="190px" OnClick="Button5_Click" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton5" runat="server" Height="36px" ImageUrl="~/images/bg-01.jpg" Width="53px" />
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="Button7" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" Height="35px" Text="USUARIO" Width="190px" OnClick="Button7_Click" />
&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="36px" ImageUrl="~/images/bg-01.jpg" Width="53px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
    <div style="background-color: #C9C9FB">
    </div>
</body>
</html>
