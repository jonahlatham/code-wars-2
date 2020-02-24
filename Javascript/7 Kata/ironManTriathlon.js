function iTri(s) {
    if (s === 0) {
        return `Starting Line... Good Luck!`
    } else if (s <= 2.4) {
        let obj = { Swim: `${(140.6 - s).toFixed(2)} to go!` }
        return obj
    } else if (s > 2.4 && s <= 114.4) {
        let obj = { Bike: `${(140.6 - s).toFixed(2)} to go!` }
        return obj
    } else if (s > 114.4 && s <= 130.6) {
        let obj = { Run: `${(140.6 - s).toFixed(2)} to go!` }
        return obj
    } else if (s > 130.6 && s < 140.6) {
        let obj = { Run: `Nearly there!` }
        return obj
    } else {
        return `You're done! Stop running!`
    }
}

console.log(iTri(0))
console.log(iTri(2))
console.log(iTri(10))
console.log(iTri(132))
console.log(iTri(140))
console.log(iTri(150))