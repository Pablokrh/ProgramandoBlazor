const fechaHoy=new Date();
const fechaNacimiento=new Date(1988,0,9)
const esPosterior= (fechaHoy>fechaNacimiento);

const diaNacimiento=fechaNacimiento.getDate();
const mesNacimiento=fechaNacimiento.getMonth()+1;
const anioNacimiento=fechaNacimiento.getFullYear();
