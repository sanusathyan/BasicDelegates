using System;

namespace BasicDelegates
{
    public delegate void PrintNameDelegate();

    class BasicDelegates
    {
        static void Main(string[] args)
        {
            var printName = new PrintNameDelegate(Name);

            printName.Invoke();
        }

        public static void Name()
        {
            Console.WriteLine("Hello Sanu");
        }
    }
}
