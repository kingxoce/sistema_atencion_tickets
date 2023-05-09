<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_atencionticket.aspx.cs" Inherits="consumirsistemadetickets.f_atencionticket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id_atencion ticket&nbsp;
            <asp:TextBox ID="idatenciont" runat="server"></asp:TextBox>
            <br />
            <br />
            Id_ticket&nbsp;
            <asp:TextBox ID="idtickett" runat="server"></asp:TextBox>
            <br />
            <br />
            Id_escritorio&nbsp;
            <asp:TextBox ID="idescritoriot" runat="server"></asp:TextBox>
            <br />
            <br />
            id_empleado&nbsp;
            <asp:TextBox ID="idempleadot" runat="server"></asp:TextBox>
            <br />
            <br />
            Estado del ticket&nbsp;
            <asp:TextBox ID="estadot" runat="server" EnableViewState="False"></asp:TextBox>
            <br />
            &nbsp;
            <br />
            Observaciones&nbsp;
            <asp:TextBox ID="observaciont" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="567px">
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
