String.prototype.digit = function (x) {
    return /^[0-9]$/.test(this)
};

console.log('abcd'.digit('abcd'))
console.log('4'.digit('4'))
console.log('4245'.digit())
console.log('undefined'.digit())
console.log('14'.digit())
