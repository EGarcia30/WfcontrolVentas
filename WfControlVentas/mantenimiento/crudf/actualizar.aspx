<%@ Page Title="" Language="C#" MasterPageFile="~/master/submenu.Master" AutoEventWireup="true" CodeBehind="actualizar.aspx.cs" Inherits="WfControlVentas.mantenimiento.crudf.actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--Formulario de Actualizar datos-->
    <main id="contenido" class="width-contenido height-contenido">
        <div class="d-flex justify-content-center align-items-center mt-5">
            <div class="col-11 COL-MD-8 rounded shadow p-3 p-sm-4">
                <div>
                    <!--Titulo-->
                    <h2 class="text-center">Actualizar Factura</h2>
                    <hr />

                    <!--Campos a llenar como la cantidad invertida etc..-->
                    <div class="mt-5">
                        <asp:Label ID="lblInversion" runat="server" Text="Actualizar Inversion:"></asp:Label>
                        <asp:TextBox ID="txtInversion" runat="server" TextMode="Number" step="0.01" CssClass="form-control" placeholder=""></asp:TextBox>
                    </div>

                    <div class="mt-5">
                        <asp:Label ID="lblCantidad" runat="server" Text="Ingresar Cantidad de Pantalones Comprados:"></asp:Label>
                        <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" step="1" CssClass="form-control" placeholder=""></asp:TextBox>
                    </div>

                    <!--label por si existe algun error o confirmacion de proceso-->
                    <div class="mt-5 mb-3">
                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                    </div>

                    <!--Grupo de botones para actualizar, limpiar campos y regresar a la tabla-->
                    <div>
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" OnClick="btnActualizar_Click" />
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-danger opacity-75" OnClick="btnRegresar_Click"/>
                    </div>
                </div>
            </div>

        </div>
    </main>
</asp:Content>
