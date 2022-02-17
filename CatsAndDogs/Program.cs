using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or a dog?");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "CAT")
            {
                Console.WriteLine("You are a home-lover.");       //Cat lover
            }
            else if (userChoice == "Dog")
            {    
                Console.WriteLine("You are a partygoer.");       //Dog lover
            }
            else
            {
                Console.WriteLine($"You are a {userChoice} friend.");
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}
