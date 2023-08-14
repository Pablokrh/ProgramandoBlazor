//Listas. Lo da como sinónimo da array o vector.
const lista1 = [1, "hola", true, undefined];

const lista2 = new Array(1, "hola", true, undefined);
console.log(lista2);

const lista3 = new Array(3); //Ahí ese 3 habla de 3 espacios en la lista. Vacíos por ahora.
console.log(lista3);
lista3[0] = "Banfield sos de la 'B'";
console.log(lista3);

//objetos
const movil = {
  altura: 10,
  anchura: 5,
  marca: "Xiaomi",
  isWhite: false,
  contactos: ["Gorka", "Martín", "Raúl"],
  tarjeta: {
    marca: "Sandisk",
    almacenamiento: 32,
  },
};
console.log(movil.tarjeta.marca);
console.log(movil.tarjeta);
console.log(movil.isWhite);
movil.anio=2022;
console.log(movil.anio);

//Fechas
const ahora= new Date();
console.log(ahora);

const momento=new Date("march 25 2020");
console.log(momento);

const momento2=new Date(2022, 0 , 15);
console.log(momento2);

const dia=ahora.getDate();
const mes=ahora.getMonth();
const año=ahora.getFullYear();
console.log(dia+"/"+ mes+"/"+ año);
