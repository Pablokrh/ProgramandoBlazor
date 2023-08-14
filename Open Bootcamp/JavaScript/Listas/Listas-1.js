let soyLista=[2,4,6,8,10];
let soyLista2=new Array(1,2,3,4,5,6,7,8,9);
let altura=1.91;
let soyLista3=["Pablo",35, 'K', 87.6, altura];

soyLista3[5]="Pino";
console.log(soyLista3[5]);

//Añade al final.
soyLista3.push("Nuestro héroe");
console.log(soyLista3[6]);

//Elimina valores:
soyLista3.pop(soyLista3[5]);
console.log(soyLista3[6]);

console.log(soyLista3[0]);
soyLista3.shift();
console.log(soyLista3[0]);


//Añade al ppio de la lista:
soyLista3.unshift("Clarividencia");
console.log(soyLista3[0])


//Método mágico, para eliminar, modificar y agregar:
//SPLICE
const array=[1,2,3,4,5];
array.splice(2,1);
//El primer número ubica en el array, el segundo indica cuantos elementos eliminar.
console.log(array);

//Agrega, con un valor intermedio de 0
array.splice(3,0,"Cuartetas");
console.log(array);

//Modifica, con un valor intermedio de 1

array.splice(2,1,4.5);
console.log(array);



for (const iterator of soyLista3) {
    console.log(soyLista3[iterator]);
}

