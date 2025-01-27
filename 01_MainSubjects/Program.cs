using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları

           // Giriş
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            string name;
            name = "Murat";
            Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;
            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = " +90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine(" ***** Rezervasyon Kartı *****");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon No.: " + customerPhone);
            Console.WriteLine("E-Mail: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 500 600 10 10";
            customerEmail = "deneme2@gmail.com";
            district = "Beşevler";
            city = "Ankara";

            Console.WriteLine(" ***** Rezervasyon Kartı *****");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon No.: " + customerPhone);
            Console.WriteLine("E-Mail: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            int number = 24;
            Console.WriteLine(number);

            int burgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyat Listesi *****");
            Console.WriteLine();
            Console.WriteLine("-Hamburger: " + burgerPrice + " TL");
            Console.WriteLine("-Kola: " + cokePrice + " TL");
            Console.WriteLine("-Su: " + waterPrice + " TL");
            Console.WriteLine("-Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("-Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("--------------------------------");

            int burgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            burgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            totalPrice = 0;

            int burgerTotal = burgerPrice * burgerCount;
            int cokeTotal = cokePrice * cokeCount;
            int waterTotal = waterPrice * waterCount;
            int friesTotal = friesPrice * friesCount;
            int lemonadeTotal = lemonadePrice * lemonadeCount;
            totalPrice = burgerTotal + cokeTotal + waterTotal + friesTotal + lemonadeTotal;

            Console.WriteLine("Toplam Tutar:" + totalPrice + " TL");
           
            #endregion

            Console.Read();

        }
    }
}
