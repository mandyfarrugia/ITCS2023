namespace ControlStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int DRIVING_MINIMUM_AGE_IN_MALTA = 18; //Declaring a constant - value is set once and never changes throughout the lifetime of the program.

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            /* < - smaller/less than
             * <= - smaller than or equal to
             * > - greater than
             * >= - greater than or equal to 
             * != - not equal to
             * == - equal to */
            if (age >= DRIVING_MINIMUM_AGE_IN_MALTA)
            {
                Console.WriteLine("You are allowed to drive!");
            }
            else
            {
                Console.WriteLine("You are NOT allowed to drive, sorry!");
            }

            int counter = 0;

            do
            {
                Console.WriteLine($"{counter + 1} - Hello World!"); //Print Hello World 20 times.
                counter++; //Same as counter + 1.
            }
            while (counter < 20);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1} - Good morning!"); //Print Good morning five times.
            }

            Console.ReadLine();
        }
    }
}