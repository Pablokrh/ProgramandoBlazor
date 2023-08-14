const logger = require(`./logger/log`);

function NumerosPares(num) {
  if (num % 2 == 0) {
    return true;
  } else {
    throw new Error("El número ingresado no es par");
  }
}

try {
  const esPar = NumerosPares(5);
  console.log(esPar);
} catch (e) {
    console.log(Error+e)
  logger.error(Date());
}
