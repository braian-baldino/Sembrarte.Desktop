using System;

namespace Infrastructure.Utilities
{
    public static class Calculator
    {
        private static double IVA = 1.21;

        public static double CalculateIVA(double price) => price * IVA;
        public static double ApplyPorcentage(double price, int porcentage) => Math.Round(price + ((price * porcentage) / 100), 2);
    }
}
