using System;
using System.Collections.Generic;
using System.Linq;

    namespace Dinner
    {
        public class Table
        {
            public int TableNumber { get; set; }
            public List<Guest> GuestList { get; set; }

            public Table()
            {
                GuestList = new List<Guest>();
            }
            
        }

        public class Guest
        {
            public string Name { get; }
            public string Occupation { get; set; }
            public string Bio { get; set; }

            public Guest(string name, string occupation, string bio)
            {
                Name = name;
                Occupation = occupation;
                Bio = bio; 
            }

            
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Guest> allGuests = new List<Guest>() {
                    
                    new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"),
                    
                    new Guest("Alan Turing","computer scientist","(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"),
                    
                    new Guest("Admiral Grace Hopper","computer scientist","(1906–1992) - developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"),
                    
                    new Guest("Marilyn Monroe","entertainer","(1926 - 1962) American actress, singer, model"),                    
                    new Guest("Abraham Lincoln","politician","(1809 - 1865) US President during American civil war"),
                    
                    new Guest("Martin Luther King","activist","(1929 - 1968)  American civil rights campaigner"),
                    
                    new Guest("Rosa Parks",
                        "activist","(1913 - 2005)  American civil rights activist"),
                    
                    new Guest("Indira Gandhi",
                        "politician",
                        "(1917 - 1984) Prime Minister of India 1966 - 1977"),
                    };
                    

                
                Table table1 = new Table(){

                };
                Table table2 = new Table(){};
                List<Table> allTables = new List<Table>() {
                    table1,
                    table2,
                };
                
                foreach (Guest currentGuest in allGuests){
                
                
                var matches = table1.GuestList.Any(p => String.Equals(p.Occupation, currentGuest.Occupation, StringComparison.CurrentCulture));

                if (!matches){
                    table1.GuestList.Add(currentGuest);
                }else{
                    table2.GuestList.Add(currentGuest);
                }
                
                }
                Console.WriteLine(); 
            }
               

                
                
                
                



        }
    }
    
    
    
    


        ///////////////////////////////////////////////





























        // using System;
        // using System.Collections.Generic;
        // using System.Linq;

        // Console.WriteLine("Do you believe in magic?");
        // Console.WriteLine("------------------------");

        // List<Spell> allSpells = GetAllSpells();
        // SpellBook goodBook = MakeGoodSpellBook(allSpells);
        // SpellBook evilBook = MakeEvilSpellBook(allSpells);

        // DisplaySpellBook(goodBook);
        // Console.WriteLine();
        // DisplaySpellBook(evilBook);


        // void DisplaySpellBook(SpellBook book)
        // {
        //     Console.WriteLine(book.Title);
        //     foreach (Spell aSpell in book.Spells)
        //     {
        //         Console.WriteLine($"  {aSpell.Name}");
        //     }
        // }


        // SpellBook MakeEvilSpellBook(List<Spell> allSpells)
        // {
        //     SpellBook evilBook = new SpellBook();
        //     evilBook.Title = "Evil Book";
        //     evilBook.Spells = allSpells.Where(spell => spell.IsEvil).ToList();

        //     return evilBook;
        // }


        // SpellBook MakeGoodSpellBook(List<Spell> allSpells)
        // {
        //     SpellBook goodBook = new SpellBook();
        //     goodBook.Title = "Good Book";
        //     goodBook.Spells = allSpells.Where(spell => !spell.IsEvil).ToList();

        //     return goodBook;
        // }


        // List<Spell> GetAllSpells()
        // {
        //     List<Spell> allSpells = new List<Spell>() {
        //         new Spell() {
        //             Name = "Turn enemy into a newt",
        //             IsEvil = true,
        //             EnergyReqired = 5.1
        //         },
        //         new Spell() {
        //             Name = "Conjure some gold for a local charity",
        //             IsEvil = false,
        //             EnergyReqired = 2.99
        //         },
        //         new Spell() {
        //             Name = "Give a deaf person the ability to heal",
        //             IsEvil = false,
        //             EnergyReqired = 12.2
        //         },
        //         new Spell() {
        //             Name = "Make yourself emperor of the universe",
        //             IsEvil = true,
        //             EnergyReqired = 100.0
        //         },
        //         new Spell() {
        //             Name = "Convince your relatives your political views are correct",
        //             IsEvil = false,
        //             EnergyReqired = 2921.5
        //         }
        //     };

        //     return allSpells;
        // }

        // public class SpellBook
        // {
        //     public string Title { get; set; }
        //     public List<Spell> Spells { get; set; }
        // }

        // public class Spell
        // {
        //     public string Name { get; set; }
        //     public bool IsEvil { get; set; }
        //     public double EnergyReqired { get; set; }
        // }
