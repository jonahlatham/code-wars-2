String.prototype.toAlternatingCase = function (str) {
    let words = str.split('').map((e)=>{
        if(e===e.toUpperCase()){
            return e.toLowerCase()
        } else {
            return e.toUpperCase()
        }
    })
    return words.join('')
  }

  console.log(String.prototype.toAlternatingCase('hElLo WoRlD'))