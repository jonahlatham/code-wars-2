let arr = [9, 3, '7', '3'] //2

function divCon(x) {
    let num = x.reduce((r, e) => {
        if (e !== e.toString()) {
            r += e
        }
        return r
    }, 0)
    let str = x.reduce((r, e) => {
        if (e === e.toString()) {
            r += Number(e)
        }
        return r
    }, 0)
    return num - str
}

console.log(divCon(arr))