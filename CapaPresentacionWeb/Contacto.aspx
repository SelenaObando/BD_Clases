<%@ Page Title="" Language="C#" MasterPageFile="~/Maqueta.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="CapaPresentacionWeb.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Contacto" class="container">  <!---- Inicio Contactos---->
     <div class="row">
        <div class="col-md-12">
            <div class="well well-sm">
                <%--<form class="form-horizontal">--%>
                    <fieldset>
                        <legend class="text-center header">Contáctenos</legend>

                       
                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="glyphicon glyphicon-user"></i></span>
                            <div class="col-md-8">
                                
                                <input id="txtnombres" runat="server" type="text" placeholder="Nombres y Apellidos" class="form-control"  required >

                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="glyphicon glyphicon-envelope"></i></span>
                            <div class="col-md-8">
                                
                                <input id="txtcorreo"  runat="server" type="text" placeholder="Correo electrónico" class="form-control" pattern="^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$" 
                                required title="Introduzca un correo válido">
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="glyphicon glyphicon-phone"></i></span>
                            <div class="col-md-8">
                               
                                <input id="txttelefono" runat="server" type="text" placeholder="Teléfono" class="form-control" pattern="^[9|8|7|2|5]\d{8}$" 
                                required title="Introduzca un numero de teléfono">
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="glyphicon glyphicon-pencil"></i></span>
                            <div class="col-md-8">
                               
                                <textarea class="form-control" runat="server" id="txtmensaje"  placeholder="Mensaje" rows="7" required></textarea>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <asp:Button ID="btcontacto" runat="server" Text="Contactar" OnClick="btcontacto_Click" class="btn btn-primary btn-lg" />
                                
                           <asp:Label ID="indicador" runat="server"></asp:Label>
                             </div>
                        </div>
                    </fieldset>
                <%--</form>--%>
            </div>
        </div>
    </div>
</div> <!--Cierre contacto-->

</asp:Content>
