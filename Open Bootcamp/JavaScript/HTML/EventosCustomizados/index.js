const hTexto = document.getElementById("h-texto");

hTexto.addEventListener("cambioTexto", evento => {
    hTexto.innerText=evento.detail.texto
    hTexto.style.color=evento.detail.color
});

function cambiarTexto(nuevoTexto, color) {
  const evento = new CustomEvent("cambioTexto", {
    detail: {
      texto: nuevoTexto,
      color
    }
  })
  hTexto.dispatchEvent(evento)
}

