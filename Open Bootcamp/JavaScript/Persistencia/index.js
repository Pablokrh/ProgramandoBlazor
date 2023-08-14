localStorage.setItem("Persona", JSON.stringify({nombre:"Lautaro", edad:36}))
console.log(JSON.parse(localStorage.getItem("Persona")))
localStorage.removeItem("Persona")

sessionStorage.setItem("Edad", 35)

document.cookie="nombreCookie=PabloCookie; expires=" 
+ new Date (2023,0,1).toUTCString();

document.cookie="nombreCaducidad=Nombre; expires=" 
+ new Date (2023,0,1).toUTCString()

console.log(document.cookie)
