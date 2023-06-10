using System;

namespace _15
{
    class Program
    {
        static bool IsContain(int[] array, int a, int index)
        {
            for (int i = 0; i < index; i++)
                if (array[i] == a)
                    return true;
            return false;
        }
        static void Main()
        {
            int n = 10;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                Console.Write("{0,4}", i);
            Console.WriteLine();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                while (IsContain(array, array[i], i))
                {
                    array[i] = array[i] * i;
                    for (int j = 0; j < n; j++)
                        Console.Write("{0,4}", array[j]);
                    Console.WriteLine();
                }

        }
    }
}
