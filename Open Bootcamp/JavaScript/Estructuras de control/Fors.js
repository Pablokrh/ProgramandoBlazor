let i = 0;
for (i; i < 10; i++) {
  console.log(i);}

let lista = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

for (j = 0; j < lista.length; j++) {
  console.log(lista[j] * 2);}

for (const valor of lista) {
  console.log(valor * 3);}

lista.forEach((valor) => {
  console.log(valor);});

let persona = {
  nombre: "Pablo",
  edad: 35,
  isDeveloper: false,};

//for in. el nuevo y compli

for (let propiedad in persona) {
  console.log(persona[propiedad]);
}
