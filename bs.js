const data = [
    { id: 'Mark & Chris', parent: null },
    { id: 'Bryce & Madison', parent: 'Mark & Chris' },
    { id: 'Palmer', parent: 'Bryce & Madison' },
    { id: 'Luke', parent: 'Bryce & Madison' },
    { id: 'Crew', parent: 'Bryce & Madison' },
    { id: 'Will & Heather', parent: 'Mark & Chris' },
    { id: 'Liam', parent: 'Will & Heather' },
    { id: 'Tad', parent: 'Will & Heather' },
    { id: 'Wade', parent: 'Will & Heather' },
    { id: 'Nora', parent: 'Will & Heather' },
    { id: 'Ammon', parent: 'Mark & Chris' },
    { id: 'Aaron', parent: 'Mark & Chris' },
    { id: 'Stephen & Hannah', parent: 'Mark & Chris' },
    { id: 'Josh & Lauren', parent: 'Mark & Chris' },
    { id: 'Eli', parent: 'Josh & Lauren' },
    { id: 'Calvin', parent: 'Josh & Lauren' },
    { id: 'Jonah', parent: 'Mark & Chris' },
]

const familyTree = (members, parent) => {
    const obj = {};
    const children = members.filter((e) => { return e.parent === parent })
    children.forEach((e) => {
        obj[e.id] = familyTree(members, e.id)
    })
    return obj
}

console.log(familyTree(data, null))

// const expectation = {
//     'Mark & Chris': {
//         'Bryce & Madison': {
//             'Palmer': {},
//             'Luke': {},
//             'Crew': {},
//         },
//         'Will & Heather': {
//             'Liam': {},
//             'Tad': {},
//             'Wade': {},
//             'Nora': {},
//         },
//         'Ammon': {},
//         'Aaron': {},
//         'Stephen & Hannah': {},
//         'Josh & Lauren': {
//             'Eli': {},
//             'Calvin': {}
//         },
//         'Jonah': {}
//     }
// }