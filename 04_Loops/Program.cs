using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü

            //int i;
            //for (i= 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz.:  ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}



            #endregion

            #region for döngüüs ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if ( i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i ++)
            //{
            //    if ( i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("1'den 50' ye kadar olan sayılar arasında 7'ye bölünen " + count + " tane sayı vardır.");


            #endregion

            #region örnek uygulama 

            //int bacterium = 1;
            // for (int count = 1; count <= 24; count++)
            // {
            //     bacterium = bacterium * 2;
            //     Console.WriteLine(count + ". saat sonunda kaptaki bakteri sayısı: " + bacterium);
            // }
            // Console.WriteLine("en son kaptaki bakteri sayısı: " + bacterium);

            #endregion

            #region while döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    //i++;
            //    Console.WriteLine("Merhaba Döngüler " + i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int total = 0;

            //while (i <= 10)
            //{
            //    total = i + total;
            //    i++;
            //}
            //Console.WriteLine(total);

            #endregion

            #region örnek sınav sorusu

            // klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Basamaklarındaki rakamları toplanacak sayıyı giriniz.: ");
            int number = int.Parse(Console.ReadLine());
            int ones_p, tens_p, hundreds_p;
            int sum;

            ones_p = number % 10;
            hundreds_p = number / 100;
            tens_p = (number % 100) / 10;
            sum = ones_p + tens_p + hundreds_p;
            Console.WriteLine("Girilen sayıların rakamları toplamı: " + sum );
           

            #endregion

            Console.Read();
        }
    }
}
