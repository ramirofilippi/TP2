<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>

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
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField HeaderText="EMail" DataField="EMail" /> 
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento" /> 
                <asp:BoundField HeaderText="ID del Plan" DataField="IDPlan" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" /> 
            </Columns> 
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
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
        <asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="direccionLabelError" runat="server" Text="* La direccion no puede ser vacia" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="emailLabel" runat="server" Text="EMail: "></asp:Label> 
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="emailLabelError" runat="server" Text="* El EMail debe tener el formato adecuado" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="fechaNacimientoLabel" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
        <asp:Calendar ID="fechaNacimientoCalendar" runat="server"></asp:Calendar>
        <asp:Label ID="fechaNacimientoLabelError" runat="server" Text="* La fecha de nacimiento no puede ser vacia" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="idPLanLabel" runat="server" Text="ID del Plan: "></asp:Label>
        <asp:TextBox ID="idPLanTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="idPLanLabelError" runat="server" Text="* El ID del plan no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server"></asp:TextBox> 
        <asp:Label ID="legajoLabelError" runat="server" Text="* El Legajo no puede ser vacia" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label> 
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="telefonoLabelError" runat="server" Text="* El Telefono no puede ser vacio" Visible="False"></asp:Label>
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
