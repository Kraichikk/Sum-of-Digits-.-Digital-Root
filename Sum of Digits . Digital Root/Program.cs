using System;

namespace Sum_of_Digits_._Digital_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method(129));
            Console.WriteLine(MethodAlternetive(129));
        }

        static int Method(long value)
        {
            int number = 0;
            string strValue = value.ToString();
            if (strValue.Length == 1)
                return Convert.ToInt32(value);
            else
                for (int i = 0; i < strValue.Length; i++)
                {
                    number += Convert.ToInt32(strValue[i].ToString());
                }
            string strNumber = number.ToString();
            if (strNumber.Length > 1)
                number = Method(number);

            return number;

        }

        static int MethodAlternetive(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
        public long DigitalRoot(long n)
        {
            return n < 10 ? n : DigitalRoot(n / 10 + n % 10);
        }
        public int DigitalRoot2(long n)
        {
            if (n < 10) return (int)n;
            long r = 0;
            while (n > 0)
            {
                r += n % 10;
                n /= 10;
            }
            return DigitalRoot2(r);
        }

    }
}
