using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Exer
{
    public static class TempConverter
    {
        public static double FahrenhietToCelsius(double fahrenhiet)
        {
            var c = (fahrenhiet - 32) / 1.8;
            return c;
        }

        public static double CelsiusToFahrenhiet(double celcius)
        {
            var f = (celcius * 9) / 5 + 32;
            return f;
        }
    }
}
