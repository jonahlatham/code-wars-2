function triathlon(x){
    if(x===0){
        return 'Starting Line... Good Luck!'
    } else if(x<=2.4){
        return 'Swim'
    } else if(x>2.4 && x<=114.4){
        return 'Bike'
    } else if(x>114.4&&x<=130.6){
        return 'Run'
    } else if(x>130.6&&x<140.6) {
        return 'Nearly there!'
    } else if(x===140.6){
        return "You're done! Stop running!"
    }
}

console.log(triathlon(0))
console.log(triathlon(2))
console.log(triathlon(5))
console.log(triathlon(10))
console.log(triathlon(140))
console.log(triathlon(140.6))
console.log(triathlon(150))