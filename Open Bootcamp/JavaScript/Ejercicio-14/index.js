const boton = document.querySelector("#btn");
boton.addEventListener("click", () => {
  alert("Has hecho click... Qué buena puntería!!!");
});

$(() => {
  $(".botonito").click(() => {
    console.log("Hola, estoy utilizando jQuery");
  });
});
