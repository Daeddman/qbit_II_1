using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int L = -1, R = -1;

        for (int i = 0; i < N; i++)
        {
            if (array[i] % 2 != 0)
            {
                if (L == -1)
                {
                    L = i;
                }
                else
                {
                    R = i;
                    break;
                }
            }
        }

        int minBetweenLR = array.Skip(L).Take(R - L + 1).Min();
        Console.WriteLine(minBetweenLR);
    }
}