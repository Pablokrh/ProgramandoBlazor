let numero = 1;
let contador = 1;

while (contador <= 20) {
  numero = numero * contador;
  contador++;
  if(contador<=10){
    break;
  }
}

console.log(numero);
