<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarCita.aspx.cs" Inherits="final.ModificarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
       <h2>Modificar Cita</h2>

    <a class="boton" href="citas.aspx" title="Regresar">
        <i class="fa-solid fa-circle-left"></i>
        Regresar
    </a>
    
    <fieldset>
        <legend>Datos de la cita</legend>

        <label for="txtHora">Hora:</label>
        <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>

        <label for="txtDia">Dia:</label>
        <asp:TextBox ID="txtDia" runat="server"></asp:TextBox>

        <label for="txtServicio">Servicio:</label>
        <asp:TextBox ID="txtServicio" runat="server"></asp:TextBox>

        <label for="txtNombreVeterinario">NombreVeterinario:</label>
        <asp:TextBox ID="txtNombreVeterinario" runat="server"></asp:TextBox>

        <label for="txtApellido">ApellidoVeterinario:</label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>

        <label for="txtNombre">NombreMascota:</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

        <label for="txtRaza">Raza:</label>
        <asp:TextBox ID="txtRaza" runat="server"></asp:TextBox>
       
    </fieldset>
    <asp:Button ID="btnAtualizar" CssClass="boton" runat="server" OnClick="actualizar" Text="Modificar" />
</asp:Content>
