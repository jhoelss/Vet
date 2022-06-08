<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="crear_cita.aspx.cs" Inherits="final.crear_cita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
  
    <a class="boton" href="citas.aspx" title="Regresar">
        <i class="fa-solid fa-circle-left"></i>
        Regresar
    </a>
     <fieldset>
        <legend>Generar Cita </legend>

        <label for="txtHora">Hora:</label>
        <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>

        <label for="txtDia">Dia:</label>
        <asp:TextBox ID="txtDia" runat="server"></asp:TextBox>


        <label for="ddlVeterinario">Servicio:</label>
         <asp:DropDownList ID="ddlVeterinario" runat="server"></asp:DropDownList>
    

        <label for="txtNombreVeterinario">Nombre del Veterinario(a)</label>
       <asp:TextBox ID="txtNombreVeterinario" runat="server"></asp:TextBox>

        <label for="ApellidoVeterinario">Apellido del  Veterinario:</label>
  <asp:TextBox ID="txtApellidoVeterinario" runat="server"></asp:TextBox>

         <label for="txtNombre">Nombre de la Mascota</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

             <label for="txtRaza">Raza:</label>
  <asp:TextBox ID="txtRaza" runat="server"></asp:TextBox>

        
    </fieldset>
    <asp:Button CssClass="boton" ID="btnRegistrar" runat="server" Text="Registrar Cita" OnClick="registrar" />
</asp:Content>
