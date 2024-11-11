using System;
using System.Xml.XPath;

public class Program
{
    public static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double price = GetPrices(product);

        double total = CalculateTotal(price, quantity);
        Console.WriteLine($"{total:F2}");
    }

    public static double GetPrices(string product)
    {
        double price = 0;

        switch(product)
        {
            case "water":
            price = 1.00;
            break;

            case "coke":
            price = 1.40;
            break;

            case "coffee":
            price = 1.50;
            break;

            case "snacks":
            price = 2.00;
            break;
        }
        return price;
    }

    public static double CalculateTotal(double price, int quantity)
    {
        double result = price * quantity;
        return result;
    }
}
