namespace Topic2Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to count");
            Console.WriteLine("Hens" + (10 + 5 * 2));
            Console.WriteLine("Roosters" + (25 + 30 / 6));
            //running program puts down the quoted word and the answer to the math without displaying the math.
            Console.WriteLine("Six" + 6); //Displays quoted word and number
            Console.WriteLine("6 + 6"); //Shows the equation without the answer
            Console.WriteLine("6" + 6); //number outside quotes acts as exponant
            Console.WriteLine(6 + 6); //Shows the answer only
            Console.WriteLine("       ");
            Console.WriteLine("         ");
            Console.WriteLine("           ");
            Console.WriteLine("Now to divide!");
            Console.WriteLine(11 / 2); //Integers, not decimals
            Console.WriteLine(11.0 / 2); //Decimals, not integers
            Console.WriteLine("       ");
            Console.WriteLine("         ");
            Console.WriteLine("           ");
            Console.WriteLine("Is it true 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7); //Shows as "false" rather than display the equation or answer.
            Console.WriteLine("What is 3 + 2? " + (3 + 2));

            Console.WriteLine("What is 5 - 7? " + (5 - 7));
            Console.WriteLine("Huh, so that's why it's " + (3 + 2 < 5 - 7));
            Console.WriteLine("       ");
            Console.WriteLine("         ");
            Console.WriteLine("           ");
            Console.WriteLine("You work 8 hours and earn 21$ per hour. How much do you earn total?");
            Console.WriteLine("You earn " + (8 * 21) + " which makes 168$");
            Console.WriteLine("       ");
            Console.WriteLine("         ");
            Console.WriteLine("6$ for a dozen eggs, how much does each egg cost?");
            Console.WriteLine((12.0 / 6.0) + "$" + " per egg");
            Console.WriteLine("       ");
            Console.WriteLine("         ");
            Console.WriteLine("           ");
        }
    }
}
