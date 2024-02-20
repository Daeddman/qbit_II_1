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

        
        int minIndex = 0;
        for (int i = 1; i < N; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        
        int maxIndex = 0;
        for (int i = 1; i < N; i++)
        {
            if (array[i] >= array[maxIndex])
            {
                maxIndex = i;
            }
        }

        
        int countNegativeBetweenLR = 0;
        for (int i = Math.Min(minIndex, maxIndex); i <= Math.Max(minIndex, maxIndex); i++)
        {
            if (array[i] < 0)
            {
                countNegativeBetweenLR++;
            }
        }

        
        Console.WriteLine(countNegativeBetweenLR);
    }
}