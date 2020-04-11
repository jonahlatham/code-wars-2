function flattenIt(arr){
    return arr.join('|').join('')
}

console.log(flattenIt([[1,2,3],[1,2,3],[1,2,3]]))