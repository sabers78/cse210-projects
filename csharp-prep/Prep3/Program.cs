using System;

class Program
{
    static void Main(string[] args)
    {


        int guess = int.Parse("2");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        while (guess != magicNumber)
        {
            
        
            Console.Write("Guess the magic number:");
            guess = int.Parse(Console.ReadLine());
           
       
        
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine($"You got it! {guess} was the magic number!");
            }
        }
    }
}