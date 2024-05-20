using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task:1 ");
            foreach (var emp in LinqTasks.Task1())
            {
                Console.WriteLine(emp.Ename);
            }
            Console.WriteLine("\nTask 2:");
            foreach (var emp in LinqTasks.Task2())
            {
                Console.WriteLine(emp.Ename);
            }
            Console.WriteLine("\nTask 3:");
            Console.WriteLine(LinqTasks.Task3());
            Console.WriteLine("\nTask 4:");
            foreach (var emp in LinqTasks.Task4())
            {
                Console.WriteLine(emp.Ename);
            }
            Console.WriteLine("\nTask 5:");
            foreach (var obj in LinqTasks.Task5())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nTask 6:");
            foreach (var obj in LinqTasks.Task6())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nTask 7:");
            foreach (var obj in LinqTasks.Task7())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nTask 8:");
            Console.WriteLine(LinqTasks.Task8());
            Console.WriteLine("\nTask 9:");
            var task9Result = LinqTasks.Task9();
            if (task9Result != null)
            {
                Console.WriteLine(task9Result.Ename);
            }
            Console.WriteLine("\nTask 10:");
            foreach (var obj in LinqTasks.Task10())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nTask 11:");
            foreach (var obj in LinqTasks.Task11())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nTask 12:");
            foreach (var emp in LinqTasks.Task12())
            {
                Console.WriteLine(emp.Ename);
            }
            Console.WriteLine("\nTask 13:");
            int[] arr = { 2, 2, 2, 2, 2, 2, 23, 2, 2, 2 };
            Console.WriteLine(LinqTasks.Task13(arr));
            Console.WriteLine("\nTask 14:");
            foreach (var dept in LinqTasks.Task14())
            {
                Console.WriteLine(dept.Dname);
            }
            Console.WriteLine("\nTask 15:");
            foreach (var obj in LinqTasks.Task15())
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nTask 16:");
            foreach (var obj in LinqTasks.Task16())
            {
                Console.WriteLine(obj);
            }
        }
    }
}
