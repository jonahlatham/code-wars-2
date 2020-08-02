// https://www.codewars.com/kata/58308360aeb69a460b0002b2/train/javascript

function unique(arr) {
  return arr.filter((e, i) => {
    return arr.indexOf(e) === i;
  });
}

console.log(unique([1, 2, 3, 4, 1, 2, 5, 7, 9, 2, 8, 4]));
