// Created by: Kenny Le
// Created on: May 2022
//
// This program determines what type of movie you can see

using System;

class Program
{
    public static void Main(string[] args)
    {
        int date;
        int age;

        // input
        Console.WriteLine("What will the price of the museum admission be?");
        Console.WriteLine("");

        Console.WriteLine("Please enter the day");
        Console.WriteLine("");
        Console.WriteLine("1 - Sunday");
        Console.WriteLine("2 - Monday");
        Console.WriteLine("3 - Tuesday");
        Console.WriteLine("4 - Wednesday");
        Console.WriteLine("5 - Thursday");
        Console.WriteLine("6 - Friday");
        Console.WriteLine("7 - Saturday");
        date = Convert.ToInt32(Console.ReadLine());

        // process and output
        if (date > 7 || date < 1)
        {
            Console.Clear();
            Console.WriteLine("Please input a valid date");
        }

        // input
        Console.WriteLine("");
        Console.WriteLine("Please enter your age:");
        age = Convert.ToInt32(Console.ReadLine());

        // process and output
        if ((date == 3 || date == 5) && (age > 12 && age < 21))
        {
            Console.WriteLine("You are eligible for student pricing!");
        }
        else
        {
            Console.WriteLine("You must pay regular price.");
        }

        Console.WriteLine("\nDone.");
    }
}