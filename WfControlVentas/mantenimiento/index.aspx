<%@ Page Title="" Language="C#" MasterPageFile="~/master/Menu.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WfControlVentas.mantenimiento.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="contenido" class="width-contenido height-contenido">
        <div class="row m-0">
            <div class="col-12 mt-5 p-0">
                <!--Titulo de tabla-->
                <h1 class="text-center text-capitalize">Reporte</h1>
                <hr class="w-25 text-black m-auto mt-3"/>

                <!--Buscar tabla por medio de fechas-->
                
                    <div class="ps-3 pe-3 mt-3 mb-3 m-auto">
                        <div class="d-block d-md-flex">
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <div class="me-auto">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Button ID="btnFchInicio" runat="server" CssClass="btn btn-dark" Text="Fecha Inicio" OnClick="btnFchInicio_Click" />
                                        <asp:Calendar ID="fchInicio" runat="server" EnableTheming="True"></asp:Calendar> 
                                    </ContentTemplate>                                
                                </asp:UpdatePanel>
                            </div>
                            <div class="me-auto">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:Button ID="btnFchFinal" runat="server" Text="Fecha Final" CssClass="btn btn-dark" OnClick="btnFchFinal_Click" />
                                        <asp:Calendar ID="fchFinal" runat="server"></asp:Calendar>
                                    </ContentTemplate>
                                </asp:UpdatePanel>                                
                            </div>

                            <div>
                                <asp:Button ID="btnVer" runat="server" Text="Ver Ganancia" CssClass="btn btn-dark border-opacity-50 me-0 me-xxl-3" OnClick="btnVer_Click" />                               
                            </div>                        
                        </div>
                    </div>

                <div class="row m-0">

                    <!--Mensaje por si existe algun tipo de error al querer mostrar la tabla producto-->
                    <div class="mt-3">
                        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="d-flex flex-column flex-xxl-row justify-content-center justify-content-xxl-between mt-xl-5 m-auto">
                        <div class="mt-5 mt-xxl-0 p-5 bg-content rounded">
                            <div>
                                <h2 class="text-center text-light">INVERSION</h2>
                            </div>
                            <p class="text-center text-light">$<asp:Label ID="lblInversion" runat="server" Text=""></asp:Label></p>
                        </div>
                        <div class="mt-5 mt-xxl-0 p-5 bg-content rounded">
                            <div>
                                <h2 class="text-center text-light">VENTAS</h2>
                            </div>
                            <p class="text-center text-light">$<asp:Label ID="lblVentas" runat="server" Text=""></asp:Label></p>
                        </div>
                        <div class="mt-5 mt-xxl-0 me-0 me-xxl-3 p-5 bg-content rounded">
                            <div>
                                <h2 class="text-center text-light">GANANCIAS</h2>
                            </div>
                            <p class="text-center text-light">$<asp:Label ID="lblProducto" runat="server" Text=""></asp:Label></p>
                        </div>
                    </div>
                </div>                         
                <div class="row m-0 order-1">
                    <div class="d-flex flex-column flex-md-row justify-content-center justify-content-md-between  mt-5 m-auto overflow-scroll">
                        <div class="mt-5 mt-md-0 me-2 p-5 rounded bg-content">
                            <canvas id="topPago" height="400" width="400"></canvas>
                        </div> 
                        <div class="mt-5 mt-md-0 me-2 p-5 rounded bg-content">
                            <canvas id="topVenta" height="400" width="400"></canvas>
                        </div>
                        <div class="mt-5 mt-md-0 p-5 rounded bg-content">
                            <canvas id="topMarca" height="400" width="400"></canvas>
                        </div>  
                    </div>
                </div>                
            </div>
        </div>
    </main>
    <!--jquery-->
    <script src="../Scripts/jquery-3.6.1.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../Scripts/grafico.js" type="text/javascript"></script>
</asp:Content>