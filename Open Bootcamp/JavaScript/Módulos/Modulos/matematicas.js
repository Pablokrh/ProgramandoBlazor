function FactorialFunc(num) {
  let factorial = 1;
  for (let i = 1; i <= num; i++) {
    factorial *= i;
  }
  return factorial;
}

function Suma(num1, num2) {
  return num1 + num2;
}

module.exports={
    FactorialFunc,
    Suma
}
