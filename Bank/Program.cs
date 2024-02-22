// See https://aka.ms/new-console-template for more information
using Bank;

Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Vietnamese vietnamese = new Vietnamese();
        Console.WriteLine("Enter infors: ");
        Console.Write("ID: ");
        vietnamese.ID = Console.ReadLine();
        Console.Write("Name:");
        vietnamese.Name = Console.ReadLine();
        Console.Write("Date(yy-MM-dd: ");
        vietnamese.InvoiceDate = DateTime.Parse(Console.ReadLine());
        Console.Write("CustomerType: ");
        vietnamese.CustomerType = Console.ReadLine();
        Console.Write("Quantity: ");
        vietnamese.Quantity = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        vietnamese.Price = double.Parse(Console.ReadLine());

        Foreigner foreigner = new Foreigner();
        Console.WriteLine("\nEnter infors: ");
        Console.Write("ID: ");
        foreigner.ID = Console.ReadLine();
        Console.Write("Name:");
        foreigner.Name = Console.ReadLine();
        Console.Write("Date(yy-MM-dd: ");
        foreigner.InvoiceDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Nationality: ");
        foreigner.Nationality = Console.ReadLine();
        Console.Write("Quantity: ");
        foreigner.Quantity = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        foreigner.Price = double.Parse(Console.ReadLine());

        Console.WriteLine("Total:");
        Console.WriteLine("Vietnamese: " + vietnamese.Calculate());
        Console.WriteLine("Forigner: " + foreigner.Calculate());


    }
}