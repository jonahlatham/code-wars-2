function validateUsr(username) {
    return /^[a-z0-9\_]{4,16}$/.test(username)
}

console.log(validateUsr('jonah'))
console.log(validateUsr('jonah21'))
console.log(validateUsr('jonah_latham'))
console.log(validateUsr('jon4-+ah_lat@ha%m'))
console.log(validateUsr('____'))