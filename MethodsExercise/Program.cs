using System;

namespace MethodsExercise
{
    public class Program
    {

        static void Main(string[] args)
        {   Console.WriteLine("What is your name ?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color ?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite kind of music ?");
            var music = Console.ReadLine();

            Console.WriteLine($"Your name is {name}, your favorite color is {color}, your favorite animal is {animal}, and your favorite kind of music is {music}.");
        }
    }
}

