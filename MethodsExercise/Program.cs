using System;

namespace MethodsExercise
{


    public class Program
    {


        static void Main(string[] args)
        {
            ShortStory();

            int added = Add(5,3);
            Console.WriteLine(added);

            int subtracted = Subtract(5,3);
            Console.WriteLine(subtracted);

            int muliplied = Multiply(3,5);
            Console.WriteLine(muliplied);

            int divide = Divide(10,5);
            Console.WriteLine(divide);
        }

        public static void ShortStory() 
        { 
         Console.WriteLine("What is your name ?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color ?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite kind of music ?");
            var music = Console.ReadLine();

            Console.WriteLine($"Your name is {name}, your favorite color is {color}, your favorite animal is {animal}, and your favorite kind of music is {music}.");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        { 
            return num1 - num2; 
        }

        public static int Multiply(int num1, int num2) 
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        { 
            return num1 / num2; 
        }
    } 
}

