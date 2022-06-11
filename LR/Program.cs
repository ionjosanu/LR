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
            int maxLeft = numere[0];
            for (int i = 1; i < n-1 ; i++)
            {
                bool okLeft = false;
                bool okRight = true;
                
                    if (numere[i]>=maxLeft)
                    {
                        okLeft = true;
                        maxLeft = numere[i];
                    }

                if (okLeft)
                {
                    for (int r = i; r < n; r++)
                    {
                        if (numere[i] > numere[r])
                        {
                            okRight = false;
                            break;
                        }

                    }
                }
                if (okLeft&&okRight)
                {
                    LR++;
                }

            }
            Console.WriteLine(LR);

        }
    }
}
