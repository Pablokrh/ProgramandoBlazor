const array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
//Este método devolvería si todos los valores de la lista son números o no.
const resultado = array.every((valor) => {
  if (typeof valor === "number") return true;
  else return false;
});
console.log(resultado);

const arr1 = [1, 2, 3, 4];
const arr2 = [1, 2, 3, 4];
console.log(arr1 == arr2);


const comparaArrays = (array_1, array_2) => {
  if (array_1.length != array_2.length) return false;
  const res = array_1.every((valor, i) => {
    if (valor === array_2[i]) return true;
    else return false;
  });
  return res;
};
/*Primero chequea que las 2 funciones tengan el mismo largo
Después se fija si cada elemento del array 1 se corresponde con un valor del array 2.*/
console.log(comparaArrays(arr1,arr2));
