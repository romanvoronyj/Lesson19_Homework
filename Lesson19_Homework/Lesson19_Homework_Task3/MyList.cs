using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Homework_Task3
{
    /*Завдання 3
   Використовуючи VisualStudio, створіть проект за шаблоном ConsoleApplication.
   Створіть клас MyList<T>. Реалізуйте в найпростішому наближенні можливість використання його екземпляра аналогічно екземпляракласу List<T>. 
   Мінімально необхідний інтерфейс взаємодії з екземпляром, повинен включати метод додавання елемента, індексатор для отримання значення елемента за вказаним 
   індексом і властивість тільки для читання для отримання загальної кількості елементів. Більш детальна іформація є у файлах до цієї теми Generics.
   */
    interface IMList<T>
    {
        int Count { get; }
        T this[int index] { get; }
        void Add(T a);
        void Clear();
        bool Contains(T item);
    }
    class MyList<T> : IMList<T>//1) Створіть клас з ім'ям MyList і реалізуйте його від інтерфейсу MList <T>. Натисніть F6. З якими проблемами ви зіткнулися?  __ ніяких дій не відбулось, а що мало статись?
    {
        T[] array = null;

        public MyList()
        {
            T[] newArray = new T[0];
            array = newArray;
        }
        public T this[int index] => array[index];

        public int Count
        {
            get
            {
                return array.Length;
            }
        }
        public void Add(T a)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            array = arr;
            array[array.Length - 1] = a;
        }
        public void Clear()
        {
            array = new T[0];
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
