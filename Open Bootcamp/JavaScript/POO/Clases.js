class Persona {
  nombre;
  edad;
  esDesarrollador;
  constructor(nombre, edad, esDesarrollador) {
    this.nombre = nombre;
    this.edad = edad;
    this.esDesarrollador = esDesarrollador;
  }
  Saludo() {
    console.log(`Hola qué tal, mi nombre es ${this.nombre}, tengo ${this.edad}
     y es ${this.esDesarrollador} que yo sea desarrollador`);
  }
}
const nuevaPersona=new Persona("Laucha",36,false);
nuevaPersona.Saludo();

console.log(nuevaPersona instanceof Persona);