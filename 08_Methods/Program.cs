using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metodlar

            //void CustomerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("hakan öztürk");
            //    Console.WriteLine("merve çınar");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region geriye deger döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("ayşegül", "kaya");

            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region geriye değer döndüren metotlar 

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColour)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nFlag Colour: " + flagColour;
            //    return cardInfo;    
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz.: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz.: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(144, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region örnek uygulama 

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student +  " isimli öğrenci dersi geçti.   Ortalama: " + result ;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci dersten kaldı   Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Zeynep", 10, 11, 12));
            //Console.WriteLine(ExamResult("Ezgi", 98, 100, 85));
            //Console.WriteLine(ExamResult("Özgür", 15, 50, 100));

            #endregion 



            Console.Read();
        }
    }
}
