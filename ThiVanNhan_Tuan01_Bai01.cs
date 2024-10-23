using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int largest = 0;

            for (; counter < 10; counter++)
            {
                Console.Write($"Nhap vao so thu {counter + 1}: ");
                int number = int.Parse(Console.ReadLine());
                if (counter == 0 || number > largest)
                {
                    largest = number;
                }
            }
            Console.WriteLine($"So lon nhat la: {largest}");

            Console.ReadKey();
        }
    }
}
