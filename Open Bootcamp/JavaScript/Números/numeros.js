let num1=0.2;
let num2=2.3;

console.log(Math.round((num1+num2)*100)/100);

let num3=4.3;

let sum=num3+num2;

console.log(sum);

let resta=num2-num3;
console.log(resta);

let division=num3/num2;
console.log(division);

let multiplo=num2*num3;
console.log(multiplo);
let stringifico=multiplo.toString()
console.log(stringifico);
console.log(typeof(stringifico));

console.log(multiplo.toFixed(0));
console.log(multiplo.toFixed(1));
console.log(multiplo.toFixed(2));
console.log(multiplo.toFixed(3));
console.log(multiplo.toFixed(4));
//Muestra X cantidad de decimales. atenti que lo convierte a string.

console.log(multiplo.toPrecision(5))
//esto devuelve la cantidad de números que te devuelve.


let num5=parseInt(stringifico);  
let num7=parseFloat(stringifico);    
console.log(num7);
console.log(num5);
console.log(typeof(num5));

let numRaro=new Number(6);
//rara vez se utiliza esto.
//isNana Is not a number

console.log (isNaN(stringifico));
let adios="No vemo en Diney";
console.log (isNaN(adios));
console.log(stringifico+num5)
console.log(Number(stringifico)+num5)
//Acá se castea el string y se hace la suma correctamente.


//Números hexadecimales. Empiezan siempre con "0x". No existen los decimales.
let numHex='0x3ab57';
console.log(parseInt(numHex));

let minPrecision=Number.EPSILON;
let max=Number.MAX_VALUE;
let min=Number.MIN_VALUE;

console.log(minPrecision);
console.log(max);
console.log(min);
console.log(125**5);
//Así se eleva al cuadrado, con **