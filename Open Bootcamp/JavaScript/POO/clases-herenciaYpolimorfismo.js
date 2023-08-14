class Persona {
  constructor(nombre, edad) {
    this.nombre = nombre;
    this.edad = edad;
  }
  Saludo() {
    console.log(`Hola qué tal, mi nombre es ${this.nombre}, tengo ${this.edad}
     `);
  }
}

class Desarrollador extends Persona {
  constructor(nombre, edad, lenguaje) {
    super(nombre, edad);
    this.lenguaje = lenguaje;
  }
  //Así se hace el override del método padre Saludo()... De esta forma se genera polimorfismo
  Saludo() {
    super.Saludo()
    console.log(" y soy desarrollador de "+this.lenguaje)
  }
}
const nuevoDev = new Desarrollador("Pablo", 35, "C#");
console.log(nuevoDev);
nuevoDev.Saludo();
