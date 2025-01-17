using LibA;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            var adder = new Adder();
            return adder.Sum(a, b);
        }
    }
}