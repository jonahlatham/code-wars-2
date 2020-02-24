
function calculator(num1, operator, num2) {
    switch (operator) {
        case '+':
            return num1 + num2
        case '-':
            return num1 - num2
        case '*':
            return num1 * num2
        case '/':
            if (num2 !== 0) {
                return num1 / num2
            } else {
                return 'Can\'t divide by 0!'
            }
    }
}

console.log(calculator(5, '+', 16))
console.log(calculator(5, '-', 16))
console.log(calculator(5, '*', 16))
console.log(calculator(5, '/', 16))
console.log(calculator(5, '/', 0))