using KnowledgeCheck2;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<newShoe>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var newShoe = new newShoe();

            Console.WriteLine("Enter the value for ");
            newShoe.workBoots = Console.ReadLine();

            recordList.Add(newShoe);
        }

        // Print out the list of records using Console.WriteLine()

        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                var newShoe = new newShoe();

                Console.WriteLine("Creating new shoe");

                Console.Write("Enter the style of the shoe: ");
                newShoe.Name = Console.ReadLine();

                Console.Write("Give the product a short description: ");
                newShoe.Description = Console.ReadLine();

                Console.Write("Give the product a price: ");
                newShoe.Price = decimal.Parse(Console.ReadLine());

                Console.Write("How many products do you have on hand? ");
                newShoe.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine(JsonSerializer.Serialize(newShoe));
            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}