using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22HW
{
    class Program
    {
        private static int[] array;

        public static void Sum(Task task)
        {

            int S = 0;
            for (int i = 0; i < array.Length; i++)
            {
                S += array[i];
            }
            Console.WriteLine($"Сумма = {S}");
            Console.WriteLine("Метод SUM закончил работу");
        }

        public static void Max()
        {

            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine($"Максимальное значение = {max}");
            Console.WriteLine("Метод MAX закончил работу");

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, n);
                Console.Write("{0} ", array[i]);
            }
            Action action = new Action(Max);
            Task task = new Task(action);

            Action<Task> action1 = new Action<Task>(Sum);
            Task task1 = task.ContinueWith (action1);  

            task.Start();
            

            Console.WriteLine("Main окончил работу");
            Console.ReadKey();

        }
    }
}




//1.Сформировать массив случайных целых чисел (размер  задается пользователем). 
//    Вычислить сумму чисел массива и максимальное число в массиве. 
//    Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.


