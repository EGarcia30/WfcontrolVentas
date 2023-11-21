<%@ Page Title="" Language="C#" MasterPageFile="~/master/submenu.Master" AutoEventWireup="true" CodeBehind="eliminarV.aspx.cs" Inherits="WfControlVentas.mantenimiento.crudV.eliminarV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="height-contenido width-contenido">
        <div class="d-flex justify-content-center align-items-center mt-5">
            <div class="col-11 col-md-8 rounded shadow p-3 p-sm-4">
                <div>
                    <h2 class="text-center">Eliminar Venta</h2>
                    <hr />

                    <p class="text-center">¿Estas seguro de eliminar esta Venta?</p>

                    <div class="overflow-auto ps-3 pe-3">
                        <asp:GridView ID="GvVentaE" runat="server" CssClass="table table-dark table-bordered table-hover text-center"></asp:GridView>
                    </div>
                    
                    <!--label por si existe algun error o confirmacion de proceso-->
                    <div class="mt-5 mb-3">
                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                    </div>
                    <!--Grupo de botones para ingresar, limpiar campos y regresar a la tabla-->
                    <div>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click"/>
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-outline-secondary opacity-75" OnClick="btnRegresar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
