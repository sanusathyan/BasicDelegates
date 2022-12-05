using System;

namespace MulArgInt
{
    public delegate int delegateSum(int firstnum, int secondnum);
    class MulArgInt
    {
        static void Main(string[] args)
        {
            var sumOfNum = new delegateSum(GetSum);
            Console.WriteLine( sumOfNum.Invoke(10,5));
        }

        public static int GetSum(int firstnum, int secondnum)
        {
            return firstnum + secondnum;
        }
    }
}
