using System;
/* Solution Explorer on right (A Solution can contain multiple projects)
   NAMESPACE IS A WAY OF ORGANIZING CODE
   READ UP ON OOP */
namespace JelloBorld
{
    // BELOW IS A CLASS CALLED "Program"
    // CLASSES ARE CONTAINERS FOR ALL OF THE METHODS IN YOUR PROGRAM
    class Program
    {
    // BELOW IS A METHOD CALLED MAIN static=not changing | void=not returning a value
        static void Main(string[] args)
        // THIS IS A CODE BLOCK CALLED "Main"
        {
            // CONSOLE IS A CLASS
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hello and welcome to the GREATEST GAME EVER CREATED! What's your name");
            Console.Write("?");
            // READ LINE IS A METHOD THAT WAITS FOR THE USER TO PUSH ENTER
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name + "!? That's a stupid fucking name! Suit yourself loser...");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Which direction would you like to go? (North, South, East, West)");
            Choice1(name);
            //Donkey();
        }
        /* Public = anyone can read this | int = integer
        int x = 0;
        static void Donkey(int x=1)
        {
            x = x + 1;
            Console.WriteLine(x);
            Console.ReadLine();
        }
        */
        static void Choice1(string nameVal)
        {
            Console.ResetColor();
            string name = nameVal;
            string direction = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            if (direction == "North" || direction == "north")
            {
                Console.WriteLine("You ran into a wall and suffered a traumatic brain injury...");
                Death(name);
            }
            else if (direction == "South" || direction == "south")
            {
                Console.WriteLine("You find yourself in a frozen tundra and get a gnarly case of frostbite...");
                Death(name);
            }
            else if (direction == "East" || direction == "east")
            {
                Console.WriteLine("The sun is rising and you can feel it's warmth. YOU WON THE GAME!");
                Console.ReadLine();
            }
            else if (direction == "West" || direction == "west")
            {
                Console.WriteLine("The warmth of the sunrise can be felt on your back. An animal sneaks up and eats you...");
                Death(name);
            }
            else
            {
                Console.WriteLine("Please input a cardinal direction...");
                System.Threading.Thread.Sleep(2500);
                Console.WriteLine("YA DUMBASS!");
                Choice1(name);
            }
        }
        static void Death(string nameVal)
        {
            string name = nameVal;
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You die.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Try making better choices next time, " + name + "!!!");
            Console.ReadLine();
        }
    }
}
