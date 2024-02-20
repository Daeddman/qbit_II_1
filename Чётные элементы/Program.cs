using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < N; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}