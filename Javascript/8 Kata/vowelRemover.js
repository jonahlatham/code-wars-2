function vowelRemover(x) {
  return x.split("").filter(e => {
    if (e === "a" || e === "e" || e === "i" || e === "o" || e === "u") {
      return false
    } else {
      return true
    }
  }).join('');
}

console.log(vowelRemover("helloworld"));
console.log(vowelRemover("codewars"));
console.log(vowelRemover("goodbye"));
