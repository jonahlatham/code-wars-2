function initials(x) {
    return x.split(' ')[0][0].toUpperCase() + '.' + x.split(' ')[1][0].toUpperCase() + '.'
}

console.log(initials('jonah latham'))