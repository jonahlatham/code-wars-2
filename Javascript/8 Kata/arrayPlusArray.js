function arrayPlusArray(arr1, arr2) {
  return arr1.concat(arr2).reduce((r, e, i) => {
    r += e;
    return r;
  }, 0);
}

console.log(arrayPlusArray([1, 2, 3], [7, 8, 9]));
