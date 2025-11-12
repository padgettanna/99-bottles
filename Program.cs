namespace _99Bottles;

public class Program
{
    public static void Main(string[] args)
    {
        int numBottles = 5;
        int counter = 0;
        string bottles = "bottles";

        Console.WriteLine($"Welcome to the {numBottles} Bottles of Learning To Code Application!");
        Console.WriteLine();

        while (counter < numBottles)
        {
            Console.WriteLine($"{numBottles - counter} {bottles} of beer on the wall, {numBottles - counter} {bottles} of beer.");
            counter++;
            bottles = (numBottles - counter != 1) ? "bottles" : "bottle";
            if (numBottles - counter > 0)
            {
                Console.WriteLine($"Take one down and pass it around, {numBottles - counter} {bottles} of beer on the wall.");
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine($"Take one down and pass it around, no more {bottles} of beer on the wall.");
                Console.WriteLine();
                Console.WriteLine($"No more {bottles} of beer on the wall, no more {bottles} of beer.");
                Console.WriteLine("Go to the store, buy some more.");
                Console.WriteLine("How many bottles of beer do you want to buy? [Enter 0 to quit]");
                numBottles = int.Parse(Console.ReadLine());
                counter = 0;
                if (numBottles > 0)
                {
                    Console.WriteLine($"Purchased {numBottles} {bottles} of beer.");
                }
        
                //Console.WriteLine($"{numBottles} {bottles} of beer on the wall.");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            
        }
    }
}