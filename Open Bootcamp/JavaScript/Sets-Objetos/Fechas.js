const fecha=new Date();
console.log(fecha);

const fecha2=new Date(1987,10);
console.log(fecha2);

const fecha3=new Date(1987,10,20,18);
console.log(fecha3);

const fecha4=new Date("13 October,1969");
const fecha5=new Date("October 14,1969, 14:32:32");
console.log(fecha4);
console.log(fecha5);

console.log(fecha<fecha5);
console.log(fecha>fecha5);

const fecha6=new Date("13 October,1969");
//Esta forma de comparar es fallida:
console.log(fecha4===fecha6);
//Hay que obtener los milisegundos.
console.log(fecha4.getTime()==fecha6.getTime());


console.log(fecha5.getDate());
console.log(fecha5.getMonth()+1);
console.log(fecha5.getFullYear());
//El +1 es porque arranca con el 0: enero es 0


//para mostrar de forma linda la fecha:
console.log(fecha2.toLocaleDateString("en-GB"))

//Esta es mi groncheada
console.log(fecha5.getDate()+"/"+(fecha5.getMonth()+1)+"/"+fecha5.getFullYear());
