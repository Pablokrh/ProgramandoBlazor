const parrafos = document.querySelectorAll(".parrafo");
const secciones = document.querySelectorAll(".seccion");
const papelera = document.querySelectorAll(".papelera");

parrafos.forEach((parrafo) => {
  parrafo.addEventListener("dragstart", (event) => {
    console.log("Estoy arrastrando el párrafo " + parrafo.innerText);
    parrafo.classList.add("dragging");
    event.dataTransfer.setData("id", parrafo.id);
  });
  parrafo.addEventListener("dragend", () => {
    console.log("He terminado de arrastrar");
    parrafo.classList.remove("dragging");
  });
});

secciones.forEach((seccion) => {
  seccion.addEventListener("dragover", () => {
    event.preventDefault();
    event.dataTransfer.dropEffect = "move";
    console.log("Dragover");
  });
  seccion.addEventListener("drop", (event) => {
    let id_parrafo = event.dataTransfer.getData("id");
    const parrafo = document.getElementById(id_parrafo);
    seccion.appendChild(parrafo);
  });
});

papelera.forEach((pap) => {
  pap.addEventListener("dragover", () => {
    event.preventDefault();
    event.dataTransfer.dropEffect = "move";
  });

  pap.addEventListener("drop", (event) => {
    let id_parrafo = event.dataTransfer.getData("id");
    event.preventDefault();
    const parrafo = document.getElementById(id_parrafo);
    parrafo.remove();
  });
});
