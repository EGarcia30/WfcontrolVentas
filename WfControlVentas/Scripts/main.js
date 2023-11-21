/*Crear constantes para el despliegue de nuestro navbar y contenido */
const menu_btn = document.getElementById('menu-btn');
const menu = document.getElementById('nav_vertical');
const menu_horizontal = document.getElementById('nav_horizontal');
const contenido = document.getElementById('contenido');


/*Añadir el evento click en el boton de nuestro menu horizontal*/
menu_btn.addEventListener("click", () => {
    menu.classList.toggle("active-nav");
    menu_horizontal.classList.toggle("active-cont");
    contenido.classList.toggle("active-main");
})
