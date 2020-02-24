let arr = ["Jason", "Jackson", "Jordan", "Johnny"]
let arrChild = ["Jason", "Jordan", "Jennifer"]

function findChildren(santasList, children) {
    let newSanta = [... new Set(santasList)]
    let newList = newSanta.filter((e, i) => {
        if (children.includes(e)) {
            return true
        } else {
            return false
        }
    })
    return newList.sort()
}

console.log(findChildren(arr, arrChild))
console.log(findChildren(["jASon", "JAsoN", "JaSON", "jasON"], ["JasoN", "jASOn", "JAsoN", "jASon", "JASON"]))
console.log(findChildren(["Jason", "James", "Johnson"], ["Jason", "James", "JJ"]))