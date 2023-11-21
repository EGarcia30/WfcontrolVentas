<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicioSesion.aspx.cs" Inherits="WfControlVentas.inicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<!--BOOTSTRAP Y CSS-->
<link rel="stylesheet" href="./Content/bootstrap.min.css" />
<link rel="stylesheet" href="./Content/inicio.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar Sesion</title>
</head>
<body class="vh-100">
    <div class="container-fluid">
        <div class="row d-flex p-0">
            <!--Inicio de sesion-->
            <div class="col order-1 p-0">
                <div class="d-flex flex-column justify-content-center align-items-center vh-100">
                    <div class=" text-center">
                        <h1 class="text-color">Iniciar Sesion</h1>
                    </div>
                    <!--Formulario ingresar datos-->
                    <div class="w-75">
                        <form id="Iniciar_sesion" runat="server">
                            <div class="mt-3">
                                <asp:Label ID="lblUsuario" runat="server" Text="Ingresar Usuario:"></asp:Label>
                                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="P123"></asp:TextBox>
                            </div>
                            <div class="mt-3 mb-3">
                                <asp:Label ID="lblContra" runat="server" Text="Ingresar contraseña:"></asp:Label>
                                <asp:TextBox ID="txtContra" runat="server" CssClass="form-control" TextMode="Password" placeholder="P321"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblError" runat="server" CssClass="" Text=""></asp:Label>
                            </div>
                            <div>
                                <asp:Button ID="btnIniciarSesion" runat="server" CssClass="btn btn-primary w-100" Text="Iniciar Sesion" OnClick="btnIniciarSesion_Click" />
                            </div> 
                        </form>
                    </div>  
                </div>        
            </div>
            <!--Carousel de imagenes-->
            <div class="d-md-block d-none col col-lg-9  col-md-7 p-0">
                <div class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img src="img/fondo.jpg" class="d-block w-100 img_media" alt="fondo" data-bs-interval="500" />
                        </div>
                        <div class="carousel-item">
                            <img src="img/Logo.jpg" class="d-block w-100 img_media" alt="logo" data-bs-interval="1000" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--Javascript-->
    <!--Javascript de Bootstrap-->
    <script src="./Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
