using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Education Camp");
            //}
            //Console.WriteLine(i);

            //for (int i = 1;i<=20;i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3;i<=50;i+=3) 
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i < finishValue; i++)
            //{
            //Console.WriteLine("Yaşasın Cumhuriyet!");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++) 
            //{
            //    if (i % 5 == 0)
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

            //int count = 0;
            //for (int i = 1; i <= 50; i++) 
            //{
            //    if (i % 7 == 0) 
            //    {
            //    count++;
            //    }   
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda" + bacterium);
            //}
            #endregion

            #region While Dongusu

            //While(sart)
            //{
            //islemler
            //}

            //int i = 1;

            //while (i <= 10) 
            //{
            //Console.WriteLine("Merhaba Donguler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10) 
            //{
            //    if (i % 3 == 0) 
            //    {
            //    Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Ornek Sinav Sorusu

            //Klavyeden girilen 3 basamakli sayinin basamaklari toplamini hesaplayan kodu yaziniz.

            //Console.Write("Sayiyi Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens=(number % 100)/10;
            //hundreds = number / 100;  //4.56--> 4

            //Console.WriteLine(hundreds+ "-"+tens+"-"+ones);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);


            #endregion

            Console.Read();

        }
    }
}
