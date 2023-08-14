const pk=document.getElementById("formulario")
console.log(pk)

pk.addEventListener("submit", evento=>{
console.log(evento);
console.log("He funcado");
evento.preventDefault();
})