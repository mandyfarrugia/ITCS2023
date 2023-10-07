namespace Variables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Variables consist of three important things:
             * 1) The type of data you want to store. Do you want to store numbers or text?
             * 2) What do you want to name your variable? Do NOT use C# keywords as otherwise the compiler will complain. 
             * 3) A value to be assigned to your variable. */

            int myNumber = 33; //Camel-case notation, a highly suggested variable naming convention.

            int number = 90;
            byte number2 = 2;
            short number3 = 533;
            long veryLongNumber = 98149252085398525;

            Console.WriteLine(myNumber);
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            /* Different ways of displaying output: 
             * 1) The traditional string concatenation. 
             * 2) Output parameters
             * 3) String interpolation */

            Console.WriteLine("This is what I have in the variable myNumber: " + myNumber + "\nA byte can store up to " + byte.MaxValue); //String concatenation.
            Console.WriteLine("An int can store up to {0} and it can start from {1}", int.MinValue, int.MaxValue); //Output parameters, least preferred method.
            Console.WriteLine($"The short can store from {short.MinValue} up until {short.MaxValue}."); //String interpolation - Add a dollar sign ($) BEFORE the opening double quote.

            Console.Write("How old are you?: ");
            int age = Convert.ToInt32(Console.ReadLine()); //By default, Console.ReadLine() is of type string. You need to convert accordingly if storing numeric input.
            Console.WriteLine($"You are {age} years old.");

            //By default, any decimal number in C# is of type double.
            double price = 3.45;
            float price2 = 10.99F; //If you do not add the F/f suffix, then the program will refuse to compile.
            decimal price3 = 1222535.3343524M; //If you do not add the M/m suffix, then the program will refuse to compile.

            byte verySmallContainer = (byte)veryLongNumber; //Force the long number into a byte variable - typecast/explicit conversion.
            Console.WriteLine($"{verySmallContainer}"); //Data loss because a long cannot go in a byte. :)

            int aDecentEnoughContainer = number3; //Implicit conversion - done automatically by the compiler.
            Console.WriteLine($"{aDecentEnoughContainer}"); //No data loss because a short can go in an int.

            string greeting = "Hello";
            Console.WriteLine(greeting);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Greetings, {name}!");

            Console.ReadLine(); //Leaves the output window until the Enter key is pressed.
        }
    }
}