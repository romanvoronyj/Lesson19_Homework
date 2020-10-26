using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Homework_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyList<int> userList = new MyList<int>();

            userList.Add(5);
            userList.Add(10);
            userList.Add(15);

            Console.WriteLine($"Значення елемента масиву під вказаним індексом: {userList[0]}");
            Console.WriteLine($"Загальна кількість елементів масиву: {userList.Count}");

            Console.ReadKey();

        }
    }
}
