let obj1 = { a: 1, b: 2 }

function toArray(obj) {
    return Object.entries(obj);
}

console.log(toArray(obj1))