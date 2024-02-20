using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int count = 0;

        for (int i = 1; i < N - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}