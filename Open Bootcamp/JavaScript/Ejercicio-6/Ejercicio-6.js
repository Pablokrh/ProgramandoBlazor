let listaCompras = ["Harina", "Azúcar", "Sal", "Manteca", "Leche"];
listaCompras.push("Aceite de girasol");
listaCompras.pop();

let peliculasFavoritas = [
  { titulo: "Match Point", director: "Woody Allen", fecha: 2005 },
  { titulo: "Star Wars. La amenaza fantasma",director: "George Lucas",fecha: 1999},
  { titulo: "Nueve Reinas", director: "Fabián Bielinsky", fecha: 2000 },
];

let peliculaspost2010 = peliculasFavoritas.filter(
  (valor) => valor.fecha >= 2010);
let directores = peliculasFavoritas.map((valor) => valor.director);
let titulos = peliculasFavoritas.map((v) => v.titulo);
let concat1 = directores.concat(titulos);
let concat2 = [...directores, ...titulos];
