
// function sortGiftCode(code) {
//     return code.split('').sort().join('')
// }

// console.log(sortGiftCode('lksjbalkjsdfrjlsknurslijsf'))
// console.log(sortGiftCode('lksjbalksdfsdfsdflijsf'))
// console.log(sortGiftCode('lksjblsdfsfsdfsdfsknurslijsf'))

//delete duplicates

function sortGiftCode(code) {
    let letters = code.split('').sort()
    let unique = [...new Set(letters)]
    return unique.join('')
}

console.log(sortGiftCode('lksjbalkjsdfrjlsknurslijsf'))
console.log(sortGiftCode('lksjbalksdfsdfsdflijsf'))
console.log(sortGiftCode('lksjblsdfsfsdfsdfsknurslijsf'))