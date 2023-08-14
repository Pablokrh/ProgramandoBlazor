let librosFavoritos=["El monje que vendió su Ferrari", "El poder del ayer", "Morite que te mato"];

let str="Hola soy un string";
console.log(str.length);

let slicestr=str.slice(0,8);
console.log(slicestr);

let slicestr2=str.substring(0,8);
console.log(slicestr2);

let slicestr3=str.substr(5,10);
console.log(slicestr3);
//Acá no se pasa el ppio y el fin, sino el ppio y el largo. Está cayendo en desuso.

let cadena="Hola, mi nombre es Pablo";

let cadena2= cadena.replace("Pablo", "Villariño");
console.log(cadena2);

let textoLargo=`Desde las 17, organizaciones sociales y personas de distintos puntos de 
Chaco y otras provincias comenzaron a concentrarse en la plaza 25 de Mayo con carteles que 
rezaban "¿Dónde está Cecilia?" y "Basta de femicidios". La consigna fue llevar la camiseta 
de Argentina con una estrella rosa, globos u otros elementos del color favorito de la víctima.`

console.log(textoLargo.replace("la","le"));
//Solo reemplaza la primera vez que aparece "la" (en este caso decía "las");
console.log(textoLargo.replace(/la/g,"le"));
//Acá utiliza una expresión regular para capturar todas las veces que aparece, salvo que tenga mayúscula.

