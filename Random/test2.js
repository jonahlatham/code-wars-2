function trial2() {
    let str = 'cccccrrrrraaaaappppp'
    let newStr = str.split('')
    return [... new Set(newStr)].join('')
}
console.log(trial2())