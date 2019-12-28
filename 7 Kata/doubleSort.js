

function dbSort(a) {
    let arr1 = []
    let arr2 = []
    let loops = a.map((e) => {
        if (e === Number(e)) {
            arr1.push(e)
            arr1.sort((a, b) => { return a - b })
        } else {
            arr2.push(e)
            arr2.sort((a, b) => { return a - b })
        }
    }) 
    return arr1.concat(arr2)
}

console.log(dbSort([6, 2, 3, 4, 5]))
console.log(dbSort([14, 32, 3, 5, 5]))
console.log(dbSort(["Banana", "Orange", "Apple", "Mango", 0, 2, 2]))
console.log(dbSort(["C", "W", "W", "W", 1, 2, 0]))