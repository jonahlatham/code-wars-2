function wordLengths(arr) {
	return arr.reduce((r,e)=>{
        r.push(e.length)
        return r
    },[])
}

console.log(wordLengths(["hello", "world"]))
console.log(wordLengths(["Halloween", "Thanksgiving", "Christmas"]))