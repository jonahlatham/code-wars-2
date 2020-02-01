function addUpTo(n) {
    let num = 0
    for (let i = 0; i <= n; i++) {
        num += i
    }
    return num
}

console.log(addUpTo(10))