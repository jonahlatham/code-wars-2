let arr = ['nut', 'candy', 'nut', 'fruit', 'nut', 'meat', 'nut','milk']

function noNuts(a){
return a.filter((e)=>{
    if(e==='nut'){
        return false
    } else {
        return true
    }
})
}

console.log(noNuts(arr))