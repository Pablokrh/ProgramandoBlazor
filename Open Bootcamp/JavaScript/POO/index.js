const Persona = {
  nombre: "Pablo",
  edad: 35,
  esDesarrollador: false,
  Saludo: function () {
    console.log("Hola");
  },
};
console.log(Persona);

//Factory function:
const creaPersona = (nombre, edad, esDesarrollador) => {
  return {
    nombre,
    //antes ponía nombre:nombre, y así con todas las variablaes. Es lo mismo.
    edad,
    esDesarrollador,
    Saludo: function () {
      console.log("hola ¿qué tal?");
    },
  };
};

const pepito=creaPersona("Pepito",43,false);
console.log(pepito);
pepito.Saludo();