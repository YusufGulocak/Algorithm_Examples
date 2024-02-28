using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  C# program that finds the sum of the factorials of numbers between two numbers entered by the user

{
                double gs1, toplm, gs2, fakt;
                Console.Write("1.sayı:");
                gs1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2.sayı:");
                gs2 = Convert.ToDouble(Console.ReadLine());
                toplm = 0;

                for (double i = ++gs1; i < gs2; i++)
                {
                    fakt = 1;
                    for (double j = 1; j <= i; j++)
                    {
                        fakt *= j;

                    }
                    toplm += fakt;


                }
                Console.Write("Sum of factorials of numbers between two numbers:" + toplm);

                Console.ReadLine();
            }*/



            **************************************************************************
            /*C# program that takes the exact square root of a number entered by the user, if any, or finds its factors

              {
                int gs = Convert.ToInt32(Console.ReadLine());
                if (gs >= 0)
                {
                    double karek = Math.Sqrt(gs);
                    if (karek % 1 == 0)
                    {
                        Console.WriteLine("Sayının karekökü:" + karek);
                    }
                    else Console.WriteLine("Sayının çarpanları:");
                    for (int i = 1; i < gs; i++)

                    {
                        if (gs % i == 0)

                        {
                            Console.Write(i + " ");

                        }
                    }

                }
                else Console.WriteLine("Kökü yoktur.");
            }*/
            ***********************************************************************
           /* A c# program that places numbers held by the computer into a random array

              {
                Random r = new Random();
                int es = r.Next(1, 101);
                int[] dz = new int[es];
                for (int i = 0; i < es; i++)
                {
                    dz[i] = r.Next(1, 101);
                }
                Console.WriteLine("Oluşturulan dizi:");
                foreach (var eleman in dz) { Console.Write(eleman + " "); }
            }*/
            ************************************************************************
           /* Write a program that fills a 2 - row array whose column number is entered by the user with random numbers according to the following two rules.
            Rule 1: Randomized odd numbers will be placed in the first row and even numbers in the next row.
            Rule 2: Continue placing numbers until both rows are filled.

         { 
          int suts = Convert.ToInt32(Console.ReadLine());
           Random r = new Random();
          int[,] dz = new int[2, suts];
          for (int i = 0; i< 2; i++)
            {
           for (int j = 0; j<suts; j++) 
          {
            if (i == 0)
            {
                dz[i, j] = r.Next(1, 101) * 2 - 1;
            }else
            {
                dz[i, j] = r.Next(1, 101) * 2;
            }
            
          }
        }
         for (int i = 0; i < 2; i++)
          {
          for (int j = 0; j < suts; j++)
           {
          Console.Write(dz[i, j] + " ");
     }
      Console.WriteLine();
}

        }
    }
}/*
