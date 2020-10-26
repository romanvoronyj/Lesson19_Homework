using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourType = MyClass<MyType>.FactoryMethod();
            Console.WriteLine(ourType.GetType());

            Console.ReadKey();
        }
    }
}
