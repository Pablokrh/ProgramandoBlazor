const enviar = document.querySelector(".btn");
enviar.addEventListener("click", () => {
  const email = document.getElementById("email");
  const nombre = document.getElementById("name");
  const mensaje = document.getElementById("txtarea");

  if (email.value != "" && nombre.value != "" && mensaje.value != "") {
    alert("Los datos han sido ingresados correctamente");
  } else {
    const listaErrores = [];
    listaErrores.push("Por favor, completar los siguientes campos: ");
    if (email.value == "") listaErrores.push("Email ");
    if (nombre.value == "") listaErrores.push("Nombre ");
    if (mensaje.value == "") listaErrores.push("Mensaje ");
    alert(listaErrores);
  }
});
