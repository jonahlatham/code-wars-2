function isDivisible(n, x, y) {
    if(n%x===0 && x%y===0){
        return true
    } else {
        return false
    }
}
console.log(isDivisible(100, 50, 2))