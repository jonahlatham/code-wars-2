function average(arr){
    return arr.reduce((r,e,i)=>{
        r+=e
        return r/(i+1)
    })
}