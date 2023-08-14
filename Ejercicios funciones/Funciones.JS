//API API API SKYWALKER
fetch("https://swapi.dev/api/people/1/?format=json") 

    .then(function(response) {
        return response.json();
    })

   .then(function(data) {
    console.log(data);
    movieData.innerHTML ="<h2 class= 'alert alert-success'>" + data.name + "</h2>";
    //Acá se usan los datos obtenidos para cambiar el DOM
    //Cuidado con las "" y las ''.
    movieData.innerHTML+="<img src=https://i0.wp.com/wipy.tv/wp-content/uploads/2020/07/edad-de-luke-skywalker-en-las-trilogias-de-star-wars.jpg?w=1000&ssl=1/>";
   })
  
   // Como se ve, es el segundo then donde todo se retoca, lo demás queda igual.
   
   .catch(function(error){
    console.log(error);
   });
   

/* API API API API API API API API API API API API
//Primero se crea la función fetch y se le pasa como argumento
//la URL de la Api
fetch("https://swapi.dev/api/people/1/?format=json") 

//var URLDEAPI= "https://swapi.dev/api/people/1/?format=json";
//fetch (URLDEAPI) también podría hacerse de esta manera
    .then(function(response) {
        return response.json();
    })
    // toma la respuesta que le viene desde el servidor y solo recibe
    // la respuesta, convertida de JSON a formato objeto.
   .then(function(data) {
    console.log(data);
   })
   //Acá ya se recibe la info y se puede hacer el console.log
   .catch(function(error){
    console.log(error);
   });
    //esto se recomienda hacer, por si da algún error.
    //;;; recién al final poner el punto y coma ;;;
    ///Response, data y error son nombres estandarizados, podrían ser otros
    //response es la respuesta, que se tiene de la API

/*var user = {
    name: "Juana",
    lastName: "Rodriguez",
    Age:29,
    getInfo: function(lang){
        if (lang === "esp") {
            return "Hola, mi nombre es " + this.name + " " + this.lastName + " y tengo " + this.Age + " años de edad";
        }

        if (lang === "eng") {
            return "Hi, my name is " + this.name + " " + this.lastName + " and I have " + this.Age + " years old";
        }
    }
} 

console.log
console.log

var title=document.querySelector(".contenedorTitulo");
title.innerHTML= user.getInfo("eng");
// Es muy similar a lo anterior. En este caso se usa el método. O la función, dentro del objeto.
//Ahora cambia lo anterior para dar la chance de cambiar de idioma.







/*

var user = {
    name: "Juana",
    lastName: "Rodriguez",
    Age:29,
    getInfo: function(){
        return "Hola, mi nombre es " + this.name + " " + this.lastName + " y tengo " + this.Age + " años de edad";
    }
    }
var title=document.querySelector(".contenedorTitulo");
title.innerHTML= user.getInfo(); // Es muy similar a lo anterior. En este caso se usa el método. O la función, dentro del objeto.


var user = {
name: "Juana",
lastName: "Rodriguez",
Age:29,

}
console.log (user);

var title= document.querySelector (".contenedorTitulo");
title.innerHTML= "Bienvenida, " + user.name + " " + user.lastName;

var students = [
{name: "Ana Pérez", subject: "Javascript"},
{name: "Pablo Almóndiga", subject: "HTML y CSS"},
{name: "Tristán Suarez" , subject: "Phyton"}, //todo esto es casi un array.
]
var studentsListUl= document.querySelector ("#studentsList"); //captura la lista vacía creada en el HTML

for (var i=0; i<students.length; i++) {
    studentsListUl.innerHTML+= "<li>" + students[i].name + " está estudiando "+ students[i].subject + "<li>" ; // el += posibilita que cada nombre agregado no sobreescriba al anterior, sino que se acumulen, en la lista que se crea ya que se indica <li> </li>
} // Acá se repasa el "array" para mostrar la lista en pantalla.


/*for (var i=0; i<students.length; i++) {
    console.log (students[i]);
} Esto te imprime: {name: 'Ana Pérez', subject: 'Javascript'} de los 3 sujetos

for (var i=0; i<students.length; i++) {
    console.log (students[i].name);} //Acá solo te devuelve los nombres de los 3 sujetos.*/
    


 //Importante recordar de agregar los atributos Id y Name. Si no, algo podría romperse.
 //Creo que lo que se rompe es fieldNam=element.Name;



