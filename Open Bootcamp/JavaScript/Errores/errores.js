const miFuncion = (val) => {
  if (typeof val === "number") {
    return val * 2;
  } else {
    throw new Error ("El valor debe ser de tipo numérico");
  }}

const num=21;

try
    //Parte del código que puede fallar
    {
console.log("Está ejecutándose el código");
const doble=miFuncion(num);
console.log(doble);
}
catch (e) 
//Esto se ejecuta en caso de fallar el try
{
console.error(Error+"Todos troles: "+ e);

}
finally{
    console.log("El código inexorablemente ejecutará esto...")
}


