using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < N; i += 2)
        {
            Console.Write(array[i] + " ");
        }
    }
}