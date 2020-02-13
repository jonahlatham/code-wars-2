function skipTooMuchSugarDrinks(drinks) {
	return drinks.filter((e=>{
        if(e==='cola' || e==='fanta'){
            return false
        } else {
            return true
        }
    })
}

console.log(skipTooMuchSugarDrinks(["fanta", "cola", "water"]))