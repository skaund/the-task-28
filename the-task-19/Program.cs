using System;

namespace the_task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника: ");
            int visota = int.Parse(Console.ReadLine());

            for (int i = 0; i < visota; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


        }
    }
}
