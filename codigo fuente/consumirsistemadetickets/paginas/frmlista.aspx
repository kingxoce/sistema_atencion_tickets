<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmlista.aspx.cs" Inherits="consumirsistemadetickets.paginas.frmlista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 363px;
        }
        .auto-style2 {
            text-align: center;
            color: #CC0066;
        }
        .auto-style3 {
            margin-right: 0px;
        }
        .auto-style4 {
            height: 151px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            color: #000099;
            font-size: x-large;
            height: 108px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            color: #006600;
        }
        .auto-style8 {
            height: 26px;
            color: #006600;
            text-align: right;
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style11 {
            text-align: center;
            color: #CC0066;
            width: 60px;
        }
        .auto-style12 {
            height: 26px;
            color: #006600;
            width: 60px;
        }
        .auto-style13 {
            color: #006600;
            width: 60px;
        }
        .auto-style14 {
            height: 151px;
            text-align: center;
            width: 60px;
        }
        .auto-style15 {
            color: #006600;
            text-align: center;
        }
        .auto-style16 {
            color: #006600;
            text-align: right;
        }
    </style>
</head>
<body   style="background-color: #CCCCFF">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5" colspan="8"><strong style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: xx-large; color: #666699; background-color: #CCCCFF">LISTADO DE TICKETS PARA ATENDER</strong></td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style2" colspan="2" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #FFFFFF; font-weight: bold">Seleccione un ticket para atenderlo</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style2" colspan="2" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #FFFFFF; font-weight: bold">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style2" colspan="2" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #FFFFFF; font-weight: bold">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style8" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #666699"><strong>Listar por motivo</strong></td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="DDm" runat="server" CssClass="auto-style3" Height="16px" Width="127px" BackColor="#5D7B9D" ForeColor="White">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
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
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style16" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #666699"><strong>Buscar por estado</strong></td>
                    <td>
                        <asp:DropDownList ID="DDe" runat="server" Height="16px" Width="126px" BackColor="#5D7B9D" ForeColor="White">
                            <asp:ListItem>pendiente</asp:ListItem>
                            <asp:ListItem>atendido</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style7" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #666699">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style15" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" Width="103px" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">
                        &nbsp;</td>
                    <td class="auto-style4" colspan="2">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="698px" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
