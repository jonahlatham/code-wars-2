function diffMaxMin(arr) {
    let sortedArr = arr.sort((a, b) => { return a - b })
    return sortedArr[arr.length - 1] - sortedArr[0]
}

console.log(diffMaxMin([10, 4, 1, 4, -10, -50, 32, 21]))