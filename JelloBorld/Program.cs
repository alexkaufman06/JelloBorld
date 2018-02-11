using System;
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
            Console.ForegroundColor = ConsoleColor.Green; // CONSOLE IS A CLASS
            Intro();
            Player player = new Player();
            Type("What's your name?");
            Console.ResetColor();
            player.Name = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Type(player.Name + "!? That's a stupid fucking name! Suit yourself loser...");
            System.Threading.Thread.Sleep(1500);
            Type("Ok " + player.Name + ", you are about to be transported to a new universe.");
            Type("You can look around by typing look with a cardinal direction (ex: Look North or ln).");
            Type("To move a direction simply type 'North' or 'N' for short (ex: N,S,E,W).");
            Type("To talk to characters nearby, type 'talk to' plus the name of the character. Good luck!");
            Type("Press ENTER to start.");
            Console.ReadLine();
            Matrix();
            Type("You find yourself in an open field with an old man and a chest nearby.");
            Choice1(player.Name);
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
            private int money;
            public int Money
            {
                get { return money; }
                set { money = value; }
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
            TypeIntro("PRESS ENTER TO START");
            Console.ReadLine();
            Console.Clear();
            Console.CursorVisible = true;
        }
        static void Type(string stringToType)
        {
            Random rnd = new Random();
            for (int i = 0; stringToType.Length - 1 >= i; i++)
            {
                System.Threading.Thread.Sleep(rnd.Next(1,125));
                Console.Write(stringToType[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void TypeIntro(string stringToType)
        {
            Console.SetCursorPosition((Console.WindowWidth - stringToType.Length) / 2, Console.CursorTop);
            for (int i = 0; stringToType.Length - 1 >= i; i++)
            {
                System.Threading.Thread.Sleep(300);
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
            for (int i = 1; i <= 35; i++)
            {
                System.Threading.Thread.Sleep(60);
                Console.WriteLine("");
            }
            Console.Clear();
            Console.WriteLine("");
        }
        static void Choice1(string nameVal)
        {
            Console.ResetColor();
            string direction = Console.ReadLine().ToLower(); 
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            switch (direction)
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
                    Choice1(nameVal);
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
                    Choice1(nameVal);
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
                    Choice1(nameVal);
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
                    Choice1(nameVal);
                    break;
                case "talk to old man":
                case "talk to man":
                    Type("The man looks you over and says 'be sure to look around before you embark on your journey,don't make the same mistakes I did.'");
                    Choice1(nameVal);
                    break;
                case "open chest":
                    Type("You have added a small dagger to your inventory");
                    Item dagger = new Item();
                    dagger.Name = "Dagger";
                    Choice1(nameVal);
                    break;
                case "inventory":
                    Type("You have a " + " in your posession");
                    Choice1(nameVal);
                    break;
                default:
                    Type("Please speak clearly...");
                    System.Threading.Thread.Sleep(2500);
                    Type("YA DUMBASS!!!");
                    Choice1(nameVal);
                    break;
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
