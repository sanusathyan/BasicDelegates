using System;

namespace MultipleArgVoid
{
    public delegate void delegateName(string firstname, string lastname);
    class MultipleArgVoid
    {
        static void Main(string[] args)
        {
            var name = new delegateName(GetName);
            name.Invoke("Sanu","Sathyan");
        }

        public static void GetName(string firstname, string lastname)
        {
            Console.WriteLine(firstname+" "+lastname);
        }
    }
}
