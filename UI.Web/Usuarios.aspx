<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" Runat="Server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" 
            SelectedRowStyle-ForeColor="White" 
            DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" > 
            <Columns >
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" /> 
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" /> 
                <asp:BoundField HeaderText="EMail" DataField="EMail" /> 
                <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" /> 
                <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" /> 
            </Columns> 
        </asp:GridView> 
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox> 
        <asp:Label ID="nombreLabelError" runat="server" Text="* El nombre no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label> 
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="apellidoLabelError" runat="server" Text="* El apellido no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="emailLabel" runat="server" Text="EMail: "></asp:Label> 
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="emailLabelError" runat="server" Text="* El EMail debe tener el formato adecuado" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
        <asp:CheckBox ID="habilitadoCheckBox" runat="server"/>
        <br /> 
        <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label> 
        <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox> 
        <asp:Label ID="nombreUsuarioLabelError" runat="server" Text="* El nombre de usuario no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server"></asp:TextBox> 
        <asp:Label ID="claveLabelError" runat="server" Text="* La clave no puede ser vacia" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir clave: "></asp:Label> 
        <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server"> </asp:TextBox>
        <asp:Label ID="repetirClaveLabelError" runat="server" Text="* Debe ingresar la misma clave" Visible="False"></asp:Label>
        <br /> 
    </asp:Panel>
    <asp:Panel ID ="gridActionsPanel" runat ="server">
        <asp:LinkButton ID ="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID ="eliminarLinkButton" runat ="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID ="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID ="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat ="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
