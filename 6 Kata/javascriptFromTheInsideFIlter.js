Array.prototype.filter = function (fn, receiver) {
    let length = this.length;
    let arr = [];
    for (let i = 0; i < length; i++) {
        if (i in this && fn.call(receiver, this[i], i, this)) arr.push(this[i])
    }
    return arr
}   