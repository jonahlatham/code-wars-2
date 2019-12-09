function craft() {
    return ['c','r','a','f','t'].filter((e) => {
        if (e !== 'c' || e !== 'a' || e !== 't') {
            return false
        } else {
            return true
        }
    })
}
console.log(craft())