namespace _99Bottles;

public class Program
{
    public static void Main(string[] args)
    {
        int numBottles = 10;
        int counter = 0;
        string bottles = "bottles";

        while (numBottles - counter > 0)
        {
            Console.WriteLine($"{numBottles - counter} {bottles} of beer on the wall, {numBottles - counter} {bottles} of beer.");
            counter++;
            bottles = (numBottles - counter != 1) ? "bottles" : "bottle";
            Console.WriteLine($"Take one down and pass it around, {numBottles - counter} {bottles} of beer on the wall.");
            Console.WriteLine();
        }

        Console.WriteLine($"No more {bottles} of beer on the wall, no more {bottles} of beer.");
        Console.WriteLine($"Go to the store, buy some more, {numBottles} {bottles} of beer on the wall.");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        
    }
}