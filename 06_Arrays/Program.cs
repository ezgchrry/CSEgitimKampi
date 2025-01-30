﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri

            //string[] colours = new string[4];
            //colours[0] = "Kırmızı";
            //colours[1] = "Sarı";
            //colours[2] = "Beyaz";
            //colours[3] = "Mavi";

            //Console.WriteLine(colours[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Khire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[0]);

            //string[] cities = { "Prag", "Roma", "Atina", "Bursa" };
            //Console.WriteLine(cities[0]);

            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colours = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colours.Length; i++)
            //{
            //    Console.WriteLine(colours[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //        Console.WriteLine("Dizinin " + (i + 1).ToString() + ". elemanıdır.");
            //        Console.WriteLine();
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i]; 
            //    }
            //}
            //Console.WriteLine("Bu dizideki en büyük sayı: " + maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            #endregion

            #region dizi metotları

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); // numbers dizisini küçükten büyüge göre sıralar 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); // numbers dizisini tersten sıralar 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve"); // dizinin istenilen elemanının indexini bulur 
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region kullanıcıdan değer alma 

            //string[] cities = new string[5];

            //for (int i =0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. şehri giriniz.: ");
            //   // Console.Write((i + 1).ToString() + ". şehri giriniz.: ");
            //    cities[i] = Console.ReadLine();
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Girilen şehirler: ");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] figure = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("çift sayılar: ");
            //for(int i = 0; i < figure.Length; i++)
            //{
            //    if (figure[i] % 2 == 0)
            //    {
            //        Console.WriteLine(figure[i]);
            //    }
            //}
            //Console.WriteLine("tek sayılar: ");
            //for (int i = 0; i < figure.Length; i++)
            //{
            //    if (figure[i] % 2 == 1)
            //    {
            //        Console.WriteLine(figure[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
