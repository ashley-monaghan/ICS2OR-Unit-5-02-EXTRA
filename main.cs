// Created by: Ashley Monaghan
// Created on: Nov 2022
//
//This program converts Fahrenheit to Celsius

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int userNumber;
        int randomNumber;

        Console.WriteLine("Would you like a positive or negative number?");
        Console.WriteLine("");

        Console.Write("Enter '1' if positive or '2' if negative ");
        Console.WriteLine("");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();

        Console.WriteLine("");
        if(userNumber == 1)
        {
          randomNumber = rnd.Next(1, 6);
          Console.WriteLine("Your random number is: " + randomNumber);
        }
         else
        {
          randomNumber = rnd.Next(-6, -1);
          Console.WriteLine("Your random number is: " + randomNumber);
        }

        Console.WriteLine("\nDone.");
    }
}