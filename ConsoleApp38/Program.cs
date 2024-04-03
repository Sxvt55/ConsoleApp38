namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Triangle triangle = new Triangle(34,45);
         //   Console.WriteLine($"Triangle area:{triangle.CalculateArea()}");

         //   Square square = new Square(42);
         //   Console.WriteLine($"Square area:{square.CalculateArea()}");

         //   Circle circle = new Circle(5);
         //   Console.WriteLine($"Circle area:{circle.CalculateArea()}");

            SavingsAccount savings = new SavingsAccount(1);

            savings.Deposit(23);

        }
    }
}
