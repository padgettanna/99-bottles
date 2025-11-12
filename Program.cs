namespace _99Bottles;

public class Program
{
    public static void Main(string[] args)
    {
        var numBottles = 10;
        int counter = 0;

        Console.WriteLine($"Welcome to the {numBottles} Bottles of Learning To Code Application!");
        Console.WriteLine();

        while (counter <= numBottles)
        {
            //make this logic into one or more methods:
            if (numBottles - counter > 1)
            {
                PrintVerseMultipleBottles(numBottles, counter);
            }
            else if (numBottles - counter == 1)
            {
                PrintVerseOneBottle(numBottles, counter);
            }
            else
            {
                PrintVerseNoBottles();
                numBottles = GetMoreBeer();

                if (numBottles != 0)
                {
                    Console.WriteLine($"Purchased {numBottles} {(numBottles == 1 ? "bottle" : "bottles")} of beer");
                    counter = -1;
                }
            }
            Console.WriteLine();
            counter++;
        }

        Console.WriteLine($"Thank you for using the {numBottles} bottles of learning to code application!\nPlease press any key to continue");
        Console.ReadKey();
    }

    public static void PrintVerseMultipleBottles(int numBottles, int counter)
    {
        Console.WriteLine($"{numBottles - counter} bottles of beer on the wall, {numBottles - counter} bottles of beer.");
        var nextCount = numBottles - (counter + 1);
        var word = nextCount == 1 ? "bottle" : "bottles";
        Console.WriteLine($"Take one down, pass it around, {nextCount} {word} of beer on the wall.");
    }

    public static void PrintVerseOneBottle(int numBottles, int counter)
    {
        Console.WriteLine($"{numBottles - counter} bottle of beer on the wall, {numBottles - counter} bottle of beer.");
        Console.WriteLine($"Take one down, pass it around, no more bottles of beer on the wall.");
    }
    
    public static void PrintVerseNoBottles()
    {
        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
        Console.WriteLine($"Go to the store, buy some more.");
    }

    public static int GetMoreBeer()
    {
        Console.WriteLine("How many bottles of beer do you want to buy [1-24] [Enter 0 to quit]?");
        int amount;
        bool validAmount;

        do
        {
            validAmount = int.TryParse(Console.ReadLine(), out amount);
            if (!validAmount)
            {
                Console.WriteLine("Invalid input. Enter a number");
            }
            if (amount < 0 || amount > 24)
            {
                validAmount = false;
                Console.WriteLine("Invalid input. Enter value between 1 and 24, or 0 to quit");
            }
        } while (!validAmount);
        return amount;
    }
}