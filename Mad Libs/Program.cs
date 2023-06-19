using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            This program: Mad Libs
            Author: Michael
            */


            Console.WriteLine("Here begins a mad libs project, participate if you wish.\n");


            string title = "Michael's Mad Lib";
            Console.WriteLine(title);


            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter a feeling: ");
            string feeling = Console.ReadLine();

            Console.WriteLine("Enter a texture: ");
            string texture = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter a noun(person): ");
            string person = Console.ReadLine();

            Console.WriteLine("Enter a people: ");
            string people = Console.ReadLine();

            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food: ");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.WriteLine("Enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            string year = Console.ReadLine();



            // The template for the story:

            string story = $"This morning {name} woke up feeling {color}. 'It is going to be a {feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {person}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {people}s ruled the world.";


            Console.WriteLine(story);
        }
    }
}
