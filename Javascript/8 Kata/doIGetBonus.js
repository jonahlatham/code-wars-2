function bonus(sal, bon) {
    if (bon === true) {
        return sal * 10
    } else {
        return sal
    }
}

console.log(bonus(10, true))
console.log(bonus(100, false))