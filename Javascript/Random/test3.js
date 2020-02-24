function test3(x) {
    if (x.toString() === x) {
        return 'String'
    } else {
        return 'This is not a string...'
    }
}

console.log(test3('string'))
console.log(test3(5))