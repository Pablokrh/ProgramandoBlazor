var a = 1;
console.log(a);
const k = "hola, soy constante";

a = 3;
console.log(a);

console.log(k);

let j = 10;
let h = 11;
let i = j + h + a;
console.log(i);

let variableLet = "Hola, soy Let fuera del For";

for (var p = 0; p < 3; p++) {
  let variableLet = " Hola, soy el Let interno al for";
}
console.log(variableLet);

console.log(typeof variableLet);
console.log(typeof h);

// Segunda parte de notación de JS

const array = [1, 2, 3, 4];
console.log(array[2]);
