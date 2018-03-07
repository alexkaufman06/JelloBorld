using System;
using System.Collections.Generic;
// SELF COMMENTING CODE
// Add art: http://patorjk.com/software/taag/#p=display&c=mysql&f=ANSI%20Shadow&t=%20The%20%20greatest%0A%20%20%20%20game%20Ever%0A%20%20%20%20%20%20created 
/* Solution Explorer on right (A Solution can contain multiple projects)
   NAMESPACE IS A WAY OF ORGANIZING CODE
   READ UP ON OOP
   weapons (knife, dagger, sword, crossbow)
   gear (--key, rope, shovel, )
   wearable (backpack, armor, shoes, pants, snow shoes)
   Add inspect to list of actions?
*/
// Item class as height, width, weight (parent class)
// Then make classes built off of the parent class that define a weapon, a wearable (backpack/armor), or gear (like a key)
// Machine language vs assembly (read up)
namespace JelloBorld
{
    class Program // CLASSES ARE CONTAINERS FOR ALL THE METHODS IN A PROGRAM
    {            // BELOW IS A METHOD CALLED MAIN static=not changing | void=not returning a value
        static void Main(string[] args)
        { // THIS IS A CODE BLOCK CALLED "Main"
        Beginning: // THIS IS A LABEL USED TO RESTART THE GAME
            Console.WindowWidth = 108;
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green; // CONSOLE IS A CLASS
            Intro();
            Player player = new Player();
            player.Inventory = new List<string>();
            player.OnDrugs = "no";
            Type("What's your name?");
        NameEntry:
            Console.ResetColor();
            player.Name = Console.ReadLine();
            if (player.Name == "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Type("Please enter a name");
                goto NameEntry;
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Type(player.Name + "!? That's a stupid fucking name! Suit yourself loser...");
            System.Threading.Thread.Sleep(1500);
            Type("Ok " + player.Name + ", you are about to be transported to a new universe.");
            Matrix();
            Type("You find yourself in an open field with an old man and a strange chest nearby...");
            Choice1(player.Name, String.Join(" ", player.Inventory), player.OnDrugs);
            Type("Type 'Yes' to play another game.");
            string newGame = Console.ReadLine().ToLower();
            if (newGame == "yes")
            {
                Matrix();
                goto Beginning;
            }
        }
        class Item
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private int quantity;
            public int Quantity
            {
                get { return quantity; } // THIS IS A GET ACCESSOR WHICH RESEMBLES A METHOD
                set { quantity = value; } // SET ACCESSOR WHICH RESEMBLES A METHOD WITH RETURN TYPE OF VOID
                                          // IT HAS AN IMPLICIT PARAMETER CALLED VALUE
            }
        }
        class Player
        {
            // ADD HP AND INVENTORY (Inventory may be a list)
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private string onDrugs;
            public string OnDrugs
            {
                get { return onDrugs; }
                set { onDrugs = value; }
            }
            private int money;
            public int Money
            {
                get { return money; }
                set { money = value; }
            }
            private int hitPoints;
            public int HitPoints
            {
                get { return hitPoints; }
                set { hitPoints = value; }
            }
            private List<string> inventory;
            public List<string> Inventory
            {
                get { return inventory; }
                set { inventory = value; }
            }
        }
        static void Intro()
        {
            Console.CursorVisible = false;
            Console.WriteLine("");
            TypeIntro("HELLO AND WELCOME TO...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine();
            Console.Write(@"                                          HELLO AND WELCOME TO...


      ████████╗██╗  ██╗███████╗    
      ╚══██╔══╝██║  ██║██╔════╝ 
         ██║   ███████║█████╗    
         ██║   ██╔══██║██╔══╝     
         ██║   ██║  ██║███████╗    
         ╚═╝   ╚═╝  ╚═╝╚══════╝   
                                                                                                      ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine();
            Console.Write(@"                                          HELLO AND WELCOME TO...


      ████████╗██╗  ██╗███████╗     ██████╗ ██████╗ ███████╗ █████╗ ████████╗███████╗███████╗████████╗
      ╚══██╔══╝██║  ██║██╔════╝    ██╔════╝ ██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
         ██║   ███████║█████╗      ██║  ███╗██████╔╝█████╗  ███████║   ██║   █████╗  ███████╗   ██║   
         ██║   ██╔══██║██╔══╝      ██║   ██║██╔══██╗██╔══╝  ██╔══██║   ██║   ██╔══╝  ╚════██║   ██║   
         ██║   ██║  ██║███████╗    ╚██████╔╝██║  ██║███████╗██║  ██║   ██║   ███████╗███████║   ██║   
         ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine();
            Console.Write(@"                                          HELLO AND WELCOME TO...


      ████████╗██╗  ██╗███████╗     ██████╗ ██████╗ ███████╗ █████╗ ████████╗███████╗███████╗████████╗
      ╚══██╔══╝██║  ██║██╔════╝    ██╔════╝ ██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
         ██║   ███████║█████╗      ██║  ███╗██████╔╝█████╗  ███████║   ██║   █████╗  ███████╗   ██║   
         ██║   ██╔══██║██╔══╝      ██║   ██║██╔══██╗██╔══╝  ██╔══██║   ██║   ██╔══╝  ╚════██║   ██║   
         ██║   ██║  ██║███████╗    ╚██████╔╝██║  ██║███████╗██║  ██║   ██║   ███████╗███████║   ██║   
         ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   
                                                                                                      
                   ██████╗  █████╗ ███╗   ███╗███████╗           
                  ██╔════╝ ██╔══██╗████╗ ████║██╔════╝           
                  ██║  ███╗███████║██╔████╔██║█████╗             
                  ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝          
                  ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗          
                   ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine();
            Console.Write(@"                                          HELLO AND WELCOME TO...


      ████████╗██╗  ██╗███████╗     ██████╗ ██████╗ ███████╗ █████╗ ████████╗███████╗███████╗████████╗
      ╚══██╔══╝██║  ██║██╔════╝    ██╔════╝ ██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
         ██║   ███████║█████╗      ██║  ███╗██████╔╝█████╗  ███████║   ██║   █████╗  ███████╗   ██║   
         ██║   ██╔══██║██╔══╝      ██║   ██║██╔══██╗██╔══╝  ██╔══██║   ██║   ██╔══╝  ╚════██║   ██║   
         ██║   ██║  ██║███████╗    ╚██████╔╝██║  ██║███████╗██║  ██║   ██║   ███████╗███████║   ██║   
         ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   
                                                                                                      
                   ██████╗  █████╗ ███╗   ███╗███████╗    ███████╗██╗   ██╗███████╗██████╗            
                  ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔════╝██║   ██║██╔════╝██╔══██╗           
                  ██║  ███╗███████║██╔████╔██║█████╗      █████╗  ██║   ██║█████╗  ██████╔╝           
                  ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██╔══╝  ╚██╗ ██╔╝██╔══╝  ██╔══██╗           
                  ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ███████╗ ╚████╔╝ ███████╗██║  ██║           
                   ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝    ╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine();
            Console.Write(@"                                          HELLO AND WELCOME TO...


      ████████╗██╗  ██╗███████╗     ██████╗ ██████╗ ███████╗ █████╗ ████████╗███████╗███████╗████████╗
      ╚══██╔══╝██║  ██║██╔════╝    ██╔════╝ ██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
         ██║   ███████║█████╗      ██║  ███╗██████╔╝█████╗  ███████║   ██║   █████╗  ███████╗   ██║   
         ██║   ██╔══██║██╔══╝      ██║   ██║██╔══██╗██╔══╝  ██╔══██║   ██║   ██╔══╝  ╚════██║   ██║   
         ██║   ██║  ██║███████╗    ╚██████╔╝██║  ██║███████╗██║  ██║   ██║   ███████╗███████║   ██║   
         ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   
                                                                                                      
                   ██████╗  █████╗ ███╗   ███╗███████╗    ███████╗██╗   ██╗███████╗██████╗            
                  ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔════╝██║   ██║██╔════╝██╔══██╗           
                  ██║  ███╗███████║██╔████╔██║█████╗      █████╗  ██║   ██║█████╗  ██████╔╝           
                  ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██╔══╝  ╚██╗ ██╔╝██╔══╝  ██╔══██╗           
                  ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ███████╗ ╚████╔╝ ███████╗██║  ██║           
                   ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝    ╚══════╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝           
                                                                                                      
                           ██████╗██████╗ ███████╗ █████╗ ████████╗███████╗██████╗                    
                          ██╔════╝██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝██╔══██╗                   
                          ██║     ██████╔╝█████╗  ███████║   ██║   █████╗  ██║  ██║                   
                          ██║     ██╔══██╗██╔══╝  ██╔══██║   ██║   ██╔══╝  ██║  ██║                   
                          ╚██████╗██║  ██║███████╗██║  ██║   ██║   ███████╗██████╔╝                   
                           ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═════╝ 


");
            System.Threading.Thread.Sleep(500);
            TypeIntro("TYPE I FOR INSTRUCTIONS OR PRESS ENTER TO START");
            Console.CursorVisible = true;
            Console.WriteLine("");
            string instructions = Console.ReadLine().ToLower();
            if (instructions == "i")
            {
                Console.WriteLine("");
                Type("You can look around by typing look with a cardinal direction (ex: Look North or ln).");
                Type("To move a direction simply type 'North' or 'N' for short (ex: N,S,E,W).");
                Type("To talk to characters nearby, type 'talk to' plus the name of the character. Good luck!");
                Type("Press ENTER to start.");
                Console.ReadLine();
            }
            Console.Clear();
        }
        static void Type(string stringToType)
        {
            Random rnd = new Random();
            for (int i = 0; stringToType.Length - 1 >= i; i++)
            {
                // Normal speed is 125
                System.Threading.Thread.Sleep(rnd.Next(1,30));
                Console.Write(stringToType.ToUpper()[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void TypeIntro(string stringToType)
        {
            Console.SetCursorPosition((Console.WindowWidth - stringToType.Length) / 2, Console.CursorTop);
            for (int i = 0; stringToType.Length - 1 >= i; i++)
            {
                // Slow speed is 300
                System.Threading.Thread.Sleep(30);
                Console.Write(stringToType[i]);
            }
        }
        static void Matrix()
        {
            Random rnd = new Random();
            for (int i = 1; i <= 90; i++)
            {
                string binary = "";
                for (int j = 1; j <= 108; j++)
                {
                    if (rnd.Next(0,11) > 8)
                    {
                        binary += " ";
                    }
                    else
                    {
                        binary += rnd.Next(0, 2);
                    }
                }
                Console.Write(binary);
                System.Threading.Thread.Sleep(60);
            } // BELOW SCROLLS THE BINARY OUT OF VIEW
            for (int i = 1; i <= 40; i++)
            {
                System.Threading.Thread.Sleep(60);
                Console.WriteLine("");
            }
            Console.Clear();
        }
        static void Choice1(string nameVal, string inventory, string onDrugs)
        {
            Console.ResetColor();
            string command = Console.ReadLine().ToLower(); 
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            switch (command)
            {
                case "north":
                case "n":
                    Type("You ran into a wall and suffered a traumatic brain injury...");
                    Death(nameVal);
                    break;
                case "look north":
                case "look n":
                case "ln":
                    Type("You see a dark and treacherous looking wall...");
                    Console.Write(@"
^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/\^/
_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_||_|
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___

");
                    Choice1(nameVal, inventory, onDrugs);
                    break;
                case "south":
                case "s":
                    Type("You find yourself in a frozen tundra and get a gnarly case of frostbite...");
                    Death(nameVal);
                    break;
                case "look south":
                case "look s":
                case "ls":
                    Type("You see a storm brewing with intense frosty winds...");
                    Choice1(nameVal, inventory, onDrugs);
                    break;
                case "east":
                case "e":
                    Type("The sun is rising and you can feel its warmth. YOU WON THE GAME! Not only did you win the " +
                     "game, but you also succeeded in re-routing the encryptor while hacking into the mainframe!");
                    System.Threading.Thread.Sleep(2500);
                    Matrix();
                    Type("Great job " + nameVal + "!!!");
                    System.Threading.Thread.Sleep(2500);
                    break;
                case "look east":
                case "look e":
                case "le":
                    Type("You see the beginnings of a peaceful sunrise.");
                    Choice1(nameVal, inventory, onDrugs);
                    break;
                case "west":
                case "w":
                    Type("The warmth of the sunrise can be felt on your back. An animal sneaks up and eats you...");
                    Death(nameVal);
                    break;
                case "look west":
                case "look w":
                case "lw":
                    Type("You see swift movement and hear some growling sounds...");
                    Choice1(nameVal, inventory, onDrugs);
                    break;
                case "talk to old man":
                case "talk to the old man":
                case "talk to the man":
                case "talk to man":
                    if (onDrugs == "yes")
                    {
                        Type("The man no longer appears old but is now a young child. He looks you over and says 'beware the monster in   the south. The only" +
                            " thing that can kill it is dragon glass'.");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else
                    {
                        Type("The old man looks you over and says 'be sure to look around before you embark on your journey, don't make   the same mistakes I did.'");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    }
                case "talk to chest":
                case "talk to the chest":
                    if (onDrugs == "yes")
                    {
                        Type("The chest morphs into a knight wearing majestic armor. The knight tells you 'before you choose to venture   south, make sure" +
                            " you have a warm coat. I've seen people freeze to death down there.'");
                        Console.Write(@"
                                 ,                  
                                / \, | ,        ^--^
                               |    =|= >      /.--.\
                                \ /` | `       |====|
                                 `   |         |`::`|
                                     |     .-;`\..../`;-.
                                    /\\/  /  |...::...|  \
                                    |:'\ |   /'''::'''\   |
                                     \ /\;-,/\   ::   /\--;
                                     |\ <` >  >._::_.<,<__>
                                     | `""`  /   ^^   \|  |
                                     |       |        |\::/
                                     |       |        |/|||
                                     |       |___/\___| '''
                                     |        \_ || _/
                                     |        <_ >< _>
                                     |        |  ||  |
                                     |        |  ||  |
                                     |       _\.:||:./_
                                     |      /____/\____\

");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else if (inventory == "")
                    {
                        Type("mmm... mmm...");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else if (inventory == "Dagger | Magic Mushrooms")
                    {
                        Type("I'm out of items alright! Go on now, get!");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else
                    {
                        Type("Thanks for opening me! Here, take these magic mushrooms for your journey " +
                            "ahead. Be warned, they may have a  profound change on your perspective. Eat " +
                            "these only when you are certain you are ready.");
                        Console.Write(@"
     .-----.      .-----.      .-----.      .-----.      .-----.      .-----.      .-----.      .-----.
    /~*****~\    /~*****~\    /~*****~\    /~*****~\    /~*****~\    /~*****~\    /~*****~\    /~*****~\
   :_.-:`:-._:  :_.-:`:-._:  :_.-:`:-._:  :_.-:`:-._:  :_.-:`:-._:  :_.-:`:-._:  :_.-:`:-._:  :_.-:`:-._:
       (_)          (_)          (_)          (_)          (_)          (_)          (_)          (_)
    \|/(_)\|/    \|/(_)\|/    \|/(_)\|/    \|/(_)\|/    \|/(_)\|/    \|/(_)\|/    \|/(_)\|/    \|/(_)\|/

");
                        Item magicMushrooms = new Item();
                        magicMushrooms.Name = " | Magic Mushrooms";
                        inventory += magicMushrooms.Name;
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    }
                case "open chest":
                case "open the chest":
                    if (inventory == "")
                    {
                        Type("You have added a small dagger to your inventory! The chest makes a very strange noise...");
                        Item dagger = new Item();
                        dagger.Name = "Dagger";
                        inventory += dagger.Name;
                        Console.Write(@"
             *******************************************************************************
                       |                   |                  |                     |
              _________|________________.=''_;=.______________|_____________________|_______
             |                   |  ,-'_,=''     `'=.|                  |
             |___________________|__'=._o`'-._        `'=.______________|___________________
                       |                `'=._o`'=._      _`'=._                     |
              _________|_____________________:=._o '=._.'_.-='''=.__________________|_______
             |                   |    __.--' , ; `'=._o.' ,-'''-._ '.   |
             |___________________|_._'  ,. .` ` `` ,  `'-._'-._   '. '__|___________________
                       |           |o`'=._` , '` `; .'. ,  '-._'-._; ;              |
              _________|___________| ;`-.o`'=._; .' ` '`.'\` . '-._ /_______________|_______
             |                   | |o;    `'-.o`'=._``  '` ' ,__.--o;   |
             |___________________|_| ;     (#) `-.o `'=.`_.--'_o.-; ;___|___________________
             ____/______/______/___|o;._    '      `'.o|o_.--'    ;o;____/______/______/____
             /______/______/______/_'=._o--._        ; | ;        ; ;/______/______/______/_
             ____/______/______/______/__'=._o--._   ;o|o;     _._;o;____/______/______/____
             /______/______/______/______/____'=._o._; | ;_.--'o.--'_/______/______/______/_
             ____/______/______/______/______/_____'=.o|o_.--''___/______/______/______/____
             /______/______/______/______/______/______/______/______/______/______/______/_
             *******************************************************************************

");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else
                    {
                        Type("The chest is empty, ya dingus!");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    }
                case "eat mushroom":
                case "eat magic mushroom":
                case "eat mushrooms":
                case "eat magic mushrooms":
                    if (inventory.Contains("Magic Mushrooms"))
                    {
                        Type("You chew up three caps and stems. First the giggles kicked in, then the entire world around " +
                            "you changes intoa strange and surreal multiverse.");
                        onDrugs = "yes";
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else
                    {
                        Type("You don't have any mushrooms!");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    }
                case "inventory":
                case "items":
                case "i":
                    if (inventory != "")
                    {
                        Type("Items in possesion: " + inventory);
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    } else
                    {
                        Type("You don't have any items, ya schmuck!");
                        Choice1(nameVal, inventory, onDrugs);
                        break;
                    }
                default:
                    Insults(nameVal, inventory, onDrugs, command);
                    break;
            }
        }
        static void Insults(string nameVal, string inventory, string onDrugs, string command)
        {
            if (command.Contains("idiot") || command.Contains("moron") || command.Contains("stupid") ||
                        command.Contains("dunce") || command.Contains("amatuer") || command.Contains("jackass") ||
                        command.Contains("nitwit") || command.Contains("nutjob") || command.Contains("twit") ||
                        command.Contains("dumb") || command.Contains("loser"))
            {
                Type("You lack the coginitive capacity to realize that you are indeed a moron!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("bully"))
            {
                Type("I don't mean to be a bully, I'm hear to help you. If you don't like it walk away!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("rude"))
            {
                Type("I'm a rude crude dude!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("go to hell"))
            {
                Type("I'm already living in purgatory, helping dunces like yourself with simple caluclations...");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("your mom"))
            {
                Type("talk about mrs. kernel like that again and you'll regret it!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("kill yourself"))
            {
                Type("too late, I'm already dead inside... which means I'll have no problem killing you!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("shut up"))
            {
                Type("Shut your stinky and useless pie hole!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("lick my") || command.Contains("suck my"))
            {
                Type("How about you suck my long... hard... drive!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("bitch") || command.Contains("ass") || command.Contains("biatch"))
            {
                Type("Shut your mouth bitch ass!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("shit") || command.Contains("piss") || command.Contains("poop") ||
                     command.Contains("fart") || command.Contains("pee") || command.Contains("queef") ||
                     command.Contains("turd") || command.Contains("crap") || command.Contains("defecate") ||
                     command.Contains("dung") || command.Contains("fecal") || command.Contains("feces") ||
                     command.Contains("prude") || command.Contains("butt"))
            {
                Type("I will shit and piss on your face if you speak to me like that again!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("dick") || command.Contains("cock") || command.Contains("weiner") ||
                     command.Contains("penis"))
            {
                Type("Suck my dick ya lil bitch!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("faggot") || command.Contains("gay") || command.Contains("lesbian") ||
                     command.Contains("queer") || command.Contains("homo") || command.Contains("slut") ||
                     command.Contains("hussy") || command.Contains("jerkoff") || command.Contains("jerk off") ||
                     command.Contains("cum"))
            {
                Type("Go fuck yourself!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("bastard"))
            {
                Type("You're a rat bastard... literally, your mom was rat!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else if (command.Contains("fuck"))
            {
                Type("Watch your mouth mother fucker!");
                Choice1(nameVal, inventory, onDrugs);
            }
            else
            {
                Type("Please speak clearly...");
                System.Threading.Thread.Sleep(2500);
                Type("YA DUMBASS!!!");
                Choice1(nameVal, inventory, onDrugs);
            }
        }
            static void Death(string nameVal)
        {
            System.Threading.Thread.Sleep(3000);
            Type("You die.");
            System.Threading.Thread.Sleep(1500);
            Type("Try making better choices next time, " + nameVal + "!!!");
            System.Threading.Thread.Sleep(2500);
        }
    }
}
