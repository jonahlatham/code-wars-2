function countClaps(txt) {
	return txt.split("C").length-1;
}
console.log(countClaps('clapclapclap'))
console.log(countClaps("ClClClaClaClaClap!"))