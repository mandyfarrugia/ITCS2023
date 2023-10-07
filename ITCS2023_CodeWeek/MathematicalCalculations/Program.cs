using System;

namespace MathematicalCalculations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = 4;

            int answer = number1 + number2; //Addition
            Console.WriteLine($"2 + 4 = {answer}");

            answer = number2 - number1; //Subtraction
            Console.WriteLine($"4 - 2 = {answer}");

            answer = number1 * number2; //Multiplication
            Console.WriteLine($"2 x 4 = {answer}");

            answer = number2 / number1; //Division
            Console.WriteLine($"4 / 2 = {answer}");

            int anotherNumber = 50;
            Console.WriteLine(++anotherNumber); //This is a pre-fix notation.
            Console.WriteLine(anotherNumber++); //This is a post-fix notation.
            Console.WriteLine(anotherNumber);

            anotherNumber += 50; //anotherNumber = anotherNumber + 50;
            Console.WriteLine(anotherNumber);

            anotherNumber -= 50; //anotherNumber = anotherNumber - 50;
            Console.WriteLine(anotherNumber);

            anotherNumber *= 20; //anotherNumber = anotherNumber * 20;
            Console.WriteLine(anotherNumber);

            anotherNumber /= 2; //anotherNumber = anotherNumber / 2;
            Console.WriteLine(anotherNumber);

            Console.ReadLine();
        }
    }
}