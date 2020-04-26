function cutTheCrap(x, y) {
  if (y >= x.length) {
    return x.slice(0, y);
  }else {
      return "no more crap to cut"
  }
}

console.log(cutTheCrap('sam i am', 3));
