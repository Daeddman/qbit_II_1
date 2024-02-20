using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int totalPoints = CalculateTotalPoints(scores);
        Console.WriteLine(totalPoints);
    }

    static int CalculateTotalPoints(int[] scores)
    {
        int minScore = scores.Min();
        int maxScore = scores.Max();
        
        int minIndex = Array.IndexOf(scores, minScore);
        int maxIndex = Array.IndexOf(scores, maxScore);
        
        scores[minIndex] = scores[maxIndex] = 0;
        
        int totalPoints = scores.Sum();
        return totalPoints;
    }
}