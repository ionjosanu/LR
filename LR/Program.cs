using System;

namespace LR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numereString =Console.ReadLine().Split(' ') ;
            int[] numere=new int[n];

            for (int i = 0; i <n ; i++)
            {
                numere[i] = int.Parse(numereString[i]);
            }
            int LR = 0;
            int[] left=new int[n];
            int[] right=new int[n];
            int min = numere[n - 1];
            int max = numere[0];

            for (int i = 0; i < n; i++)
            {
                if (numere[i] >= max)
                {
                    max = numere[i];
                    left[i] = max;
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (numere[i] <= min)
                {
                    min = numere[i];
                    right[i] = min;
                }
            }
            for (int i = 1; i < n - 1; i++)
            {
                if (numere[i] == left[i] && left[i] == right[i])
                {
                    LR++;
                }
            }
            Console.WriteLine(LR);

        }
    }
}
