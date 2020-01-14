
function getContainer(product) {
    let container
    switch (product) {
        case "Bread":
            container = "bag"
        case "Beer":
        case "Milk":
            container = "bottle"
            break
        case "Cerials":
            container = "box"
            break
        case "Eggs":
            container = "carton"
            break
        case "Candy":
            container = "plastic"
        default:
            container = null
    }

    return container
}

//  =>

function getContainer(product) {
    let container
    switch (product) {
        case "Bread":
            return container = "bag"
        case "Beer":
        case "Milk":
            return container = "bottle"
            break
        case "Cerials":
            return container = "box"
            break
        case "Eggs":
            return container = "carton"
            break
        case "Candy":
            return container = "plastic"
        default:
            return container = null
    }

    return container
}

console.log(getContainer('Eggs'))
console.log(getContainer('Candy'))
console.log(getContainer('Milk'))