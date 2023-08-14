/*
$(document0).ready(() =>{

})
*/
//o en su forma simplificada:
//Evento de eventos. Disparado al cargarse el documento html
$(() => {
//Evento disparado al tocar botón Hide
  $(".hide-btn").click(() => {
    $("h1").fadeOut();

  });
//Evento disparado al tocar botón Show  
  $(".show-btn").click(() => {
    $("h1").fadeIn();
  });

  $("li").click(()=>{
    $("h1").css({color:"red"})
  })

$("li").mouseenter((elem)=>{
    elem.target.style.color="violet"    
})
$("li").mouseleave((elem)=>{
    elem.target.style.color="black"    
})


});
