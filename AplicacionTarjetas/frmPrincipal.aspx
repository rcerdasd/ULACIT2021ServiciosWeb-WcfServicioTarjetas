<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="AplicacionTarjetas.frmPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Consulta de emisores"></asp:Label>
        </div>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <asp:GridView ID="gdvEmisores" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <br />
        <!-- Desde aqui la tarea de WCF -->

        <h1>Tarea WCF</h1>
        <asp:Label ID="Label2" runat="server" Text="Digite el numero de tarjeta"></asp:Label>
              <br />
        <asp:TextBox Placeholder="Agregar el numero de la tarjeta" ID="txtCardNum" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="ddlOpcion" runat="server">
            <asp:ListItem Value="1">Obtener emisor</asp:ListItem>
            <asp:ListItem Value="2">Obtener informacion</asp:ListItem>
            <asp:ListItem Value="3">Validar vigencia</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnEjecutar" runat="server" Text="Ejecutar" OnClick="btnEjecutar_Click" />
        <br />
        <asp:Label ID="lblResultado" Visible="false" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblInfoCard" runat="server" Text="Informacion de la tarjeta" Visible="false"></asp:Label> 
        <br />
        <asp:Label ID="lblCod" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblNum" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblTipo" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblSaldo" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblFechaEmi" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblFechaVe" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblEstado" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblCodCliente" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblNombreClient" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lblEmisorTar" runat="server" Text="Label" Visible="false"></asp:Label>
    </form>
</body>
</html>
