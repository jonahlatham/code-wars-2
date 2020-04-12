function flattenIt(arr){
    return arr.join('|')
}

console.log(flattenIt([[[1,2],3],[1,[2,3]],[[1,2],3]]))