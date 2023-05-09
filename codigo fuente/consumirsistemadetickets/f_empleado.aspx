<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_empleado.aspx.cs" Inherits="consumirsistemadetickets.f_empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 442px">
    <form id="form1" runat="server">
        <div>
            <br />
            Id de empleado&nbsp;
            <asp:TextBox ID="idempleadot" runat="server" Height="16px" Width="157px"></asp:TextBox>
            <br />
            <br />
            Nombre&nbsp;
            <asp:TextBox ID="nombret" runat="server" Height="16px" Width="174px"></asp:TextBox>
            <br />
            <br />
            Puesto&nbsp;
            <asp:TextBox ID="puestot" runat="server" Width="162px"></asp:TextBox>
            <br />
            <br />
            Correo <asp:TextBox ID="correot" runat="server" Width="154px"></asp:TextBox>
            <br />
            <br />
            Telefono
            <asp:TextBox ID="telefonot" runat="server" Width="163px"></asp:TextBox>
            <br />
            <br />
            Dirección
            <asp:TextBox ID="direcciont" runat="server" Width="174px"></asp:TextBox>
            <br />
            <br />
            Sueldo
            <asp:TextBox ID="sueldot" runat="server" Width="163px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Height="137px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="664px">
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
    </form>
</body>
</html>
