<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>

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
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" /> 
                <asp:BoundField HeaderText="Año Especialidad" DataField="AnioEspecialidad" /> 
                <asp:BoundField HeaderText="ID Plan" DataField="IDPlan" /> 
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" /> 
            </Columns> 
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView> 
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox> 
        <asp:Label ID="descripcionLabelError" runat="server" Text="* La descripcion no puede ser vacia" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="anioEspecialidadLabel" runat="server" Text="Año Especialidad: "></asp:Label> 
        <asp:TextBox ID="anioEspecialidadTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="anioEspecialidadLabelError" runat="server" Text="* El año de la especialidad no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="idPLanLabel" runat="server" Text="ID Plan: "></asp:Label> 
        <asp:DropDownList ID="idPlanddl" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_plan" DataValueField="id_plan">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-BJM9O7P\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;User ID=DESKTOP-BJM9O7P\PC" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [id_plan] FROM [planes]"></asp:SqlDataSource>
        <asp:Label ID="idPLanLabelError" runat="server" Text="* Debe seleccionar un ID de un Plan" Visible="False"></asp:Label>
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
