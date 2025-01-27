using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            Console.OutputEncoding = Encoding.UTF8;

            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine(" ***** Fiyat Listesi ***** ");
            Console.WriteLine();

            double applePrice, orangePrice, strawPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fİyatı: " + applePrice + " ₺");
            Console.WriteLine("---- Portakal Birim Fİyatı: " + orangePrice + " ₺");
            Console.WriteLine("---- Çilek Birim Fİyatı: " + strawPrice + " ₺");
            Console.WriteLine("---- Patates Birim Fİyatı: " + potatoPrice + " ₺");
            Console.WriteLine("---- Domates Birim Fİyatı: " + tomatoPrice + " ₺");

            double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawTotalPrice = strawGram * strawPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            double totalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***** Alışveriş Tutarları *****");
            Console.WriteLine();
            Console.WriteLine("Toplam Elma Fiyatı: " + appleTotalPrice + " ₺");
            Console.WriteLine("Toplam Portakal Fiyatı: " + orangeTotalPrice + " ₺");
            Console.WriteLine("Toplam Çilek Fiyatı: " + strawTotalPrice + " ₺");
            Console.WriteLine("Toplam Patates Fiyatı: " + potatoTotalPrice + " ₺");
            Console.WriteLine("Toplam Domates Fiyatı: " + tomatoTotalPrice + " ₺");
            Console.WriteLine("Toplam Alışveriş Tutarı " + totalPrice + " ₺");

            #endregion

            #region Char Değişkenler

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("***** CS Hava Yolları Yolcu Bilgisi *****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("İl Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No.: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("----------------------");
            Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            Console.WriteLine("Yolcu Yaş: " + passengerAge);
            Console.WriteLine("Yolcu TCKNo: " + passengerIdentityNumber);
            Console.WriteLine("Adres: " + passengerDistrict + "," + passengerCity + ",Türkiye");


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz.: ");
            shoeCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz.: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz.: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz.: ");
            tvCount = int.Parse(Console.ReadLine());

            int shoeTotal, computerTotal, chairTotal, tvTotal;
            int total;

            shoeTotal = shoePrice * shoeCount;
            computerTotal = computerPrice * computerCount;
            chairTotal = chairPrice * chairCount;
            tvTotal = tvPrice * tvCount;
            total = shoeTotal + computerTotal + chairTotal + tvTotal;

            Console.WriteLine();
            Console.WriteLine("***** Tutarlar *****");
            Console.WriteLine("Toplam ayakkabı tutarı: " + shoeTotal + " ₺");
            Console.WriteLine("Toplam bilgisayar tutarı: " + computerTotal + " ₺");
            Console.WriteLine("Toplam sandalye tutarı: " + chairTotal + " ₺");
            Console.WriteLine("Toplam televizyon tutarı: " + tvTotal + " ₺");
            Console.WriteLine("Toplam alışveriş tutarı: " + total + " ₺");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. sınav sonucunu giriniz.: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sınav sonucunu giriniz.: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. sınav sonucunu giriniz.: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Girilen 3 sınavın ortalaması = " + result);

            #endregion 

            #region Klavyeden Karakter Girişi

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
