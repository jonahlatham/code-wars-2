// USE RECURSION

function countingValleys(s) {
    let str = s.split('')
    return str.reduce((r, e, i) => {
        if (e === 'U') {
            r += 1
        } else if (e === 'D') {
            r -= 1
        }
        return r
    }, 0)
}

console.log(countingValleys('UFFDDFDUDFUFU'))