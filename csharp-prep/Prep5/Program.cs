using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string futureName = PromptUserName();
        int userNumber = PromptUserNumber();
        int finishedSqaure = SquareNumber(userNumber);
        DisplayResult(futureName,finishedSqaure);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();

            return username;
        }

        static int PromptUserNumber()
        {
            
            Console.WriteLine("What is your favorite number?");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;

        }

        static int SquareNumber(int userNumber)
        {
            int yourSquare = userNumber * userNumber;

            return yourSquare;
        }

        static void DisplayResult(string username, int yourSqaure)
        {
            Console.WriteLine($"{username}, the sqaure of your number is {yourSqaure}.");
        }
    }    
}
