<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>

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
                <asp:BoundField HeaderText="Desc Plan" DataField="Descripcion" />
                <asp:BoundField HeaderText="Hs Semanales" DataField="HSSemanales" />
                <asp:BoundField HeaderText="Hs Totales" DataField="HSTotales" />
                <asp:BoundField HeaderText="ID Plan" DataField="IDPlan" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" /> 
            </Columns> 
        </asp:GridView> 
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="descripcionLabel" runat="server" Text="Desc Materia: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox> 
        <asp:Label ID="descripcionLabelError" runat="server" Text="* La descripcion no puede ser vacia" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="hsSemanalesLabel" runat="server" Text="Hs Semanales: "></asp:Label>
        <asp:TextBox ID="hsSemanalesTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="hsSemanalesLabelError" runat="server" Text="* La cantidad de horas no puede ser vacia" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="hsTotalesLabel" runat="server" Text="Hs Totales: "></asp:Label>
        <asp:TextBox ID="hsTotalesTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="hsTotalesLabelError" runat="server" Text="* La cantidad de horas no puede ser vacia" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="idPlanLabel" runat="server" Text="ID Plan: "></asp:Label>
&nbsp;<asp:DropDownList ID="idPlanDropDownList" runat="server" DataSourceID="SqlDataSource" DataTextField="id_plan" DataValueField="id_plan">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringLocal %>" SelectCommand="SELECT [id_plan] FROM [planes]"></asp:SqlDataSource>
        <asp:Label ID="idPlanLabelError" runat="server" Text="* Debe seleccionar un plan" Visible="False"></asp:Label>
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
