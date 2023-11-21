<%@ Page Title="" Language="C#" MasterPageFile="~/master/submenu.Master" AutoEventWireup="true" CodeBehind="actualizarP.aspx.cs" Inherits="WfControlVentas.mantenimiento.crudP.actualizarP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--Formulario de actualizar datos-->
    <main id="contenido" class="height-contenido width-contenido">
        <div class="d-flex justify-content-center align-items-center mt-5">
            <div class="col-11 col-md-8 rounded shadow p-3 p-sm-4">
                <div>
                      <!--Titulo-->
                    <h2 class="text-center">Actualizar Producto</h2>
                    <hr />

                    <!--Campos a llenar como la cantidad invertida, precio unitario etc..-->
                    <div class="mt-5">
                        <asp:Label ID="Label1" runat="server" Text="Ingresar Cantidad Pantalones:"></asp:Label>
                        <asp:TextBox ID="txtCant" runat="server" TextMode="Number" step="1" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label3" runat="server" Text="Ingresar color/Estilo:"></asp:Label>
                        <asp:TextBox ID="txtColor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label4" runat="server" Text="Ingresar Marca:"></asp:Label>
                        <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label5" runat="server" Text="Ingresar Talla:"></asp:Label>
                        <asp:TextBox ID="txtTalla" runat="server" CssClass="form-control" Text="talla "></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label6" runat="server" Text="Ingresar Precio Unitario:"></asp:Label>
                        <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" TextMode="Number" step="00.01"></asp:TextBox>
                    </div>
                    <div class="mt-5 form-check">
                        <asp:RadioButton ID="rdbStock" runat="server" Text="Stock" GroupName="estado" CssClass="form-check-inline" />
                        <asp:RadioButton ID="rdbVenta" runat="server" Text="Venta" GroupName="estado" CssClass="form-check-inline" Enabled="false"/>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label7" runat="server" Text="Ingresar Id a factura asociada esta inversión:"></asp:Label>
                        <asp:TextBox ID="txtIdFactura" runat="server" CssClass="form-control" TextMode="Number" step="1"></asp:TextBox>
                    </div>
                    <!--label por si existe algun error o confirmacion de proceso-->
                    <div class="mt-5 mb-3">
                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                    </div>
                    <!--Grupo de botones para ingresar, limpiar campos y regresar a la tabla-->
                    <div>
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" OnClick="btnActualizar_Click"/>
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-danger opacity-75" OnClick="btnRegresar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
