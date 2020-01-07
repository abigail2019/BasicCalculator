using System;
using Operation;

namespace BasicCalculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return Addition.Sum(a,b);
        }
        public int Divid(int a, int b)
        {
            return Division.Divsion(a, b);
        }
    }
}
