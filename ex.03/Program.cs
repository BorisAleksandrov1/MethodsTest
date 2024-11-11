using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string row = GetRow(num);
        string matrix = GetMatrix(row, num);
        System.Console.WriteLine(GetMatrix(row, num));
    }

    public static string GetRow(int num)
    {
        string row = "";
        for (int i = 0; i <= num; i++)
        {
            row += $"{num} ";
        }
        return row.TrimEnd();
    }

    public static string GetMatrix(string row, int num)
    {
        string matrix = "";
        for (int i = 0; i <= num; i++)
        {
            matrix += $"{row}\n";
        }
        return matrix.TrimEnd();
    }
}
