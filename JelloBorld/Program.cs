using System;

// NAMESPACE IS A WAY OF ORGANIZING CODE
// READ UP ON OOP
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
            Console.WriteLine("Hello and welcome to the greatest game ever created! What's your name?");
            // READ LINE IS A METHOD THAT WAITS FOR THE USER TO PUSH ENTER
            string name = Console.ReadLine();
            Console.WriteLine(name + "!?, that's a stupid fucking name! Suit yourself loser...");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("Which direction would you like to go? (North, South, East, West)");
            Choice1(name);
            //Donkey();
        }
        // Public = anyone can read this | int = integer
        int x = 0;
        static void Donkey(int x=1)
        {
            x = x + 1;
            Console.WriteLine(x);
            Console.ReadLine();
        }
        static void Choice1(string nameVal)
        {
            string name = nameVal;
            string direction = Console.ReadLine();
            if (direction == "North" || direction == "north")
            {
                Console.WriteLine("You ran into a wall and died... LOSER!");
                System.Threading.Thread.Sleep(3500);
            }
            else if (direction == "South" || direction == "south")
            {
                Console.WriteLine("You froze to death. Try making better choices " + name + "!!!");
                System.Threading.Thread.Sleep(3500);
            }
            else if (direction == "East" || direction == "east")
            {
                Console.WriteLine("The sun is rising and you can feel it's warmth. You won the game!");
                System.Threading.Thread.Sleep(3500);
            }
            else if (direction == "West" || direction == "west")
            {
                Console.WriteLine("The warmth of the sunrise can be felt on your back. An animal sneaks up and eats you...");
                System.Threading.Thread.Sleep(3500);
            }
            else
            {
                Console.WriteLine("Please input a cardinal direction...");
                System.Threading.Thread.Sleep(3500);
                Console.WriteLine("YA DUMBASS!");
                Choice1(name);
            }
        }
    }
}
