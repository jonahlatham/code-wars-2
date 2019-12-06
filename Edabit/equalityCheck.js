function checkEquality(a, b) {
    return typeof a === typeof b ? true :  false
}

console.log(checkEquality(1,  1))
console.log(checkEquality(NaN, NaN))
console.log(checkEquality(true, String))
console.log(checkEquality('string', String))
console.log(checkEquality(null, undefined))