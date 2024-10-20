using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3,average;
            //string result="Hata";

            //Console.Write("1.Sınav: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav: ");
            //exam2 =int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average=(exam1+exam2+ exam3)/3;
            //Console.WriteLine("Ortalamanız: "+average);

            //if (average>0 & average<=50)
            //{
            //    result = "Başarısız";
            //}
            //if (average>50 & average<=70)
            //{
            //    result = "Geçer";
            //}
            //if (average > 70 & average <= 85)
            //{
            //    result = "İyi";
            //}
            //if (average > 85 & average<=100)
            //{
            //    result = "Çok İyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir mevcut değil");             
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();

            //if (username !="admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else 
            //{
            //    Console.Write("Hoş geldiniz");

            //}

            //Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            //Console.Write("Tek mi çift mi olduğunu merak ettiğiniz sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region Char Değikenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen sembolü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team =='f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("**** C# Restaurant ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1-Main Courses");
            //Console.WriteLine("2-Noodles");
            //Console.WriteLine("3-Street Delicacies");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Please write what category you want: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Main Courses----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Rabokki");
            //    Console.WriteLine("2-Ddeokbokki");
            //    Console.WriteLine("3-Bulgogi");
            //    Console.WriteLine("4-Ddakkalbi");
            //    Console.WriteLine("5-Tteokbokki");
            //    Console.WriteLine("----------------Main Courses----------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Noodles----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Korean Noodles");
            //    Console.WriteLine("2-Korean Noodles with Chicken");
            //    Console.WriteLine("3-Korean Noodles with Beef");
            //    Console.WriteLine("4-Korean Noodles with Veggies");
            //    Console.WriteLine("5-Spicy Bibimyyeon");
            //    Console.WriteLine("----------------Noodles----------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Street Delicacies----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Hot Dog");
            //    Console.WriteLine("2-Queen Cheese Ball");
            //    Console.WriteLine("3-Brınglee Cheese Ball");
            //    Console.WriteLine("4-Sotteok-Sotteok with Yangyum Sauce");
            //    Console.WriteLine("5-Sotteok-Sotteok with Bburingkeul Sauce");
            //    Console.WriteLine("----------------Street Delicacies----------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Drinks----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Seoul Night");
            //    Console.WriteLine("2-Jeju Night");
            //    Console.WriteLine("3-Love Korea");
            //    Console.WriteLine("----------------Drinks----------------");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Please Enter the Month Name: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("January"); break;
            //    case 2:Console.Write("February"); break;
            //    case 3:Console.Write("March"); break;
            //    case 4:Console.Write("April"); break;
            //    case 5:Console.Write("May"); break;
            //    case 6:Console.Write("June"); break;
            //    case 7:Console.Write("July"); break;
            //    case 8:Console.Write("August"); break;
            //    case 9:Console.Write("September"); break;
            //    case 10:Console.Write("October"); break;
            //    case 11:Console.Write("November"); break;
            //    case 12:Console.Write("December"); break;
            //    default: Console.Write("ERROR"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Write the First Number: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Write the Second Number: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter the Symbol: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //}



            #endregion

            Console.Read();
        }
    }
}
