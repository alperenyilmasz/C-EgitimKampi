﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 40;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" +  applePrice+" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" +  orangePrice+" TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" +  strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" +  potatoPrice +" TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" +  tomatoPrice +" TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - "+"Birim Fiyat: " + applePrice+" - Gramaj: "+appleGram+" - Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - "+"Birim Fiyat: " + orangePrice+" - Gramaj: "+orangeGram+" - Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - "+"Birim Fiyat: " + strawberryPrice+" - Gramaj: "+strawberryGram+" - Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - "+"Birim Fiyat: " + tomatoPrice+" - Gramaj: "+tomatoGram+" - Toplam Tutar: "+tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - "+"Birim Fiyat: " + potatoPrice+" - Gramaj: "+potatoGram+" - Toplam Tutar: "+potatoTotalPrice);

            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //ACDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //' TEK TIRNAK KULLANILIR

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentifyNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik Numarası: ");
            //passengerIdentifyNumber = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu: "+ passengerName +" "+passengerSurname);
            //Console.WriteLine("Yaş: "+passengerAge+" - TC NO:"+passengerIdentifyNumber+" - İl: "+passengerDistrict);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 1200;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine();
            //Console.Write("Toplam Tutar: "+totalPrice+" TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Dönem ortalamanız: " + result);

            #endregion

            #region Klavyede Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

            # endregion

            Console.Read();
        }
    }
}
