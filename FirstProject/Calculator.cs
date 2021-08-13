using System;
using System.Collections.Generic;
using System.Text;

namespace primeiroprojeto
{
    class Calculator
    {
        public static double PI = 3.14;

        public static double Circunferencia(double raio) {
            return 2 * PI * raio;
        }

        public static double Volume(double raio) {
            return 4.0 / 3.0 * PI * Math.Pow(raio, 3);
        }
    }
}
