// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Globalization;
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("date ? : ");

            string words = Console.ReadLine();

           
            if (words == "exits")
            {
                break;
            }

            
            if (DateTime.TryParse(words, out DateTime datebrought))
            {
                DateTime todaysdate = DateTime.Now;

                
                if (datebrought < todaysdate)
                {
                    TimeSpan intervals = todaysdate - datebrought;
                    Console.WriteLine($"The date you entered was {intervals.Days} days ago.");
                }
                else if (datebrought > todaysdate)
                {
                    TimeSpan intervals = datebrought - todaysdate;
                    Console.WriteLine($"The date you entered is in {intervals.Days} days.");
                }
                else
                {
                    Console.WriteLine("you inputed todaysdate");
                }
            }
            else
            {
                Console.WriteLine("invalid please try again another time......!!!");
            }
        }
    }
}
