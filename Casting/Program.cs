using ImplicitOperator;
namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new(20);
            Celcius celcius = kelvin;
            Console.WriteLine(celcius.Degree);
        }

    }
}
