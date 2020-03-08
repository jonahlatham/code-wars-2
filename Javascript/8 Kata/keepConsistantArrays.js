function keepConsistant(x, y, z) {
  let newsFlash = x.filter(e => {
    if (y.includes(e)) {
      return true;
    } else {
      return false;
    }
  });
  return z.filter(e => {
    if (newsFlash.includes(e)) {
      return true;
    } else {
      return false;
    }
  });
}

console.log(
  keepConsistant(
    [1, 2, 3, 4, 58, 6, 7, 83, 9, 10],
    [2, 3, 4, 1, 7, 54, 23, 12, 97],
    [86, 43, 42, 761, 2, 4, 1, 6]
  )
);
console.log(
  keepConsistant(
    [21, 21, 23, 25, 23, 26, 27],
    [12, 23, 65, 27],
    [21, 43, 76, 24, 23, 25, 12]
  )
);
