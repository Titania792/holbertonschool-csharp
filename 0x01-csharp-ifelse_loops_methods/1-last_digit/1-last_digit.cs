using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % (10);
        string str = "";
        if (lastDigit > 5)
            str = "and is greater than 5";
        else if (lastDigit == 0)
            str = "and is 0";
        else
            str = "and is less than 6 and not 0";
        Console.WriteLine("The last digit of {0} is {1} {2}", number, lastDigit, str);
    }
}