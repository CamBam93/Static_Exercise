using System;

namespace Static_Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cels = TempConverter.FahrenhietToCelsius(74);
            Console.WriteLine($"That temp in Celsius is {cels}");
            var fahr = TempConverter.CelsiusToFahrenhiet(14);
            Console.WriteLine($"That temp in fahrenhiet is {fahr}");
        }
    }
}
