const lista = [1.4, 1.6, 2, 2.4, 3.6, 4, 6, 7, 8, 9];
let num=0;

var i = 0;
for (i = 0; i < lista.length; i++) {
  if (lista[i] > 5) {
    break;
  }
  num+=lista[i];

  console.log(lista[i]);

}
console.log("Salí del bucle, cuando el valor de lista fue : " + lista[i]);
console.log(num);

for (i = 0; i < lista.length; i++) {
  if (lista[i] == 2.4) {
    continue;
  }
  console.log(lista[i]);
}
