﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master/submenu.Master" AutoEventWireup="true" CodeBehind="ingresarV.aspx.cs" Inherits="WfControlVentas.mantenimiento.crudV.ingresarV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Formulario de ingresar datos-->
    <main id="contenido" class="height-contenido width-contenido">
        <div class="d-flex justify-content-center align-items-center mt-5">
            <div class="col-11 col-md-8 rounded shadow p-3 p-sm-4">
                <div>
                    <!--Titulo-->
                    <h2 class="text-center">Ingresar Venta</h2>
                    <hr />

                    <!--Campos a llenar como la cantidad invertida, precio unitario etc..-->
                    <div class="mt-5">
                        <asp:Label ID="label1" runat="server" Text="Ingresar Cantidad de pantalones a vender:"></asp:Label>
                        <asp:TextBox ID="txtCantVent" runat="server" CssClass="form-control" TextMode="Number" step="1" placeholder="1-100.."></asp:TextBox>
                    </div>
                    <div class="mt-5 form-check">
                        <asp:RadioButton ID="rdbStock" runat="server" Text="Stock" GroupName="estado" CssClass="form-check-inline" Enabled="false"/>
                        <asp:RadioButton ID="rdbVenta" runat="server" Text="Venta" GroupName="estado" CssClass="form-check-inline"/>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="label2" runat="server" Text="ID del producto a vender:"></asp:Label>
                        <asp:TextBox ID="txtIdProducto" runat="server" CssClass="form-control" TextMode="Number" step="1" placeholder="1-100.."></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="label3" runat="server" Text="ID de factura(inversion) asociada a producto:"></asp:Label>
                        <asp:TextBox ID="txtIdFactura" runat="server" CssClass="form-control" TextMode="Number" step="1" placeholder="1-100.."></asp:TextBox>
                    </div>
                    <!--label por si existe algun error o confirmacion de proceso-->
                    <div class="mt-5 mb-3">
                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                    </div>
                    <!--Grupo de botones para ingresar, limpiar campos y regresar a la tabla-->
                    <div>
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-success" OnClick="btnIngresar_Click"/>
                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-outline-dark opacity-50" OnClick="btnLimpiar_Click"/>
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-danger opacity-75" OnClick="btnRegresar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
