using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //Console.Write("Lütfen şifreyi griniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı veri girildi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number= int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "not ortalaması değeri geçersiz.";

            //Console.Write("Sınav 1: ");
            //exam1=int.Parse(Console.ReadLine()); ;

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine()); ;

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine()); ;

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat.";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta.";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi.";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "malatya")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil. ");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz.: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}
            #endregion

            #region mod işlemleri

            int sayi;
            sayi = 26;
            int sonuc = sayi % 5;
            Console.WriteLine(sonuc);

            int number1, number2;
            Console.Write("Lütfen bölünen sayıyı giriniz.: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen bölen sayıyı giriniz.: ");
            number2 = int.Parse(Console.ReadLine());
            int result_1 = number1 % number2;
            Console.WriteLine(number1 + "/" + number2 + " bölümünden kalan => " + result_1);

            Console.Write("Lütfen sayıyı giriniz.: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("girilen sayı çift sayıdır.");
            }
            else
            {
                Console.Write("Girilen sayı tek sayıdır.");
            }

            #endregion

            #region char değişkenler ile karar yapıları

            char team;
            Console.Write("Lütfen adını yazdırmak istediğiniz 3 büyük takımdan birinin baş harfini giriniz.: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }
            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("galatasaray");
            }
            else
            {
                Console.WriteLine("Girdiğiniz baş harf üç büyük takımdan birine ait değil.");
            }
            #endregion

            #region örnek proje uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string menuItem;

            Console.WriteLine("Detayını görmek istediğiniz menüyü seçiniz.:");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("***** Ana Yemekler *****");
                Console.WriteLine("   - Izgara Tavuk");
                Console.WriteLine("   - Kuru Fasulye ve Pilav");
                Console.WriteLine("   - Et Sote");
                Console.WriteLine("   - Karnıyarık");
                Console.WriteLine("   - Fırında Balık");
            }
            else if (menuItem == "2")
            {
                Console.WriteLine("***** Çorbalar *****");
                Console.WriteLine("   - Mercimek Çorbası");
                Console.WriteLine("   - Tavuk Suyu Çorbası");
                Console.WriteLine("   - Ezogelin Çorbası");
                Console.WriteLine("   - Domates Çorbası");
                Console.WriteLine("   - Tarhana Çorbası");
            }
            else if (menuItem == "3")
            {
                Console.WriteLine("***** Pizzalar *****");
                Console.WriteLine("   - Margarita Pizza");
                Console.WriteLine("   - Pepperoni Pizza");
                Console.WriteLine("   - Dört Peynirli Pizza");
                Console.WriteLine("   - Vejetaryen Pizza");
                Console.WriteLine("   - Barbekü Tavuklu Pizza");
            }
            else if (menuItem == "4")
            {
                Console.WriteLine("***** İçecekler *****");
                Console.WriteLine("   - Ayran");
                Console.WriteLine("   - Limonata");
                Console.WriteLine("   - Taze Sıkılmış Portakal Suyu");
                Console.WriteLine("   - Soğuk Kahve");
                Console.WriteLine("   - Şeftali Buzlu Çay");
            }
            else if (menuItem == "5")
            {
                Console.WriteLine("***** Tatlılar *****");
                Console.WriteLine("   - Baklava");
                Console.WriteLine("   - Sütlaç");
                Console.WriteLine("   - Profiterol");
                Console.WriteLine("   - Kazandibi");
                Console.WriteLine("   - Cheesecake");
            }
            else
            {
                Console.WriteLine("geçersiz tercih");
            }
            #endregion

            #region switch case

            Console.Write("Lütfen ay girişi yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.Write("ocak"); break;
                case 2: Console.Write("şubat"); break;
                case 3: Console.Write("mart"); break;
                case 4: Console.Write("nisan"); break;
                case 5: Console.Write("mayıs"); break;
                case 6: Console.Write("haziran"); break;
                case 7: Console.Write("temmuz"); break;
                case 8: Console.Write("ağustos"); break;
                case 9: Console.Write("eylül"); break;
                case 10: Console.Write("ekim"); break;
                case 11: Console.Write("kasım"); break;
                case 12: Console.Write("aralık"); break;
                default: Console.WriteLine("Hatalı veri girişi"); break;
            }

            #endregion

            #region switch case hesap makinesi

            int number_1, number_2, conc;
            char islemTuru;
            Console.WriteLine("***** Hesap Makinesi Dört İşlem *****");
            Console.Write("İşlem yapılacak ilk sayıyı giriniz.: ");
            number_1 = int.Parse(Console.ReadLine());
            Console.Write("İşlem yapılacak ikinci sayıyı giriniz.: ");
            number_2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Toplama => +\nÇıkarma => -\nÇarpma => *\nBölme => /\nYapılacak işlem türünü seçiniz.:  ");
            islemTuru = char.Parse(Console.ReadLine());

            switch (islemTuru)
            {
                case '+':
                        conc = number_1 + number_2;
                        Console.WriteLine(number_1 + " + " + number_2 + " = " + conc);
                        break;
                    
                case '-':
                        conc = number_1 - number_2;
                        Console.WriteLine(number_1 + " - " + number_2 + " = " + conc);
                        break;
                   
                case '*':
                        conc = number_1 * number_2;
                        Console.WriteLine(number_1 + " * " + number_2 + " = " + conc);
                        break;
                    
                case '/':
                        conc = number_1 / number_2;
                        Console.WriteLine(number_1 + " / " + number_2 + " = " + conc);
                        break;
                default:
                    Console.WriteLine("Geçersiz işlem türü seçtiniz.");
                    break;

            }
           


            #endregion


            Console.Read();

        }
    }
}
