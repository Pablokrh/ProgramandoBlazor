let signo="CAPRicornio";
let signoPosta="capricornio";

console.log(signoPosta===signo)
console.log(signoPosta.toLowerCase===signo.toLowerCase)

let str1="Hola, soy la cadena N1";
let str2="Yo, en cambio, soy la cadena N1";
console.log (str1.concat(". ",str2));

console.log (str1+ ". "+ str2);
console.log (`${str1} ${str2}`)

let str3="  Soy un string medio choto, con espacios al ppio y al final  ";
console.log(str3.length)
let str4=str3.trim();
console.log(str4);
console.log(str4.length)
//Están también el trimStart y el trimEnd.

console.log(str4.charAt(0));
console.log(str4[0]);

console.log(str4.indexOf("choto"));
//Devuelve la primera letra. Si no encuentra la palabra, devuelve un -1. Devuelve la primera vez que aparezca la instancia.
console.log(str4.lastIndexOf("choto"));



