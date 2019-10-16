function checkPalindrome(str) {
	return str.split('').reverse().join('') === str
}

console.log(checkPalindrome('tacocat'))
console.log(checkPalindrome('mom'))
console.log(checkPalindrome('milk'))