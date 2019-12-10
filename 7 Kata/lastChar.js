// function lastOne(x) {
//     let newest = x.split(' ').reduce((r, e) => {
//         r.push(e.split('').reverse().join(''))
//         return r.sort()
//     }, [])
//     return newest.map((e) => {
//         return e.split('').reverse().join('')
//     })
// }

// console.log(lastOne('man i need a taxi up to ubud'))
//  // ['a', 'need', 'ubud', 'i', 'taxi', 'man', 'to', 'up']


function last(x) {
    return x.split(' ').sort((a, b) => a.charCodeAt(a.length - 1) - b.charCodeAt(b.length - 1));
}

console.log(last('man i need a taxi up to ubud'))
 // ['a', 'need', 'ubud', 'i', 'taxi', 'man', 'to', 'up']