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
            Console.WriteLine("Jello Borld! What's your name?");
            // READ LINE IS A METHOD THAT WAITS FOR THE USER TO PUSH ENTER
            string name = Console.ReadLine();
            Console.WriteLine(name + ", haha that's a stupid fucking name!");
            Console.ReadLine();
            Donkey();
        }
        // Public = anyone can read this | int = integer
        int x = 0;
        static void Donkey(int x=1)
        {
            x = x + 1;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
