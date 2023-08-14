//Ver expresiones regulares  en https://regexr.com

let textoLargo=`Desde las 17, organizaciones sociales y personas de distintos puntos de 
Chaco y otras provincias comenzaron a concentrarse en la plaza 25 de Mayo con carteles que 
rezaban "¿Dónde está Cecilia?" y "Basta de femicidios". La consigna fue llevar la camiseta 
de Argentina con una estrella rosa, globos u otros elementos del color favorito de la víctima.`

console.log (textoLargo.match(/la/g));

console.log (textoLargo.includes("femicidi"));
console.log (textoLargo.includes("Hijos de puta"));
console.log (textoLargo.includes("Basta de"));

console.log(textoLargo.startsWith("Desde"))
console.log(textoLargo.startsWith("Cecilia"))
console.log(textoLargo.endsWith("victima."))
console.log(textoLargo.endsWith("víctima."))

