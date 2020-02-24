function minMinMax(array) {
    const sortedArray = [...new Set(array.sort((a, b) => a - b))];
    console.log(sortedArray)
    const smallNotThere = sortedArray.reduce((r, e, i, a) => {
        if (r > e + 1 && e + 1 !== a[i + 1]) {
            r = e + 1;
        }
        return r
    }, sortedArray[sortedArray.length - 1])
    return [sortedArray[0], smallNotThere, sortedArray[sortedArray.length - 1]]
}
console.log(minMinMax([-1, 4, 5, -23, 24])); //[-23, -22, 24]
console.log(minMinMax([1, 3, -3, -2, 8, -1])); //[-3, 0, 8]
console.log(minMinMax([2, -4, 8, -5, 9, 7])); // [-5, -3, 9]