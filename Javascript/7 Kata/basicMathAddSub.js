function calculate(str) {
    return eval(str.split("plus").join("+").split("minus").join("-")).toString();
}

console.log(calculate("1plus2plus3plus4"))
console.log(calculate('1minus2minus3minus4'))
console.log(calculate('1plus2plus3minus4'))