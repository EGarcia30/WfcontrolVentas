<%@ Page Title="" Language="C#" MasterPageFile="~/master/Menu.Master" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="WfControlVentas.mantenimiento.ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Tabla venta-->
    <main id="contenido" class="width-contenido height-contenido">
        <div class="row m-0">
            <div class="col-12 mt-5 p-0">
                <!--Titulo de tabla-->
                <h1 class="text-center text-capitalize">Ventas</h1>
                <hr class="w-25 text-black m-auto mt-3"/>

                <!--Grupo de botones para ingresar y buscar ventas-->
                <div class="d-flex ps-3 pe-3 mb-3 mt-5">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click"/>
                    <asp:TextBox ID="txtBuscar" runat="server" placeholder="Buscar Venta" CssClass="form-control me-5"></asp:TextBox>
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar Venta" CssClass="btn btn-primary" OnClick="btnIngresar_Click"/>
                </div>

                <!--Boton para ir a la tabla producto-->
                <div class="ps-3 pe-3 mb-3 mt-5">
                    <asp:Button ID="btnProducto" runat="server" Text="Ver Productos >" CssClass="btn btn-dark" OnClick="btnProducto_Click"/>
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
                            <asp:Button ID="btnVerTablaVenta" runat="server" Text="Mostrar tabla Venta" CssClass="btn btn-dark border-opacity-50" OnClick="btnVerTablaVenta_Click"/>
                        </div>                       
                    </div>
                </div>
                <div>
                    <!--El despliegue de la tabla producto en un gridView-->
                    <div class="overflow-auto ps-3 pe-3">
                        <asp:GridView ID="GvVentas" runat="server" CssClass="table table-dark table-bordered table-hover">
                            <Columns>
                                <asp:TemplateField HeaderText="Opciones de Administrador">
                                    <ItemTemplate>
                                        <div class="d-flex ps-2 pe-2">
                                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger me-2" OnClick="btnEliminar_Click"/>
                                            <asp:Button ID="btnActualizar" runat="server" Text="Agregar Venta" CssClass="btn btn-success" Onclick="btnActualizar_Click"/>                                           
                                        </div>                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div class="mt-3">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
