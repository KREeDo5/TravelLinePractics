using System;

namespace part
{
    public static class Program
    {
        public static void Main()
        {
            First first = new First("hi");
            first.Name = "Hello";

            Console.WriteLine(first.Name);
        }
    }
}