function cutTheCrap(x, y) {
    if (y <= x.length) {
  return x.slice(0, y).trim();
    }else {
        return "no more crap to cut"
    }
}

console.log(cutTheCrap('sam i am', 6));
