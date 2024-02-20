using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        
        for (int i = 0; i < N; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.Write(array[i] + " ");
            }
        }

        for (int i = 0; i < N; i++)
        {
            if (array[i] % 2 != 0)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}