<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_solicitante.aspx.cs" Inherits="consumirsistemadetickets.f_solicitante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 322px; width: 727px">
            <br />
            Carné&nbsp;
            <asp:TextBox ID="carnett" runat="server" Width="154px"></asp:TextBox>
            <br />
            <br />
            Nombres
            <asp:TextBox ID="nombret" runat="server" Width="161px"></asp:TextBox>
            <br />
            <br />
            Apellidos
            <asp:TextBox ID="apellidot" runat="server" Width="166px"></asp:TextBox>
            <br />
            <br />
            Correo
            <asp:TextBox ID="correot" runat="server" Width="177px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Actualizar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar" />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="624px">
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
