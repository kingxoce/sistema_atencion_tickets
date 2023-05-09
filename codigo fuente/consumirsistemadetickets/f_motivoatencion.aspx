<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_motivoatencion.aspx.cs" Inherits="consumirsistemadetickets.f_motivoatencion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 294px">
            <br />
            Id_atención
            <asp:TextBox ID="idatenciont" runat="server" Width="155px"></asp:TextBox>
            <br />
            <br />
            Motivo&nbsp;
            <asp:TextBox ID="motivot" runat="server"></asp:TextBox>
            <br />
            <br />
            Descripción&nbsp;
            <asp:TextBox ID="descripciont" runat="server" Height="37px" Width="331px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
            <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click1" />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="609px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
