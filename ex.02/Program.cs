using System;

public class Program
{
    public static void Main(string[] args)
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());
        int result = 0;

        result = GetSumOfTwo(input1, input2);
        result = GetSubtractOfTwo(result, input3);

        System.Console.WriteLine(result);

    }
    public static int GetSumOfTwo(int input1, int input2)
    {
        return input1 + input2;
    }

    public static int GetSubtractOfTwo(int input1, int input2)
    {
        return input1 - input2;
    }
}
