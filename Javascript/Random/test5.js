function reverseIt(x) {
    if (x.toString() !== x) {
        return x.sort((a, b) => { return b - a })
    } else {
        return x.split('').reverse()
    }
}

console.log(reverseIt('hello'))
console.log(reverseIt([1, 2, 3, 4, 5, 10]))