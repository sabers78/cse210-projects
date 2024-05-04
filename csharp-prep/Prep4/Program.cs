using System;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int userNumber = int.Parse("2");
        
        List<int> numberList = new List<int>();


        while (userNumber != 0)
        {
            Console.WriteLine("enter one number one at a time. enter 0 when you want to stop");
            userNumber = int.Parse(Console.ReadLine());
            
            
            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }    
        }
        int blankSum = int.Parse("0");
        foreach (int answer in numberList)
        {
            blankSum += answer;
        }

        int answerSize = int.Parse("0");
        foreach (int answer in numberList)
        {
            answerSize = numberList.Count;
        }
        float average = (((float)blankSum) / answerSize);


        int largestNumber = int.Parse("0");
        foreach (int answer in numberList)
        {
            if (answer >= largestNumber)
            {
                largestNumber = answer;
            }
        }

        Console.WriteLine($"The sum is {blankSum}");

        Console.WriteLine($"The average is {average:0.00##}");

        Console.WriteLine($"The largest number is {largestNumber}");
    }   
}