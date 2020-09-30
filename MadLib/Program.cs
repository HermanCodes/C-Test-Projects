using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is to run a MadLib
            Author: Joshua Herman
            */


            // Let the user know that the program is starting:


            // Give the Mad Lib a title:
            string title = "Rose's are Red";

            Console.WriteLine(title);
            // Define user input and variables:


            // The template for the story:
            Console.WriteLine("The MadLib is now starting...");
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("What is your favourite colour?");
            string colour = Console.ReadLine();
            Console.WriteLine("How are you feeling right now?");
            string feeling = Console.ReadLine();
            Console.WriteLine("What is the worst texture?");
            string texture = Console.ReadLine();
            Console.WriteLine("Do you prefer to eat, sleep or run?");
            string action = Console.ReadLine();
            Console.WriteLine("Are you a Man or a Woman?");
            string sex = Console.ReadLine();
            Console.WriteLine("What is your favourite item?");
            string item = Console.ReadLine();
            Console.WriteLine("What is your favourite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favourite food?");
            string food = Console.ReadLine();
            Console.WriteLine("Please name a fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Who is your favourite superhero?");
            string superhero = Console.ReadLine();
            Console.WriteLine("What is your favourite country?");
            string country = Console.ReadLine();
            Console.WriteLine("What is your favourite dessert?");
            string dessert = Console.ReadLine();
            Console.WriteLine("What is your favourite year?");
            string year = Console.ReadLine();


            string story = $"This morning {yourName} woke up feeling {colour}. 'It is going to be a {feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {item}, which made all the {fruit}s very {texture}. Concerned, {yourName} texted {superhero}, who flew {yourName} to {country} and dropped {yourName} in a puddle of frozen {dessert}. {yourName} woke up in the year {year}, in a world where {sex}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}