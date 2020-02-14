function moodToday(mood) {
    console.log(mood)
    if (mood !== undefined) {
        return `Today, I am feeling ${mood}`
    } else {
        return 'Today, I am feeling neutral'
    }
}

console.log(moodToday('happy'))
console.log(moodToday('sad'))
console.log(moodToday(''))
console.log(moodToday())