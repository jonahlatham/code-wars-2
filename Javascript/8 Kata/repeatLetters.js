function repeate(x) {
  return x
    .split("")
    .map(e => {
      return e + e;
    })
    .join("");
}

console.log(repeate("string"));
