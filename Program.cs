using System;

namespace demo03.switchCase
{
    class Program
    {
            static void Main(string[] args)
            {
                int money = 0;
                string gender = "male";

            Console.WriteLine("What is your gender? male/female");
            gender = Console.ReadLine();

                switch (gender)
                {
                    case "male":
                        money += 10;
                        break;
                    case "female":
                        money += 20;
                        break;

                    default:
                        break;
                }
            Console.WriteLine("You are "+gender+".");
            Console.WriteLine("You get " + money + " from us.");
        }
    }
}

