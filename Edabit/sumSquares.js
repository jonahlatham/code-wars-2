function squaresSum(n) {
    let arr = []
    for (let i = 1; i <= n; i++) {
        arr.push(i)
    }
    let man = arr.reduce((r, e) => {
        r.push(Math.pow(e, 2))
        return r
    }, [])
    return man.reduce((r, e) => {
        return r += e
    }, 0)
}

console.log(squaresSum(3))
console.log(squaresSum(5))