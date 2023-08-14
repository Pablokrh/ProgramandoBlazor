if (true) {
  console.log("es verdadero");
}
if (false) {
  console.log("es verdadero");
} else {
  console.log("no es verdadero");
}

let saldo = 50;
let efectivo = 20;
estaLluvioso = true;

if (efectivo < saldo) {
  console.log("Puedes sacar dinero");
} else {
  console.log("No puedes sacar dinero");
}

if (efectivo < saldo && estaLluvioso == false) {
  console.log("Puedes sacar dinero");
} else if (efectivo < saldo && estaLluvioso == true) {
  console.log("Puedes sacar dinero, solo si tienes huevos");
} else {
  console.log("No puedes sacar dinero");
}

let nota = 3;

switch (nota) {
  case 2:
    console.log("Felicidades, has obtenido una buena nota");
    break;
  case 3:
    console.log("Una verdadera deshonra, para vos, tu familia, y la Nación");
    break;
  case 10:
    console.log(
      "Eres un verdadero ejemplo, especialmente para toda la mamerteada"
    );
  default:
    console.log(
      "No tuve tiempo/ganas de ser muy explícito, mas vale que te haya ido bien"
    );
    break;
}


