using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int L = -1, R = -1;

        // Находим номера первого и второго нечётных элементов
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
        
        int negativeCount = 0;
        
        for (int i = Math.Min(L, R); i <= Math.Max(L, R); i++)
        {
            if (array[i] < 0)
            {
                negativeCount++;
            }
        }
        
        Console.WriteLine(negativeCount);
    }
}