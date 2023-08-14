class Estudiante {
  listaAsignaturas = ["HTML ", "Css ", "JavaScript"];
  constructor(nombre) {
    this.nombre = nombre;
  }

  ObtenDatos(){
    return " "+ this.nombre +" "+ this.listaAsignaturas;
  }
}

const miEstudiante=new Estudiante("Pepe");
const miEstudiante2=new Estudiante("Ramón");
console.log(miEstudiante.ObtenDatos())
console.log(miEstudiante2.ObtenDatos())
