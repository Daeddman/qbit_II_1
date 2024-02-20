using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < N; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }

            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        int L = Math.Min(minIndex, maxIndex);
        int R = Math.Max(minIndex, maxIndex);

        int zeroCount = 0;

        for (int i = L; i <= R; i++)
        {
            if (array[i] == 0)
            {
                zeroCount++;
            }
        }

        Console.WriteLine(zeroCount);
    }
}