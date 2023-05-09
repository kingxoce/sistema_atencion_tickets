<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_escritoriovirtual.aspx.cs" Inherits="consumirsistemadetickets.f_escritoriovirtual" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 592px">
            <br />
            Id_escritorio&nbsp;
            <asp:TextBox ID="idescritoriot" runat="server"></asp:TextBox>
            <br />
            <br />
            Id_empleado&nbsp;
            <asp:TextBox ID="idempleatot" runat="server"></asp:TextBox>
            <br />
            <br />
            Numero de computador&nbsp;
            <asp:TextBox ID="numeropct" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar" />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="564px">
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
