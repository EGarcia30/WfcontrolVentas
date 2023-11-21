const btnLimpiar = document.getElementById("limpiar");
const formulario = document.getElementById("ingresar");
const lblMensaje = document.getElementById("mensaje");

function borrar() {
    /*console.log("al fin funciona algo en mi vida");*/
    formulario.reset();
    lblMensaje.className = "alert alert-";
    lblMensaje.innerHTML = "";
}