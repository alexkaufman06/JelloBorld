using System;
/* Solution Explorer on right (A Solution can contain multiple projects)
   NAMESPACE IS A WAY OF ORGANIZING CODE
   READ UP ON OOP */
namespace JelloBorld
{
    class Program // CLASSES ARE CONTAINERS FOR ALL THE METHODS IN A PROGRAM
    {
    // BELOW IS A METHOD CALLED MAIN static=not changing | void=not returning a value
        static void Main(string[] args)
        { // THIS IS A CODE BLOCK CALLED "Main"
            Console.ForegroundColor = ConsoleColor.Green; // CONSOLE IS A CLASS
            Matrix();
            Type("Hello and welcome to the GREATEST GAME EVER CREATED! What's your name?");
            Console.ResetColor();
            string name = Console.ReadLine(); // READ LINE IS A METHOD THAT WAITS FOR THE USER TO PUSH ENTER
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Type(name + "!? That's a stupid fucking name! Suit yourself loser...");
            System.Threading.Thread.Sleep(2500);
            Type("Which direction would you like to go? (North, South, East, or West)");
            Choice1(name);
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
        static void Matrix()
        {
            Random rnd = new Random();
            for (int i = 1; i <= 90; i++)
            {
                string binary = "";
                for (int j = 1; j <= 90; j++)
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
            }
            // BELOW SCROLLS THE BINARY OUT OF VIEW
            for (int i = 1; i <= 35; i++)
            {
                System.Threading.Thread.Sleep(60);
                Console.WriteLine("");
            }
            Console.Clear();
        }
        static void Choice1(string nameVal)
        {
            Console.ResetColor();
            string direction = Console.ReadLine(); // method here
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            if (direction == "North" || direction == "north") //Add toLower method on input remove OR statement
                                                              // Then turn if statement into case (maybe)
                                                              // Make class called item with parameters to hold onto things
                                                              // Has height, width, weight (parent class)
                                                              // Then make classes built off of the parent class that define a weapon, a wearable (backpack/armor), or gear (like a key)
                                                              // Machine language vs assembly
            {
                Type("You ran into a wall and suffered a traumatic brain injury...");
                Death(nameVal);
            }
            else if (direction == "South" || direction == "south")
            {
                Type("You find yourself in a frozen tundra and get a gnarly case of frostbite...");
                Death(nameVal);
            }
            else if (direction == "East" || direction == "east")
            {
                Type("The sun is rising and you can feel its warmth. YOU WON THE GAME! Not only did you win the " +
                     "game, but you also succeeded in re-routing the encryptor while hacking into the mainframe!");
                System.Threading.Thread.Sleep(2500);
                Matrix();
                Type("Great job " + nameVal + "!!!");
                System.Threading.Thread.Sleep(2500);
            }
            else if (direction == "West" || direction == "west")
            {
                Type("The warmth of the sunrise can be felt on your back. An animal sneaks up and eats you...");
                Death(nameVal);
            }
            else
            {
                Type("Please input a cardinal direction...");
                System.Threading.Thread.Sleep(2500);
                Type("YA DUMBASS!!!");
                Choice1(nameVal);
            }
        }
        static void Death(string nameVal)
        {
            System.Threading.Thread.Sleep(3000);
            Type("You die.");
            System.Threading.Thread.Sleep(1500);
            Type("Try making better choices next time, " + nameVal + "!!!");
            System.Threading.Thread.Sleep(2500);
            Matrix();
        }
    }
}
