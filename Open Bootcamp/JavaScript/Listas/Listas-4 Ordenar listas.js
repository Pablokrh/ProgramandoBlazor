const array = [
  "Zaragoza",
  1,
  46,
  23,
  "Barcelona",
  5,
  12,
  "Albacete",
  55,
  5,
  32,
];
const array2 = [1, 46, 23, 5, 12, 55, 5, 32];

array.sort((a, b) => {
  if (a < b) {
    return -1;
  } else if (a > b) {
    return 1;
  } else return 0;
});
console.log(array);

array2.sort((a, b) => a - b);
console.log(array2);

array2.sort((a, b) => b - a);
console.log(array2);

const listaObjetos = [
  { nombre: "Pablo", edad: 35 },
  { nombre: "Lucía", edad: 33 },
  { nombre: "Paco", edad: 27 },
  { nombre: "Arantxa", edad: 11 },
];
/*
listaObjetos.sort((a, b) => {
  if (a.edad < b.edad) return -1;
  else if (a.edad > b.edad) return 1;
  else return 0;
});
*/

listaObjetos.sort((a, b) =>a.edad-b.edad);
console.log(listaObjetos);
