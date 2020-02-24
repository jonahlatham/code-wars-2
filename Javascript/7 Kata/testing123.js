let number = function (array) {
    return array.reduce((r, e, i) => {
        r.push(`${i + 1}: ${e}`)
        return r
    }, [])
}
 
console.log(number(["a", "b", "c"]))