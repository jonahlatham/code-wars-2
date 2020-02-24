function changeEnough(change, amountDue) {
    console.log(change, amountDue)
    if ((((change[0] * 25) + (change[1] * 10) + (change[2] * 5) + (change[3]))) / 100 >= amountDue) {
        return true
    } else {
        return false
    }
}

console.log(changeEnough([25, 20, 5, 0], 4.25))