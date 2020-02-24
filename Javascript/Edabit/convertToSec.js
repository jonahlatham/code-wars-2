function convert(hours, minutes) {
    let hrSec = hours * 60 * 60
    let minSec = minutes * 60
    return hrSec + minSec
}

console.log(convert(2, 20))