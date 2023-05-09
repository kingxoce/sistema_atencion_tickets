<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_usuario.aspx.cs" Inherits="consumirsistemadetickets.f_usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 335px">
            <br />
            Id_usuario&nbsp;
            <asp:TextBox ID="idusuariot" runat="server" Width="147px"></asp:TextBox>
            <br />
            <br />
            Carné&nbsp;
            <asp:TextBox ID="carnett" runat="server" Width="150px"></asp:TextBox>
            <br />
            <br />
            Id_empleado&nbsp;
            <asp:TextBox ID="idempleadot" runat="server" Width="148px"></asp:TextBox>
            <br />
            <br />
            Correo&nbsp;
            <asp:TextBox ID="correot" runat="server" Width="159px"></asp:TextBox>
            <br />
            <br />
            Password&nbsp;
            <asp:TextBox ID="passwordt" runat="server" Width="153px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
            <asp:Button ID="eliminar" runat="server" OnClick="eliminar_Click" Text="Eliminar" />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="625px">
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
