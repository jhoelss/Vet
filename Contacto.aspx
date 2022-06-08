<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="final.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

        <section class="contenido">
                    <img src="assets/img/clinica.jpg" width="2000" height="600">
                </section>
    <main class="contenedor">
   
        <div class="icons">
          
            <a href="#">
                <i class="fa fa-phone">
                </i> +51 (01) 437 6097 -
            </a>
            <a href="#">
                <i class= "fa fa-envelope">
                </i> clinicaveterinaria@gmail.com
            </a>
            
        </div>
          </main>
     <fieldset>
                <legend>
                    Contáctenos
                </legend>

                <label for="nombre">Nombre:</label>
                <input type="text" placeholder="Ingrese su nombre" id="nombre" />
                <label for="nombre">Apellido:</label>
                <input type="text" placeholder="Ingrese su apellido" id="apellido" />
                <label for="email">Email:</label>
                <input type="email" placeholder="Ingrese su email" id="email" />
                <label for="telefono">Teléfono:</label>
                <input type="tel" placeholder="Ingrese su teléfono" id="telefono" />
                <label for="mensaje">Mensaje:</label>          
           <textarea id="mensaje" cols="20" name="S1" rows="1"></textarea>
               
            </fieldset>
            <input class="boton" type="submit" value="Enviar" />
     
           
   
</asp:Content>
