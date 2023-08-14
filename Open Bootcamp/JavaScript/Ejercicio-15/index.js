const nombre="Pablo"
const apellido="Krojzl"

class Persona{
    constructor(nombre, apellido){
        this.apellido=apellido;
        this.nombre=nombre
    }
}

const persona=new Persona("Pablo","Krojzl")

localStorage.setItem("Persona", JSON.stringify({Nombre:persona.nombre, Apellido:persona.apellido}))
sessionStorage.setItem("Persona", JSON.stringify({Nombre:persona.nombre, Apellido:persona.apellido}))
document.cookie= "ObjetoCookie="+JSON.stringify({Nombre:persona.nombre, Apellido:persona.apellido})+ ";max-age=120"