using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[][]
       {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
       };

            // Print scores of each student using nested loops
            Console.WriteLine("Student Scores:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write($"{studentScores[i][j]} ");
                }
                Console.WriteLine();
            }

            // Calculate and print the average score for each student
            Console.WriteLine("\nAverage Scores:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine($"Student {i + 1}: {average:F2}");
            }

            // Calculate and print the average score for all students combined
            Console.WriteLine("\nAverage Score for All Students Combined:");
            int totalSum = 0;
            int totalCount = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }

            double totalAverage = (double)totalSum / totalCount;
            Console.WriteLine($"Overall Average: {totalAverage:F2}");
            Console.ReadKey();
        }
    }
}
