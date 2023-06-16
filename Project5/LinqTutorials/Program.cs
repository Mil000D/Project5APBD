using System;
using System.Collections;

namespace LinqTutorials
{
    class Program
    {
        static int taskNum = 0;
        static void Main(string[] args)
        {
            var t1 = LinqTasks.Task1();
            print(t1);

            var t2 = LinqTasks.Task2();
            print(t2);

            var t3 = LinqTasks.Task3();
            printSingleItem(t3);

            var t4 = LinqTasks.Task4();
            print(t4);

            var t5 = LinqTasks.Task5();
            print(t5);

            var t6 = LinqTasks.Task6();
            print(t6);

            var t7 = LinqTasks.Task7();
            print(t7);

            var t8 = LinqTasks.Task8();
            printSingleItem(t8);

            var t9 = LinqTasks.Task9();
            printSingleItem(t9);

            var t10 = LinqTasks.Task10();
            print(t10);

            var t11 = LinqTasks.Task11();
            print(t11);

            var t12 = LinqTasks.Task12();
            print(t12);

            var t13 = LinqTasks.Task13(new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            printSingleItem(t13);

            var t14 = LinqTasks.Task14();
            print(t14);

        }
        static void print(IEnumerable enumerable)
        {
            taskNum++;
            Console.WriteLine($"Task {taskNum}");
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void printSingleItem<T>(T item)
        {
            taskNum++;
            Console.WriteLine($"Task {taskNum}");
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
