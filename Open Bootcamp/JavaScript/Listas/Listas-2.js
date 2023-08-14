//Unir 2 listas: concat.

let lista1=[1,3,5,7,9];
let lista2=[2,4,6,8,10];

let listaUnida=lista1.concat(lista2);
console.log(listaUnida);
listaUnida.sort();
console.log(listaUnida);

//Unir listas con factor de propagación.
const lista4=[...lista1, ...lista2];
console.log(lista4);


//Obtener lista a partir de otra con slice
//Se le indica inicio y final

let fragmentoLista= lista4.slice(0,5);
console.log(fragmentoLista);