using System;

class Program
{
    delegate double MyDelegate(Action<char> action, bool flag, double x, double y);

    static void Main(string[] args)
    {
        MyDelegate myDelegate = (action, flag, x, y) =>
        {
            action('A');
            double result = x + y;
            if (flag)
            {
                result *= 2;
            }
            return result;
        };

        double value1 = myDelegate(Console.WriteLine, true, 2.0, 3.0);
        double value2 = myDelegate(Console.Write, false, 4.0, 5.0);

        Console.WriteLine($"value1 = {value1}, value2 = {value2}");
    }
}