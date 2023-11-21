<%@ Page Title="" Language="C#" MasterPageFile="~/master/Menu.Master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="WfControlVentas.mantenimiento.usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="width-contenido height-contenido">
        <div class="row p-0 m-0">
            <div class="col mt-5">
                <div class="col-8 pt-5 pb-5 border border-opacity-50 border-secondary rounded m-auto shadow">
                    <h1 class="text-center mb-3">Hola <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></h1>
                    <h2 class="pb-3 ms-5">Datos Personales</h2>

                    <div class="ms-5"> 
                        <p class="d-">id: <asp:Label ID="lblId" runat="server" Text=""></asp:Label></p> 
                        <p>Nombre Usuario: <asp:Label ID="lblNombreU" runat="server" Text=""></asp:Label></p> 
                        <p>Nombre Real: <asp:Label ID="lblNombreR" runat="server" Text=""></asp:Label></p>
                        <p>Clave: <asp:Label ID="lblClave" runat="server" Text=""></asp:Label></p>
                        <p class="mb-4">Tipo de usuario: <asp:Label ID="lblTipo" runat="server" Text=""></asp:Label></p>
                    </div>
                   

                    <asp:Button ID="btnUsuario" runat="server" Text="Ver todos los usuarios" CssClass="btn btn-dark ms-5" OnClick="btnUsuario_Click"/>
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Usuario" CssClass="btn btn-primary" OnClick="btnAgregar_Click"/>

                </div>
            </div>
            
        </div>
    </main>
</asp:Content>
