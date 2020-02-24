let array = [1, 2, 3, 4, 5, 6]
let array2 = [4, 6, 7, 8, 3]

const sevenBoom = (arr) => arr.join("").indexOf('7') >= 0 ? "Boom!" : "there is no 7 in the array";

console.log(sevenBoom(array))
console.log(sevenBoom(array2))