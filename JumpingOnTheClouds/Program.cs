using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = { 0, 0, 0, 1, 0, 0 };
            int count = 0;
            int jump = 0;

            while (count < c.Length)
            {
                if (c.Length >= count + 1 || c[count + 1] == 1)
                {
                    count += 2;
                    jump++;
                }
                else if (c.Length >= count + 2 || c[count + 2] == 0)
                {
                    count += 2;
                    jump++;
                }
                else
                {
                    count++;
                    jump++;
                }
            }

            Console.WriteLine(jump);
        }
    }
}
