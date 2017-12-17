using System;

namespace MaxSubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] {-1, 2, 4, -3, 5, 2, -5, 2};

            var sumResult = 0;
            var subArraySize = 1;
            do
            {
                for (var beginIndex = 0; beginIndex < arr.Length; beginIndex++)
                {
                    if (beginIndex + subArraySize >= arr.Length)
                    {
                        continue;
                    }
                    var subArraySum = SumSubArray(beginIndex, subArraySize, arr);
                    if (subArraySum > sumResult)
                    {
                        sumResult = subArraySum;
                    }
                }
                subArraySize++;
            } while (subArraySize <= arr.Length);

            Console.WriteLine("Sum:" + sumResult);
            Console.ReadKey();
        }

        private static int SumSubArray(int beginIndex, int sizeSubArray, int[] arr)
        {
            var sum = 0;
            for (var i = 0; i < sizeSubArray; i++)
            {
                sum += arr[beginIndex + i];
            }
            return sum;
        }
    }
}
