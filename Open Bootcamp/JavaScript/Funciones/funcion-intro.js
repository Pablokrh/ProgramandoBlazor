function Saludar() {
  console.log("Hola");
}
Saludar();

function Saludar2(parametro1) {
  console.log("¡Hola qué tal, " + parametro1 + "!");
}
Saludar2("Pablo");

function Saludar3(nombre) {
  nombre = "Diego";
  console.log("¡Hola qué tal, " + nombre + "!");
}
let nombre = "Pablo";
Saludar3(nombre);
console.log(nombre);

let persona = { nombre: "Pablo", apellido: "Krojzl" };
saludaObjeto(persona);

function saludaObjeto(personaPar) {
  personaPar.nombre = "Diego";
  console.log(`Hola gran señor ${personaPar.apellido} , ${personaPar.nombre}`);
}
//Ahí se ve cómo se modificó el persona.nombre que se cambió dentro de la función.
console.log(persona.nombre);

function despedida(parametro = "Chau bambino") {
  console.log("Se imprime el mensaje de despedida:" + parametro);
}

despedida("No vemo en Disney");
despedida();

function mensaje(...parametro) {
  console.log(parametro);
}

mensaje(
  "El rey ha muerto",
  123,
  false,
  true,
  false,
  "El rey era medio trolo ¿no?"
);

function suma(...nums) {
  return nums.reduce((a, b) => a + b);
}
let numerole=suma(4, 3, 2, 1,5,-1,4.3);
console.log(numerole);