<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmatender.aspx.cs" Inherits="consumirsistemadetickets.paginas.frmatender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 532px;
        }
        .auto-style3 {
            text-align: center;
            color: #000000;
            height: 120px;
        }
        .auto-style5 {
            width: 100%;
            height: 183px;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style7 {
            color: #FF0000;
        }
        .auto-style8 {
            width: 351px;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            width: 351px;
            color: #663300;
            text-align: center;
        }
        .auto-style12 {
            width: 130px;
        }
        .auto-style13 {
            width: 268px;
        }
        .auto-style14 {
            color: #FFFFFF;
        }
        .auto-style15 {
            width: 351px;
            text-align: center;
        }
    </style>
</head>
<body style="background-color:#CCCCFF"  >
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style5">
                <tr>
                    <td class="auto-style3" colspan="7"><strong style="font-family: Impact, Haettenschweiler, 'Arial Narrow Bold', sans-serif; font-size: xx-large; background-color: #CCCCFF">ATENDER TICKETS</strong></td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td colspan="2" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #666699">Usted está atendiendo el siguiente ticket</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #9999FF">Numero del ticket</td>
                    <td class="auto-style6" style="background-color: #CCCCFF; color: #000000">
                        <asp:Label ID="nticket" runat="server" BackColor="#CCCCFF" ForeColor="Black"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #9999FF">Carné del solicitante</td>
                    <td class="auto-style6" style="background-color: #CCCCFF; color: #000000">
                        <asp:Label ID="carnett" runat="server" BackColor="#CCCCFF" ForeColor="Black"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #9999FF">Motivo del ticket</td>
                    <td class="auto-style6" style="background-color: #CCCCFF; color: #000000">
                        <asp:Label ID="motivott" runat="server" BackColor="#CCCCFF" ForeColor="Black"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #9999FF">Fecha del ticket</td>
                    <td class="auto-style6" style="background-color: #CCCCFF; color: #000000">
                        <asp:Label ID="fechatt" runat="server" BackColor="#CCCCFF" ForeColor="Black"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #9999FF">Correo</td>
                    <td class="auto-style6" style="background-color: #CCCCFF; color: #000000">
                        <asp:Label ID="correot" runat="server" BackColor="#CCCCFF" ForeColor="Black"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; background-color: #9999FF">Estado del ticket<br />
                        <br />
                        id de la atencion del ticket<br />
                    </td>
                    <td class="auto-style6">
                        <strong style="border: medium double #FFFFFF">
                        <asp:Label ID="estadott" runat="server" ForeColor="White"></asp:Label>
                        <br />
                        <br />
                        </strong>
                        <asp:Label ID="ida" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <strong>
                        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style7" ForeColor="White"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="avisar" runat="server" Text="Avisar al Solicitante" BackColor="#666699" OnClick="Button1_Click" BorderColor="White" BorderStyle="Double" BorderWidth="3px" ForeColor="White" />
                        <asp:Button ID="darfin" runat="server" BackColor="#CC0000" ForeColor="White" Text="Finalizar Atencion" Width="118px" BorderColor="White" BorderStyle="Double" BorderWidth="3px" OnClick="darfin_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"><strong>
                        <asp:Label ID="ob" runat="server" CssClass="auto-style14"></asp:Label>
                        </strong></td>
                    <td class="auto-style9">
                        <asp:TextBox ID="obtxt" runat="server" OnTextChanged="TextBox1_TextChanged" Width="398px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" ForeColor="#CCCCFF" Text="juguetelandiaU" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button1" runat="server" BackColor="#9999FF" Text="Volver a la lista de tickets" BorderColor="#66FFFF" BorderWidth="5px" OnClick="Button1_Click1" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
