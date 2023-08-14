const array = [1, 2, 3, false, "hola", true, "chau", false, true];

//Forma tradicional. Dice que quedó medio vieja.
for (let index = 0; index < array.length; index++) {
  console.log(array[index]);
}

//Metodo forOf, mi ForEach
for (const iterator of array) {
  console.log(array[iterator]);
}

//Reivindica el método foreach este, propio de Js.

array.forEach((valor) => {
  console.log(valor);
});

//Búsquedas
const variable = array.find((valor) => {
  if (valor == true) {
    return true;
  }
});

console.log(variable);

const listaObjetos = [
  { nombre: "Pablo", edad: 35 },
  { nombre: "Lucía", edad: 33 },
  { nombre: "Paco", edad: 27 },
  { nombre: "Arantxa", edad: 11 },
];

const objeto = listaObjetos.find(o => {
  if (o.nombre === "Pablo") {
    return true;
  }
});
console.log(objeto.edad);
