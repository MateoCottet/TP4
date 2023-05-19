const imagenesAll = document.querySelectorAll("img")
const inputsAll = document.querySelectorAll("input")
console.log("a")
let huboSelected = [false,false,false];
for (let i = 0; i<imagenesAll.length;i++) {
    imagenesAll[i].addEventListener("click",(e)=> {
        const img = e.target
        let mult = null
        if (i<10) {
            mult = 0
            inputsAll[1].value = img.id
        } else if(i<20) {
            mult = 1
            inputsAll[2].value = img.id
        } else if(i<30) {
            mult = 2
            inputsAll[3].value = img.id
        }
        let num = 10*mult
        for (let f = 10*mult;f<num+10;f++) {
            imagenesAll[f].classList.remove("selected")
        }
        imagenesAll[i].classList.add("selected")
    })
}