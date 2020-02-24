let arr = ["1a", "a", "2b", "b"]

function numInStr(arr) {
	return arr.filter(x=>/\d/.test(x));
}

console.log(numInStr(arr))