/*
Formulario 4: Auna ambas funciones en una sola
var username=document.querySelector("#username");
var password=document.querySelector("#password");

function validateValue (event) {
    var element = event.target;
    var fieldValue = element.value;
    var fieldName = element.name;
    if (fieldValue ==="") {
        alert ("El campo "+ fieldName + " es obligatorio");
    }
}

password.addEventListener("blur", validateValue);
username.addEventListener("blur" , validateValue);

var loginForm=document.querySelector("#loginForm");
function submitData (event) { 
   event.preventDefault(); //esto impide que se envíe, ya que al no haber backend se rompería
   // 
    console.log ("Vamos a enviar la información"); //luego esto lo borra
    var usernameValue= username.value;
    var passwordValue= password.value; //Crea estas variables sobre lo que generó antes.
    console.log (usernameValue);
    console.log(passwordValue);
    if (usernameValue==="" || passwordValue==="") {
        alert ("El username y/o la contraseña no fueron suministrados");
    }
    else {
        alert ("Tu información se está enviando");
    }
}
loginForm.addEventListener ("submit", submitData);


Formulario 3. Username+Password.
var username=document.querySelector("#username");
var password=document. querySelector("#password");
console.log(username);
console.log(password); 

username.addEventListener("blur", function(event) {
    var element=event.target;
    var fieldvalue= element.value;//de esta forma captura el valor del area escrita
    // lo que viene es: Si lo escrito en el area de texto es igual a un string vacío
    if(fieldvalue==="") {
        alert ("Este campo es obligatorio");
    }
})
//Ahora hace lo mismo con el password
password.addEventListener("blur", function(event) {
    var element=event.target;
    var fieldvalue= element.value;//de esta forma captura el valor del area escrita
    // lo que viene es: Si lo escrito en el area de texto es igual a un string vacío
    if(fieldvalue==="") {
        alert ("Este campo es obligatorio");
    }
 })


Formulario 2:
var username=document.querySelector("#username");
var password=document. querySelector("#password");
console.log(username);
console.log(password); 

username.addEventListener("blur", function(event) {
var element=event.target;
var fieldvalue= element.value;//de esta forma captura el valor del area escrita
// lo que viene es: Si lo escrito en el area de texto es igual a un string vacío
if(fieldvalue==="") {
alert ("Este campo es obligatorio");
}
})

Formulario 1:
var username=document.querySelector("#username");
var password=document. querySelector("#password");
console.log(username);
console.log(password); 

username.addEventListener("blur", function(event) {
var element=event.target;
var fieldvalue= element.value;//de esta forma captura el valor del area escrita
console.log(fieldvalue); //dese esta forma lo printea, cuando hace click fuera del campo del área escrita
})
Fin formulario

Acá uso la misma función para 3 elementos. Se pasan como argumento a través del (event). 
Hay que capturarlo normalmente; Usar el addEventListener normalmente;
Dentro de la función crear la variable element=event.target;
Lo hice desordenada para ver que se puede y queda bien.

var grana=document.querySelector("#A");
var taladro=document.querySelector("#B");
taladro.addEventListener("click", clickeate);
var pirata=document.querySelector("#C");
pirata.addEventListener("click", clickeate);

function clickeate (event) {
    var element = event.target;
    element.classList.toggle ("col-5");
}
grana.addEventListener("click", clickeate);


Forma 1:
var grana=document.querySelector(".lanus");
console.log(grana);

function clickSobreLanus () {
    console.log ("Hicimos click sobre un div");
}
grana.addEventListener("click", clickSobreLanus)

Forma 2:
grana.addEventListener("click", clickSobreLanus)
var grana=document.querySelector(".lanus");
console.log(grana);  
grana.addEventListener("click", function (){
console.log ("Hicimos click sobre un div"); }) Así va a aparecer ese msj en consola

var selectMonth=document.querySelector("#month");
var meses= ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];

for (var i = 0; i < meses.length; i++) {
    console.log(meses[i]); 
    selectMonth.innerHTML += "<option>" + meses[i] + "</option>";
    
}

var selectYear= document.querySelector("#year");
for (var x= 1900; x <=2022 ; x++) {
    console.log(selectYear);
    selectYear.innerHTML += "<option>" + x +"</option>";
    
}




var titulo = document.querySelector ("h1");
titulo.classList.toggle ("nuevo");
titulo.classList.toggle ("contenedorTitulo");
console.log (titulo.classList);

var meses= ["Enero", "Febrero", "Marzo", "Abril", "Mayo"];
console.log (meses);
console.log (meses[3]);
meses [5]= "Junio";
meses.push("Julio");
console.log (meses);

for (let index = 0; index < array.length; index++) {
    const element = array[index];
    
}

    

var titulo=document.querySelector ("h1");
console.log (titulo);
titulo.style.color="red";
titulo.style.textAlign="center";
titulo.style.backgroundColor="black";
titulo.style.padding="10px";
var titulo=document.querySelector ("h1");
console.log (titulo);
titulo.innerText= "Contengo tutti";
var titulo=document.querySelector("h1");
titulo.style.color="red";
console.log (titulo);

var casilla=document.querySelectorAll(".col-4");
console.log (casilla);


console.log (window);
var dia="martina";
function esFinDeSemana (dia) {
    if (dia =="sabado" ||dia =="domingo")
    {
        return true;
    }
    else if (dia !="lunes"&& dia != "martes" && dia != "miercoles" && dia != "jueves" && dia != "viernes" && dia!= "sabado" && dia!= "domingo") 
    {
        return "No es un día de la semana";
    }
    else
    {
        return false;
    }
}
console.log (esFinDeSemana(dia));
var dia="martes";
console.log (esFinDeSemana(dia));
var dia="sabado";
console.log (esFinDeSemana(dia));



function maximoDeDos (Num1 , Num2) {
    if (Num1>Num2) {
        return Num1;
    }
    else if (Num1<Num2){
        return Num2;
    }
    else {
        return "Los números son iguales";
    }
}

console.log (maximoDeDos(16, 16))

 //Esta es otra forma, mas a la mía
var Num1=12;
var Num2=16;

function maximoDeDos (Num1 , Num2) {
    if (Num1>Num2) {
        return Num1;
    }
    else if (Num1<Num2){
        return Num2;
    }
    else {
        return Num1;
    }
}

console.log (maximoDeDos(Num1, Num2))



var Num=20;
function esPar (Num) {
    Res= Num % 2;
    if (Res===1) {
    return false    
    }
    else {
        return true
    }
}
console.log (esPar(Num));

function EsParono (unNumero) {
    Res= unNumero % 2;
    if (Res===1) {
    return false    
    }
    else {
        return true
    }
}
console.log (EsParono(14));
console.log (EsParono(15));
console.log (EsParono(0));


var anioNacimiento=1988;
if (anioNacimiento>=1980 && anioNacimiento<1995){
    console.log("Sos un Millennial");
}
else{
    console.log ("Creo que no sos un Millennial");
}


var dia="sabado";

if(dia==="lunes"){
console.log ("Vamos a la playa");
}
else{
    console.log ("Vamos a trabajar tristes y con tendencias suicidas");
}




function double (number){
    return number*2;
}

var resultado_1=double (20);
console.log (resultado_1);
console.log (double(20)); //Esta segunda opción se puede hacer cuando no se necesita guardar el resultado de la función para posterior uso. Solo se la printea.

console.log ("¡¡Pablo lo hizo ehhh!!");

function printFullName (firstName, lastName){
    return("Tu nombre es "+ firstName+ " " +lastName);
}

console.log(printFullName ("María", "Juarez"));

function numeroAleatorio () {
    return Math.random () *100;
}
console.log (numeroAleatorio ());
console.log (numeroAleatorio ());
console.log (numeroAleatorio ())*/  