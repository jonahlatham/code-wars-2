
function validateUsr(username) {
    return /^[0-9a-z_]{4,16}$/.test(username)
}

console.log(validateUsr('asddsa')) //t
console.log(validateUsr('a')) //f
console.log(validateUsr('Hass')) //f