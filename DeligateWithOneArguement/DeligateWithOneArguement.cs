using System;

namespace DeligateWithOneArguement
{
    public delegate void DelegateName(string name);
    class DeligateWithOneArguement
    {
        static void Main(string[] args)
        {
            var Name = new DelegateName(getName);
            Name.Invoke("Hareesh");
        }

        public static void getName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
