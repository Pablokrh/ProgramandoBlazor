const Persona = {
  nombre: "Gorka",
  edad: 34,
};

function ObtenDobleEdad(edad) {
  return edad * 2;
}

const dobleEdad = ObtenDobleEdad(Persona.edad);
console.log(dobleEdad);

let arrayNums = [];

function ObtenArray(edad) {
  for (let i = 0; i < 10; i++) {
    let numero = Persona.edad + i;
    console.log(numero);
    arrayNums = { ...arrayNums, numero };
  }
  return arrayNums
}
const array=ObtenArray(Persona.edad)
console.log(array);
