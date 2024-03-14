using Casting;

namespace ImplicitOperator
{
    internal class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.Degree - 273.15);
        }
    }
}
