let body = {
    id: 1,
    people: [
        {
            first_name: 'Trent'
        },
        {
            first_name: 'Brock'
        },
        {
            first_name: 'Kyle'
        },
    ],
    age: 21
}
let id = body.id
let people = body.people.map((e)=>{
    return e.first_name
})
console.log(id)
console.log(people)