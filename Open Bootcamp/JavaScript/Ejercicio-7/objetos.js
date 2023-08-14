const yo = {
  nombre: "Pablo",
  apellido: "Krojzl",
  edad: 35,
  altura: 190,
  eresDesarrollador: false,
};

const edad = yo.edad;

const otro = {
  nombre: "Nicolás",
  apellido: "Ortega",
  edad: 37,
  altura: 175,
  eresDesarrollador: false,
};
const otro2 = {
  nombre: "José Miguel",
  apellido: "Funes",
  edad: 33,
  altura: 178,
  eresDesarrollador: true,
};

const listaSujetos=[yo, otro,otro2];

listaSujetos.sort((a,b)=>b.edad-a.edad);

