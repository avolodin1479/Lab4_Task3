using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа A, B и C");
            float A = Convert.ToInt32(Console.ReadLine());
            float B = Convert.ToInt32(Console.ReadLine());
            float C = Convert.ToInt32(Console.ReadLine());
            int N = 0;
            float X;
            while ((A-C) >=0)
            {
                A -= C;
                X = B;
                while (X-C >=0)
                {
                    X -= C;
                    ++N;
                }
                
            }

            Console.WriteLine("Количество квадратов = {0}",N);
            Console.ReadKey();
        }
    }
}
