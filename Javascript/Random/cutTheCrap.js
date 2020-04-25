function cutTheCrap(x, y) {
  if (y >= x.length) {
    return x.slice(0, y);
  }
}

console.log(cutTheCrap('sam i am', 3));
