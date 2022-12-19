using ConsoleApp39;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = double.Parse(Console.ReadLine());

        Solution solution = new(x, y);

        if (x >= -2 && x < 0) Console.WriteLine(solution.GetRightSideSolution());
        else if (x <= 2 && x > 0) Console.WriteLine(solution.GetRightSideSolution());
        else Console.WriteLine(solution.GetZeroSolution());
    }
}