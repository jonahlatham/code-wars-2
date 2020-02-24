let queue = ['sheep', 'sheep', 'sheep', 'sheep', 'sheep', 'sheep', 'sheep', 'wolf', 'sheep']

function warnTheSheep(queue) {
    console.log(queue.indexOf('wolf'))
    if (queue.indexOf('wolf') === queue.length - 1) {
        return "Pls go away and stop eating my sheep"
    } else {
        return `Oi! Sheep number ${queue.length - 1 - queue.indexOf('wolf')}! You are about to be eaten by a wolf!`
    }
}

console.log(warnTheSheep(queue))