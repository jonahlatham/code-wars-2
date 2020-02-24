function getFreeUrinals(urinals){
    return /11/g.test(urinals) ? -1 : (`0${urinals}0`.match(/00(?=0)/g) || []).length;
  }

console.log(getFreeUrinals('10001')) //1
console.log(getFreeUrinals('1001'))//0
console.log(getFreeUrinals('00000'))//3
console.log(getFreeUrinals('0000'))//2
console.log(getFreeUrinals('01000'))//1