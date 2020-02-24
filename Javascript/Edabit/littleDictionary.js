function dictionary(initial, words) {
    let loopedWords = words.map((e) => {
        if(e.slice(0,initial.length).includes(initial)){
            return e
        } else {
            return false
        }
    })
    return loopedWords.filter((e)=>{
        if(e!==false){
            return true
        }
    })
}

console.log(dictionary("bu", ["button", "breakfast", "border"]))  //["button"]
console.log(dictionary("tri", ["triplet", "tries", "trip", "piano", "tree"]))  //["triplet", "tries", trip"]
console.log(dictionary("beau", ["pastry", "delicious", "name", "boring"]))  //[]