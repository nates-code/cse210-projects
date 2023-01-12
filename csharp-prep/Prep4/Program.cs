using System;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numList = new List<int>();
        int number = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numList.Add(number);
            }
        }

        int sum = numList.Sum();
        double average = numList.Average();
        int maxNum = numList.Max();

        Console.WriteLine($"The sum is: {sum}"); 
        Console.WriteLine($"The average is: {average}"); 
        Console.WriteLine($"The largest number is: {maxNum}"); 

        //Another way...
        // foreach ()
        // {
            
        // }
        


    }
}