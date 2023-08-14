//Sets
const array = [1, 2, 3, 4, 5, 4, 2, 2.5, 7, 6, { id: 4 }, { id: 4 }];

const mySet = new Set(array);

console.log(array);

console.log(mySet);

mySet.add(9);
mySet.add(9);

mySet.delete(3);

console.log(mySet.has(1));
console.log(mySet);
console.log(mySet.size);

mySet.forEach((valor) => {
  console.log(valor);
});

const array2 = [...mySet];
//Reconvertirlo a array

//--------------------------OBJETOS---------------------------

const obj = {
  id: 4,
  librosFavoritos: "El gato que odia a la muerte",
  ratasCazadas: 15,
  vidasGastadas: 3,
  "5-patas": true, //*
};

//acceder a sus valores
console.log(obj.id);
obj.vidasGastadas=4;

//Copiar un objeto;
//Haciendo obj2=obj1 se copia la dirección de memoria... Si luego se cambiase el obj1, también
//cambiaría el objeto2.


obj2= {...obj};
obj3=obj;
obj.id=6;
console.log(obj2);
console.log(obj3);

//Ordenar listas de objetos.

const listaPeliculas=[
    {titulo:"Lo que el viento se llevó", anyo:1939},
    {titulo:"Star Wars", anyo:1976},
    {titulo:"El gato odiador de giles", anyo:2019},
    {titulo: "Llanero solitario", anyo:1932},
    {titulo:"titanic", anyo:2001},
  ]

  console.log(listaPeliculas);

  listaPeliculas.sort((a,b)=> a.anyo-b.anyo)
  console.log(listaPeliculas)
