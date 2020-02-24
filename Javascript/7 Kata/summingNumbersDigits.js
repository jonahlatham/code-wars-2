function sumDigits(number) {
    return Math.abs(number).toString().split('').reduce(function (a, b) { return +a + +b }, 0);
}

console.log(sumDigits(74))
console.log(sumDigits(-55))
console.log(sumDigits(74))
