function* generaId() {
  let id = 0;
  while (true) {
    id++;
    if (id === 5) {
      return id;
    }
    yield id;
  }
}

const gen=generaId();

console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next())
console.log(gen.next())
