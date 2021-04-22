// Put your code here
console.log("Let's roll some dice, baby!");
console.log("---------------------------");


let dieValue1
let dieValue2


let Roll = () =>{
    dieValue1 = Math.floor(Math.random() * 6)
    dieValue2 = Math.floor(Math.random() * 6)
}

let visVal=(dieVal)=>{
    switch(dieVal) {
        case 1:
            dieString = "\u2680"; // These \uXXXX values are fancy unicode characters
            break;
        case 2:
            dieString = "\u2681";
            break;
        case 3:
            dieString = "\u2682";
            break;
        case 4:
            dieString = "\u2683";
            break;
        case 5:
            dieString = "\u2684";
            break;
        case 6:
            dieString = "\u2685";
            break;
        }
        return dieString
      }


for (let i = 0; i < 10; i++) {
Roll()
console.log(visVal(dieValue1), '+', visVal(dieValue2), '=', dieValue2+dieValue1)

}
