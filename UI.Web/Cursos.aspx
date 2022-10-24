<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>

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
                <asp:BoundField HeaderText="Año Calendario" DataField="AnioCalendario" /> 
                <asp:BoundField HeaderText="Cupo" DataField="Cupo" /> 
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" /> 
                <asp:BoundField HeaderText="ID Comision" DataField="IDComision" /> 
                <asp:BoundField HeaderText="ID Materia" DataField="IDMateria" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" /> 
            </Columns> 
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView> 
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="anioCalendarioLabel" runat="server" Text="Año Calendario: "></asp:Label>
        <asp:TextBox ID="anioCalendarioTextBox" runat="server"></asp:TextBox> 
        <asp:Label ID="anioCalendarioLabelError" runat="server" Text="* El año no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="cupoLabel" runat="server" Text="Cupo: "></asp:Label> 
        <asp:TextBox ID="cupoTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="cupoLabelError" runat="server" Text="* El cupo no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label> 
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="descripcionLabelError" runat="server" Text="* La descripcion debe tener el formato adecuado" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="idComisionLabel" runat="server" Text="ID Comision: "></asp:Label>
        <asp:DropDownList ID="idComisionddl" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_comision" DataValueField="id_comision">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-BJM9O7P\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;User ID=DESKTOP-BJM9O7P\PC" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [id_comision] FROM [comisiones]"></asp:SqlDataSource>
        <asp:Label ID="idComisionLabelError" runat="server" Text="* El ID de la Comision no puede ser vacio" Visible="False"></asp:Label>
        <br /> 
        <asp:Label ID="idMateriaLabel" runat="server" Text="ID Materia: "></asp:Label> 
        <asp:DropDownList ID="idMateriaddl" runat="server" DataSourceID="SqlDataSource2" DataTextField="id_materia" DataValueField="id_materia">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=DESKTOP-BJM9O7P\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;User ID=DESKTOP-BJM9O7P\PC" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [id_materia] FROM [materias]"></asp:SqlDataSource>
        <asp:Label ID="idMateriaLabelError" runat="server" Text="* El ID de la materia no puede ser vacio" Visible="False"></asp:Label>
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