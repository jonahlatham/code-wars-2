function isLastCharacterN(word) {
    return word.slice(word.length - 1) === 'n'.toLowerCase()
}

console.log(isLastCharacterN('hello'))
console.log(isLastCharacterN('hellon'))
console.log(isLastCharacterN('why'))
console.log(isLastCharacterN('whyn'))