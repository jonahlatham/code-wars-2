let paragraph = 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.'

// 1a
function getSentences(paragraph) {
    return paragraph.split('.')
}

console.log(getSentences(paragraph))


// 1b
function getWords(paragraph, input) {
    let arr = []
    if (!input) {
        return paragraph
    } else {
        for (let i = 0; i <= input; i++) {
            arr.push(paragraph.split(' ')[i])
        }
        return arr
    }
}

console.log(getWords(paragraph, 4))


// 1c
function getPigLatin(paragraph) {
    return paragraph.split(' ').map((e) => {
        if (e[0].match(/[aeiouAEIOU]/)) {
            return `${e}ay`
        } else {
            return `${e.slice(1, e.length)}${e[0]}ay`
        }
    })
}

console.log(getPigLatin(paragraph))


// 2
let Structure = "<item1>|<item2>|<item3>|<item4>"

function grab(str) {
    console.log(str.split('|')[2])
}

console.log(grab(Structure))


// 3
/*
    Using array.find() causes problems because it looks for
    the first item that returns a truthy value. It only 
    returns one value so you wouldn't be able to get back 
    everything that passed the test.
*/

// 4a
let dataLayer = {
    'products': [
        {
            'name': 'protein',
            'id': 'shop',
            'price': '5.95',
            'quantity': 1
        },
        {
            'name': 'salted',
            'id': 'shop-us',
            'price': '7.95',
            'quantity': 3
        },
        {
            'name': 'pop',
            'id': 'shop-us-',
            'price': '8.95',
            'quantity': 2
        },
        {
            'name': 'fruit',
            'id': 'shop-us-4144',
            'price': '9.99',
            'quantity': 1
        }
    ]
}
function totalRevenue(data) {
    return data.products.reduce((r, e) => {
        r += (e.price * e.quantity)
        return r
    }, 0)
}

console.log(totalRevenue(dataLayer))


// 4b
function productObjects(data) {
    return data.products.reduce((r, e, i) => {
        r.push(`product${i + 1}: ${e.name}`)
        return r
    }, [])
}

console.log(productObjects(dataLayer))


// 5
function validateEmail(email) {
    let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}

console.log(validateEmail('jonah@latham.com'))


// 6
let product = {
    name: 'vneck tshirt',
    price: 18.00
}
function clicked(product) {
    //use on an onClick
    let item = `${product.name} - $${product.price}`
    console.log(item)
    alert(item)
}

console.log(clicked(product))