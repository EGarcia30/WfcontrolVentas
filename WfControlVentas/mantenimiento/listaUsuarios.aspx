<%@ Page Title="" Language="C#" MasterPageFile="~/master/Menu.Master" AutoEventWireup="true" CodeBehind="listaUsuarios.aspx.cs" Inherits="WfControlVentas.listaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="width-contenido height-contenido">
        <div class="row m-0">
            <div class="col-12 mt-5 p-0">
                <!--Titulo-->
                <h1 class="text-center text-capitalize">Lista Usuarios</h1>
                <hr class="w-25 text-black m-auto mt-3"/>

                <div class="ps-3 pe-3 mt-3 mb-3 m-auto">
                    <div>
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-danger" OnClick="btnRegresar_Click" />
                    </div>
                </div>
                <div>
                    <!--El despliegue de la tabla historial producto en un gridView-->
                    <div class="overflow-auto ps-3 pe-3">
                        <asp:GridView ID="GvUsuarios" runat="server" CssClass="table table-dark table-bordered table-hover text-center">
                        </asp:GridView>
                    </div>
                </div>
                <!--Mensaje por si existe algun tipo de error al querer mostrar la tabla factura-->
                <div class="mt-3">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
