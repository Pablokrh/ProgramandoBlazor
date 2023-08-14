function DevuelveTrue() {
  return true;
}
const resultado = DevuelveTrue();

function* ParesAutomáticos() {
  let par = 0;

  while (true) {
    par += 2;
    yield par;
  }
}

const num = ParesAutomáticos();

console.log(num.next().value);
console.log(num.next().value);
console.log(num.next().value);

console.log(resultado);
