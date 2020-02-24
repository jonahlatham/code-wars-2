function getSum(arr){
    return arr.reduce((r,e)=>{
        r+=e
        return r
    },0)
}