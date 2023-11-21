<%@ Page Title="" Language="C#" MasterPageFile="~/master/Menu.Master" AutoEventWireup="true" CodeBehind="producto.aspx.cs" Inherits="WfControlVentas.mantenimiento.producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="width-contenido height-contenido">
        <!--Tabla producto-->
        <div class="row m-0">
            <div class="col-12 mt-5 p-0">
                 <!--Titulo de tabla-->
                <h1 class="text-center text-capitalize">Producto(Ventas)</h1>
                <hr class="w-25 text-black m-auto mt-3"/>


                <!--Grupo de botones para ingresar y buscar producto-->
                <div class="d-flex ps-3 pe-3 mb-3 mt-5">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" default="true"/>
                    <asp:TextBox ID="txtBuscar" runat="server" placeholder="Buscar Producto" CssClass="form-control me-5"></asp:TextBox>
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar Producto" CssClass="btn btn-primary" OnClick="btnIngresar_Click"/>
                </div>

                <!--Boton para ir a la tabla ventas-->
                <div class="ps-3 pe-3 mb-3 mt-5">
                    <asp:Button ID="btnVentas" runat="server" Text="Ver Ventas >" CssClass="btn btn-dark" OnClick="btnVentas_Click"/>
                </div>

                <!--Buscar tabla por medio de fechas-->
                <div class="ps-3 pe-3 mt-3 mb-3 m-auto">
                    <div class="d-block d-md-flex">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <div class="me-auto">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Button ID="btnFchInicio" runat="server" Text="Fecha Inicio" CssClass="btn btn-dark" OnClick="btnFchInicio_Click"/>
                                    <asp:Calendar ID="fchInicio" runat="server"></asp:Calendar>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            
                        </div>
                        <div class="me-auto">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:Button ID="btnFchFinal" runat="server" Text="Fecha Final" CssClass="btn btn-dark" OnClick="btnFchFinal_Click"/>
                                    <asp:Calendar ID="fchFinal" runat="server"></asp:Calendar>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>

                        <div>
                            <asp:Button ID="btnVerTablaProducto" runat="server" Text="Mostrar tabla Producto" CssClass="btn btn-dark border-opacity-50" OnClick="btnVerTablaProducto_Click"/>
                        </div>
                        
                    </div>
                </div>
                <div>
                    <!--El despliegue de la tabla producto en un gridView-->
                    <div class="overflow-auto ps-3 pe-3">
                        <asp:GridView ID="GvProducto" runat="server" CssClass="table table-dark table-bordered table-hover text-center">
                            <Columns>
                                <asp:TemplateField HeaderText="Opciones de Administrador">
                                    <ItemTemplate>
                                        <div class="d-flex ps-2 pe-2">
                                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger me-2" OnClick="btnEliminar_Click"/>
                                            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" OnClick="btnActualizar_Click"/>                                           
                                        </div>                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <!--Mensaje por si existe algun tipo de error al querer mostrar la tabla producto-->
                <div class="mt-3">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
