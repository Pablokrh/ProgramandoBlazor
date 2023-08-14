const array = [1, 3, 5, 7, 9];

const array2 = array.map(function (valor) {
  return valor * 2;
});

console.log(array2);
//Esta es una opción, pero no es recomendable, ni es una función flecha.

const array3 = array.map((valor) => valor * 2);
//Esa si que es una función de tipo flecha
console.log(array3);



//Otra forma de usar funciones flecha es guardandolas en una variable:
const duplicaValor= valor=>(valor+1)*2;
const array4=array.map(duplicaValor);
console.log(array4);
