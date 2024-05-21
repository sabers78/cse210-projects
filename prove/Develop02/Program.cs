using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {


        
        string randomPromptGenerator()
        {

            //list of prompts//
            List<string> prompt = new List<string>();
            prompt.Add("What was the Lords and in your life today?");
            prompt.Add("Describe something beautiful you saw today");
            prompt.Add("What are you grateful for today");
            prompt.Add("What miracle did you see today?");
            prompt.Add("When and how did you feel the Spirit today?");

            //mini random genorator//
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(prompt.Count);

            string randomPrompt = prompt[index];
            
            
            return randomPrompt;
        }
   



        //this is where the journal entrys are stored for now
        //List<string> currentJournal = new List<string>();
        string journalEntries = "journal.txt";
        

        //this function allows me to display important information over and over again.
        void addEntry()
        {
            //the prompt to write in the journal, and the where the program gives a random prompt.
            Console.WriteLine("Here is your prompt:");
            Console.WriteLine($"{randomPromptGenerator()}");
            Console.WriteLine("Go ahead and write in your journal on the line below:");
            string newEntry = Console.ReadLine();
            Console.WriteLine("and What is the date?");
            string theDate = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(journalEntries))
            {
                outputFile.WriteLine($"{theDate} {newEntry}");
            }
            

            //puts the date and the entry in a neat format
            
            //adds each new entry to the currentJournal list.
            //currentJournal.Add($"{newDate()} {newEntry}");

        }

        //asks for the date

        

        //asks the user if they would want to write a new entry.
        void displayMenu()
        {
            Console.WriteLine("What would you like to do next?");
            Console.WriteLine("(Pick a number)");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read Journals");
        }


        //actually run the program
        addEntry();
        displayMenu();

        //Save the file




        void reRunProgram()
        {
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                //go back and do everything again.
                addEntry();
                displayMenu();
                reRunProgram();

            }        
            else if (action == 2)
            {
                //foreach (string entry in currentJournal)
                //{
                //    Console.WriteLine(entry);
                //}

                string[] lines = System.IO.File.ReadAllLines(journalEntries);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        //this may try keep on going indeffiently. I may have to learn how to terminate functions.
        reRunProgram();
       
    }
}



