
// function describeAge(a) {
//     return a < 13 ? `You're a(n) kid` : a < 18 ? `You're a(n) teenager` : a < 65 ? `You're a(n) adult` : `You're a(n) elderly`
// }

function describeAge(age) {
    return "You're a(n) " + (age < 13 ? "kid" : age < 18 ? "teenager" : age < 65 ? "adult" : "elderly")
}

console.log(describeAge(10))
console.log(describeAge(15))
console.log(describeAge(50))
console.log(describeAge(500))