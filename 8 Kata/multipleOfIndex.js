function multipleOfIndex(array) {
    return array.filter((e, i) => {
        if (e % i === 0) {
            return true
        }
    })
}

console.log(multipleOfIndex([22, -6, 32, 82, 9, 25])) // [-6,32,25]