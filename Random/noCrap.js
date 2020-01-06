let arr = ['crap', 'candy', 'stuff', 'crap', 'fruit', 'crap', 'meat', 'crap','milk']

function noCrap(x){
    let arr = []
    for(let i = 0; i<=x.length-1; i++){
        if(x[i]!=='crap'){
            arr.push(x[i])
        }
        console.log(x[i])
    }
    return arr
}

console.log(noCrap(arr))