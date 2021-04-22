// Put your code here

console.log("Do you believe in magic?");
console.log("------------------------");

let goodBook = []
let evilBook = []

let allSpells = [
    {
        Name : "Turn enemy into a newt",
        IsEvil : true,
        EnergyReqired : 5.1 
    },
    {
        Name : "Conjure some gold for a local charity",
        IsEvil : false,
        EnergyReqired : 2.99
    },
    {
        Name : "Give a deaf person the ability to heal",
        IsEvil : false,
        EnergyReqired : 12.2
    },
    {
        Name : "Make yourself emperor of the universe",
        IsEvil : true,
        EnergyReqired : 100.0
    },
    {
        Name : "Convince your relatives your political views are correct",
        IsEvil : false,
        EnergyReqired : 2921.5
    }
]

let MakeEvilSpellBook = (allSpells) => {
    evilBook.title = "Evil Book";
    evilBook.spells = allSpells.filter( i => i.IsEvil);
    return evilBook

}

let MakeGoodSpellBook = (allSpells) => {
    goodBook.title = "Good Book";
    goodBook.spells = allSpells.filter( i => i.IsEvil === false);
    return goodBook
    
}

let DisplaySpellBook = (x) =>{
    console.log(x.title)
    x.forEach(spell => {
        console.log(x.spell.Name);
    });

    let y = x.spells.map(x => x.Name)
    return y
}


    MakeEvilSpellBook(allSpells)
    MakeGoodSpellBook(allSpells)
    console.log(DisplaySpellBook(goodBook))
    console.log(DisplaySpellBook(evilBook))
    

