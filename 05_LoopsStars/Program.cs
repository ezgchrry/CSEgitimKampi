﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region dik üçgen 

            //for (int i = 1; i <= 5; i++)
            //{
            //   for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}

            #endregion

            #region ters dik üçgen 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region üst ve alt dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region piramit  

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdırma
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldızları yazdırma
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters piramit 

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                // Boşlukları yazdırma
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }

                // Yıldızları yazdırma
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
