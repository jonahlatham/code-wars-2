function index( array, n ) {
    return (array.length) > n ? Math.pow(array[n], n) : -1;
}

console.log(index([1, 2, 3, 4], 2))