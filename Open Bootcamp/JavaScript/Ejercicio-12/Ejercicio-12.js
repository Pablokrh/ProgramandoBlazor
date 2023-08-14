let ListaFibonacci = [];
let num1 = 0;
let num2 = 1;
function Fibonacci(cantidad) {
  for (let i = 0; i < cantidad; i++) {
    ListaFibonacci.push(num2);
    let aux = num2;
    num2 += num1;
    num1 = aux;
  }
  return ListaFibonacci;
}

console.log(Fibonacci(6));
