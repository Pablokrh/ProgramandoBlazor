function myAsinc() {
  //Llama a una BBDD
  //Puede demorar mucho o incluso podría a tirar algún error
}

const miPromesa = new Promise((resolve, reject) => {
    const i= Math.floor(Math.random()*2);
  if (i!==0) {
    resolve();
  } else {
    reject();
  }
});

miPromesa
    .then(() => console.log("Se ha ejecutado de forma correcta"))
    .catch(()=> console.log("Error"))
    .finally(()=>console.log("Yo me ejecuto en todo caso, papá!!"))



