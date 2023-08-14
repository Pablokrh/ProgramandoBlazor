class Persona {  
    #nombre;
    #edad;
    _esDesarrollador;
  constructor(nombre, edad, esDesarrollador) {
    this.#nombre = nombre;
    this.#edad = edad;
    this._esDesarrollador = esDesarrollador;
  }
  Saludo() {
    console.log(`Hola qué tal, mi nombre es ${this.#nombre}, tengo ${this.#edad}
     y es ${this._esDesarrollador} que yo sea desarrollador`);
  }

  SetEdad(nuevaEdad){
    this.#edad=nuevaEdad;
  }
  ObtenNombre(){
    return this.#nombre;
  }
}
nuevaPersona.SetEdad(36)

const nuevaPersona=new Persona("Laucha",36,false);
nuevaPersona.Saludo();
console.log(nuevaPersona.edad);
console.log(nuevaPersona.ObtenNombre());

