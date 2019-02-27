using System;
using Clean_Architecture.Core.Entities;

namespace ConsoleAppTest
{
    class Program
    {
        public Program()
        {
            exp01();
        }

        void exp01()
        {
            Collaborater collaborater = new Collaborater();
            Console.WriteLine(collaborater.FirstName);
            collaborater.FirstName = "Xanxus";
            Console.WriteLine(collaborater.FirstName);

        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
