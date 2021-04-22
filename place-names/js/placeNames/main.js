// Put your code here
let names = ["Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

console.log("All Place Names");


const map1 = names.map(x => console.log(x));
 

let theNames = names.filter(x => x.startsWith("The"));

console.log(theNames);
