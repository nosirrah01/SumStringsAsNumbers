using System.Numerics;

namespace SumStringsAsNumbers
{
    public class Kata
    {
        public static string sumStrings(string a, string b)
        {
            BigInteger biA = 0;
            BigInteger biB = 0;
            if(a != "")
                biA = BigInteger.Parse(a);
            if(b != "")
                biB = BigInteger.Parse(b);
            BigInteger sum = biA + biB;
            return sum.ToString();
        }
    }
}
