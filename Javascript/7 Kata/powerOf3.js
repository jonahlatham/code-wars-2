
function largestPower(n) {
    let arr = []
    for (let i = 0; i <= n; i++) {
        if (Math.pow(3, i) < n) {
            arr.push(i)
        }
    }
    return arr[arr.length - 1]
}
// function largestPower(n) {
//     for (let i = 0; i <= n; i++) {
//         if (Math.pow(3, i) < n) {
//             continue
//         }
//         return i-1
//     }
// }

console.log(largestPower(3)) //0
console.log(largestPower(5)) //1
console.log(largestPower(7)) //1
console.log(largestPower(81)) //3