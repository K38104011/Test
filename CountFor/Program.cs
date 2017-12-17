using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = 2;
            do
            {
                var inputSize = Math.Pow(10, power);
                var countFor = new CountFor((int) inputSize);
                Console.WriteLine(countFor.Result);
                power++;
            } while (power < 7);
            Console.ReadKey();
        }
    }

    class CountFor
    {
        public int Result { get; }

        public CountFor(int size)
        {
            var result = 0;
            for (int i = 1; i <= size; i++)
            {
                for (int j = i + 1; j <= size; j++)
                {
                    result++;
                }
            }
            Result = result;
        }
    }
}
