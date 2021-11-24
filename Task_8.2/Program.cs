using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Temp.Task_8.2.txt";
            int[] arrayIn = new int[10];
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    arrayIn[i] = random.Next(100);
                    sw.WriteLine(arrayIn[i]);
                }
            }
            using (StreamReader sr = new StreamReader(fileName))
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
