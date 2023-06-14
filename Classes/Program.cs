namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2008;

            Console.WriteLine($"{myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
