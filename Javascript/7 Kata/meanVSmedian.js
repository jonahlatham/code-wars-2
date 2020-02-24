let arr = [18, 8, 8, 8, 6, 14, 64, 3, 90, 7, 8, 9]

function meanVsMedian(numbers) {
    let mean = numbers.reduce((a, b) => a + b) / numbers.length,
        median = numbers.sort((a, b) => a - b)[Math.floor(numbers.length / 2)];
    return mean == median ? 'same' : mean > median ? 'mean' : 'median'
}

console.log(meanVsMedian(arr))