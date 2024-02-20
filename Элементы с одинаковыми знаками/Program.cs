using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());

        for (int k = 0; k < K; k++)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            bool hasSameSign = false;

            for (int i = 1; i < N; i++)
            {
                if (array[i] * array[i - 1] > 0)
                {
                    hasSameSign = true;
                    break;
                }
            }

            Console.WriteLine(hasSameSign ? "YES" : "NO");
        }
    }
}