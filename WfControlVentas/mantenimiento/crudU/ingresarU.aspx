<%@ Page Title="" Language="C#" MasterPageFile="~/master/submenu.Master" AutoEventWireup="true" CodeBehind="ingresarU.aspx.cs" Inherits="WfControlVentas.mantenimiento.crudU.ingresarU" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="width-contenido height-contenido">
        <div class="d-flex justify-content-center align-items-center mt-5">
            <div class="col-11 col-md-8 rounded shadow p-3 p-sm-4">
                <div>
                    <!--Titulo-->
                    <h2 class="text-center">Ingresar Usuario</h2>
                    <hr />

                    <div class="mt-5">
                        <asp:Label ID="Label1" runat="server" Text="Ingresar Nombre de Usuario:"></asp:Label>
                        <asp:TextBox ID="txtNombreU" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label2" runat="server" Text="Ingresar nombre Real:"></asp:Label>
                        <asp:TextBox ID="txtNombreR" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mt-5">
                        <asp:Label ID="Label3" runat="server" Text="Ingresar nueva clave:"></asp:Label>
                        <asp:TextBox ID="txtClave" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-check mt-5">
                        <asp:RadioButton ID="rdbDesarrollador" Text="Desarrollador" GroupName="tipoUsuario" CssClass="form-check-inline" runat="server" />
                        <asp:RadioButton ID="rdbAdministrador" Text="Administrador" GroupName="tipoUsuario" CssClass="form-check-inline" runat="server" />
                        <asp:RadioButton ID="rdbUsuario" Text="Usuario" GroupName="tipoUsuario" CssClass="form-check-inline" runat="server" />
                    </div>
                    <div class="mt-3 mb-3">
                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                    </div>

                    <div>
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click"/>
                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-outline-dark" OnClick="btnLimpiar_Click"/>
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-danger opacity-75" OnClick="btnRegresar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
