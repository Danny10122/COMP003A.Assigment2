 /*
    Author: Daniel Juarez
    Course: COMP-003A
    Faculty: Danel juarez
    Purpose: Discount calculator
 */
namespace COMP003A.Assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName; // Variable to store the user's name
            int userAge; // Variable to store the user's age
            bool isStudent; // Variable to store if the user is a student (true/false)
            double productPrice; // Variable to store the product price

            Console.WriteLine("Welcome to the Discount Calculator!");
            Console.WriteLine("\nWhat is your first and last name?");
            userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            userAge = int.Parse(Console.ReadLine()); // Convert and assign the user's input to userAge
            Console.WriteLine("What is the price of the item you're interested in?");
            productPrice = double.Parse(Console.ReadLine()); // Convert and assign the user's input to productPrice
            Console.WriteLine("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());
            int futureAge = userAge + 5; // Calculate the user's age in 5 years
                string username = Console.ReadLine(); // gets the user input and it to
                Console.WriteLine($"\n\n\nHello," + userName + "!"); // Great the user with their name
            Console.WriteLine($"You are curremtly {userAge} years old. \nIn 5 years, you will be {futureAge}."); // Display current and future age 
            Console.WriteLine($"The original price of the item is ${productPrice}."); // Display the price 
            Console.WriteLine($"As a student, your discounted price is ${productPrice * .9}."); // Display the price 
            Console.WriteLine($"As a senior citizen, your discounted price would be ${productPrice * .8}."); // Display the price 



        }
    }
}