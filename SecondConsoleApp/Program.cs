using System;

namespace SecondConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            String name;
            int num1 = 0;
            int num2 = 0;
            


            //Display the Title of the app
            Console.WriteLine("Console Application ");
            Console.WriteLine("Made By Mamadou Sow\n");

            //Get the user input
            Console.WriteLine("What's your name? ");
            name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Hello " + name);

            Console.WriteLine("\n");
            Console.WriteLine("Enter your first number... ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number... ");
            num2 = Convert.ToInt32(Console.ReadLine());

            

            //Create an option
            Console.WriteLine("\ta - add");
            Console.WriteLine("\ts - substract");
            Console.WriteLine("\tm - multiplication");
            Console.Write("This is ypur Option?  ");

            //Make the switch

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"RESULT: {num1} + {num2}  = "  + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine($"RESULT: {num1} - {num2}  = " + (num1 - num2 ));
                    break;
                case "m":
                    Console.WriteLine($"RESULT: {num1} * {num2}  = " + (num1 * num2 ));
                    break;
               
            }
            Console.WriteLine("Press any key to quit the programm....");
            Console.ReadKey();


        }
    }
}
