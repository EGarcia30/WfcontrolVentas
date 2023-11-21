<%@ Page Title="" Language="C#" MasterPageFile="~/master/Menu.Master" AutoEventWireup="true" CodeBehind="inversion.aspx.cs" Inherits="WfControlVentas.mantenimiento.inversion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="width-contenido height-contenido">
        <!--Tabla factura-->
        <div class="row m-0">
            <div class="col-12 mt-5 p-0">
                <!--Titulo de tabla-->
                <h1 class="text-center text-capitalize">Facturas(Inversiones)</h1>
                <hr class="w-25 text-black m-auto mt-3"/>

                <!--Grupo de botones para ingresar y buscar factura-->
                <div class="d-flex ps-3 pe-3 mb-3 mt-5">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" type="submit" OnClick="btnBuscar_Click"/>
                    <asp:TextBox ID="txtBuscar" runat="server" placeholder="Buscar Factura" CssClass="form-control me-5" ></asp:TextBox>
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar Facturas" CssClass="btn btn-primary" OnClick="btnIngresar_Click"/>                   
                </div>

                <!--Buscar tabla por medio de fechas-->
                <div class="ps-3 pe-3 mt-3 mb-3 m-auto">
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <div class="d-block d-md-flex">
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
                            <asp:Button ID="btnVerTablaFactura" runat="server" Text="Mostrar tabla Factura" CssClass="btn btn-dark border-opacity-50" OnClick="btnVerTablaFactura_Click"/>
                        </div>                        
                    </div>
                </div>
                <div>
                    <!--El despliegue de la tabla factura en un gridView-->
                    <div class="overflow-auto ps-3 pe-3">
                        <asp:GridView ID="GvFactura" runat="server" CssClass="table table-dark table-bordered table-hover text-center">
                           <Columns>
                               <asp:TemplateField HeaderText="Opciones de administrador">
                                   <ItemTemplate>
                                       <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" OnClick="btnActualizar_Click" />
                                   </ItemTemplate>
                               </asp:TemplateField>
                           </Columns>
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
