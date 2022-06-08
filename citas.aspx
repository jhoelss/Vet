<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="citas.aspx.cs" Inherits="final.citas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
      <h2>Citas pendientes</h2>

    <a href="crear_cita.aspx" class="boton">
        <i class="fa-solid fa-file-circle-plus"></i>
        Agregar Nueva Cita
    </a>

        <asp:GridView ID="gvDatos" runat="server" CellPadding="4" GridLines="Horizontal" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" OnRowDeleting="gvDatos_RowDeleting" OnSelectedIndexChanged="gvDatos_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Eliminar" ShowHeader="True" Text="Eliminar Cita" />
            </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />

    </asp:GridView>
     <div class="citas">
        <asp:Repeater ID="rpDatos" runat="server">
            <ItemTemplate>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
