using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = InputUserName();
        int userNumber = InputUserNumber();

        int square = SquareNumbers(userNumber);

        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string InputUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int InputUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumbers(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
    Console.Write($"{name}, the square of your number is {square}");
    }
    
}