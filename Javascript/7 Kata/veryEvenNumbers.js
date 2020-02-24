function isVeryEvenNumber(n) {
    return !n-- || n % 9 % 2 === 1;
  }

console.log(isVeryEvenNumber(0))
console.log(isVeryEvenNumber(4))
console.log(isVeryEvenNumber(12))
console.log(isVeryEvenNumber(222))
console.log(isVeryEvenNumber(45))
console.log(isVeryEvenNumber(4554))
console.log(isVeryEvenNumber(46666666688898989022))