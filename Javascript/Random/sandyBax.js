function crap() {
  let arr = [['one:two;', 'one:two;', 'one:two;', 'one:two;'],['one:two;', 'one:two;', 'one:two;', 'one:two;'],['one:two;', 'one:two;', 'one:two;', 'one:two;']['one:two;', 'one:two;', 'one:two;', 'one:two;']];
  return arr.map((e)=>{
      return e
  }).flat().join('')
}

console.log(crap());
