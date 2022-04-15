namespace CommandManager.Libs;

public static class CalculationMethods
{
    private static double GetNumber()
    {
        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Not a number");
            return 0;
        }
    }

    public static void AddHandle()
    {
        Console.Clear();
        Console.WriteLine("Enter numbers for add.");
        Console.Write("Enter first number: ");
        double num1 = GetNumber();
        Console.Write("Enter second number: ");
        double num2 = GetNumber();
        Console.WriteLine($"Result: {MathController.Add(num1, num2)}");
        Console.WriteLine("Press any key for go to main menu");
        Console.ReadKey();
        Console.Clear();
    }
    public static void MultiplyHandle()
    {
        Console.Clear();
        Console.WriteLine("Enter numbers for multiply.");
        Console.Write("Enter first number: ");
        double num1 = GetNumber();
        Console.Write("Enter second number: ");
        double num2 = GetNumber();
        Console.WriteLine($"Result: {MathController.Multiply(num1, num2)}");
        Console.WriteLine("Press any key for go to main menu");
        Console.ReadKey();
        Console.Clear();
    }
    public static void SubstractHandle()
    {
        Console.Clear();
        Console.WriteLine("Enter numbers for substract.");
        Console.Write("Enter first number: ");
        double num1 = GetNumber();
        Console.Write("Enter second number: ");
        double num2 = GetNumber();
        Console.WriteLine($"Result: {MathController.Substract(num1, num2)}");
        Console.WriteLine("Press any key for go to main menu");
        Console.ReadKey();
        Console.Clear();
    }
    public static void DivideHandle()
    {
        Console.Clear();
        Console.WriteLine("Enter numbers for divide.");
        Console.Write("Enter first number: ");
        double num1 = GetNumber();
        Console.Write("Enter second number: ");
        double num2 = GetNumber();
        Console.WriteLine($"Result: {MathController.Divide(num1, num2)}");
        Console.WriteLine("Press any key for go to main menu");
        Console.ReadKey();
        Console.Clear();
    }
}