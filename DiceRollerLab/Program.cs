public class Program
{
    static int roll1;
    static int roll2;
    static int sum;
    static int sides;
    public static void Main()
    {
        
        while (true)
        {
            try
            {
                sides = int.Parse(GetUserInput("Enter how many sides the dice will have."));

                if(sides < 1)
                {
                    Console.WriteLine("Not a valid input");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Not a valid input");
                continue;
            }

            while (true)
            {
                Roller();
                bool check = RunAgain();
                if (check == false)
                {
                    break;
                }
            }
            break;
        }
    }

    public static void Roller()
    {
        Random dice = new Random();

        roll1 = dice.Next(1, sides+1);
        roll2 = dice.Next(1, sides+1);
        sum = roll1 + roll2;
        if (sides == 6)
        {
            SixSided();
        }
        Console.WriteLine($"You rolled a {roll1} and a {roll2} ({sum} total)");
    }

    public static void SixSided()
    {
        if (roll1 == 1 && roll2 == 1)
        {
            Console.WriteLine("Snake eyes!");
        }
        if (roll1 == 1 && roll2 == 2)
        {
            Console.WriteLine("Ace deuce!");
        }
        if (roll1 == 6 && roll2 == 6)
        {
            Console.WriteLine("Box cars!");
        }
        if (sum == 7 || sum == 11)
        {
            Console.WriteLine("A win!");
        }
        if (sum == 2 || sum == 3 || sum == 12)
        {
            Console.WriteLine("Some craps...");
        }
    }

    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string output = Console.ReadLine();
        return output;
    }

    public static bool RunAgain()
    {
        string input = GetUserInput("Would you like to roll again? Y/N");

        if (input == "y")
        {
            return true;
        }
        else if (input == "n")
        {
            Console.WriteLine("GoodBye");
            return false;
        }
        else
        {
            Console.WriteLine("I didn't understand that lets try again");
            return RunAgain();
        }
    }
}