//Opción 1:
const boton = document.querySelector("#btn");

boton.addEventListener("click", () => {
  confirm("¿Está Ud. De acuerdo?") ? console.log("OK") : console.log("NO!!!!");
});

const botonInfo = document.querySelector("#info");
botonInfo.addEventListener("click", () => {
  const nombre = prompt("¿Cuál es tu nombre secreto?");
  if (nombre) {
    console.log(
      "Tu nombre secreto es: " + nombre + ". Ya van los sicarios, mamerto"
    );
  } else
    console.log(
      "Te salvaste esta vez... Cuando quieras introducilo, tranqui ehh..."
    );
});

const listaCracks = [
  { nombre: "Laucha", calidad: 92 },
  {
    nombre: "Pepe",
    calidad: 91,
  },
  {
    nombre: "Maxi",
    calidad: 88,
  },
];
