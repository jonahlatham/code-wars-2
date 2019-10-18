function hurdleJump(hurdles, jumpHeight) {
    let newHurds = hurdles.sort((a, b) => { return a - b })
    if (newHurds[newHurds.length - 1] > jumpHeight && hurdles !== []) {
        return false
    } else {
        return true
    }
}

console.log(hurdleJump([1, 2, 3, 4, 5, 6], 8))
console.log(hurdleJump([1, 2, 3, 4, 5], 5))
console.log(hurdleJump([5, 5, 3, 4, 5], 3))
console.log(hurdleJump([5, 4, 5, 6], 10))
console.log(hurdleJump([1, 2, 1], 1))
console.log(hurdleJump([], 4))