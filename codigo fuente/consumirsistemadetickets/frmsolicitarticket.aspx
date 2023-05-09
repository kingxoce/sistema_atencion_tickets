<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmsolicitarticket.aspx.cs" Inherits="consumirsistemadetickets.frmsolicitarticket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 76px;
        }
        .auto-style9 {
            width: 100%;
            height: 127px;
        }
        .auto-style10 {
            height: 181px;
        }
        .auto-style11 {
            width: 271px;
            height: 25px;
            color: #0033CC;
        }
        .auto-style13 {
            height: 25px;
        }
        .auto-style14 {
            text-align: center;
            color: #000066;
            height: 125px;
        }
        .auto-style15 {
            width: 271px;
            height: 76px;
            color: #0033CC;
            text-align: right;
        }
        .auto-style16 {
            width: 271px;
            height: 25px;
            color: #0033CC;
            text-align: right;
        }
        .auto-style18 {
            height: 34px;
        }
    </style>
</head>
<body style="background-color: #CCCCFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <table  align="center" class="auto-style9" style="margin-top: 0px;">
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14" colspan="2"><strong style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: xx-large; color: #666699; background-color: #CCCCFF">SOLICITAR UN TICKET</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style15" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; text-align: center; color: #000000;"><strong style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; text-align: center">Eliga el motivo de atencion de su ticket</strong></td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DDmotivo" runat="server" Height="16px" Width="179px" AutoPostBack="True" OnSelectedIndexChanged="DDmotivo_SelectedIndexChanged" BackColor="#DEDFDE">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15" style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000;">&nbsp;</td>
                <td class="auto-style15" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; color: #000000; text-align: center;"><strong>Descripcion</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="desc" runat="server" Height="58px" ReadOnly="True" TextMode="MultiLine" Width="279px" BackColor="#DEDFDE"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; text-align: center; color: #000000;">&nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style16" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; text-align: center; color: #000000;"><strong style="font-family: Verdana, Geneva, Tahoma, sans-serif; color: #000000; text-align: center">Escriba su carné</strong></td>
                <td class="auto-style13">
                    <asp:TextBox ID="carnett" runat="server" Width="236px" BackColor="#DEDFDE"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center" class="auto-style18">
                    </td>
                <td colspan="2" style="text-align: center" class="auto-style18">
                    <asp:Button ID="agregar" runat="server" Text="agregar ticket" Width="198px" OnClick="agregar_Click" BackColor="#666699" BorderColor="White" BorderStyle="Double" BorderWidth="5px" />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar y Solicitar ticket" Width="198px" BackColor="Black" BorderColor="White" BorderStyle="Double" BorderWidth="5px" ForeColor="White" />
                </td>
                <td style="text-align: center" class="auto-style18">
                    </td>
                <td style="text-align: center" class="auto-style18">
                    </td>
                <td style="text-align: center" class="auto-style18">
                    </td>
                <td style="text-align: center" class="auto-style18">
                    </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">
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
                <td>
                    &nbsp;</td>
                <td colspan="2">
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
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style10" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Width="732px" DataKeyNames="idmo" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField DeleteText="" HeaderText="Quitar" SelectText="Quitar" ShowSelectButton="True" />
                            <asp:BoundField DataField="carne" HeaderText="Carné" />
                            <asp:BoundField DataField="motivo" HeaderText="Motivo de ticket" />
                        </Columns>
                        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#594B9C" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#33276A" />
                    </asp:GridView>
                    </strong></td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
