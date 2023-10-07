namespace ITCS2023_CodeWeek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Write and WriteLine are both used to display content in the output window.
             * However, WriteLine skips a line, whereas Write does not.
             * Therefore, when using Write, the content will be printed on the same line. */
            Console.Write("Welcome to Introduction to C#!"); //Displays the sentence "Welcome to Introduction to C#" in the output window.
            Console.WriteLine("We will be learning the basics from variables to methods.");

            /* \t - Represents a tab character.
             * \n - Represents a new line character to skip a line.
             * \\ - Represents a backslash character.
             * 
             * These are known as escape characters and can be used to format your output. */
            Console.WriteLine("Team\tGoals");
            Console.WriteLine("=========\n======\n=====");
            Console.WriteLine(@"C:\Users\Mandy\Downloads\image.gif");

            Console.ReadLine(); //Leaves the output window until the Enter key is pressed.
        }
    }
}