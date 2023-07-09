using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarışması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bilgi Yarışmasına Hoşgeldiniz ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;
            if (soru == 1) ;
            {
                Console.WriteLine("Türkiye'nin başkenti neresidir?");
                Console.WriteLine();

                Console.WriteLine("A) İstanbul ");
                Console.WriteLine("B) Ankara ");
                Console.WriteLine("C) İzmir ");
                Console.WriteLine("D) Bursa ");
                Console.WriteLine();
                Console.Write(" Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;


                }
                else
                {
                    Console.Write("Cevap Yanlış Toplam Puan: 0 ");

                }
            }
            if (soru==2)
            {
                Console.WriteLine("Cumhuriyet kaç yılında ilan edildi? ");
                Console.WriteLine();
                Console.WriteLine("A) 1920");
                Console.WriteLine("B) 1924");
                Console.WriteLine("C) 1925");
                Console.WriteLine("D) 1923");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();
                if(cevap=="d" || cevap == "D")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.Write("Yanlış cevap toplam puanınız: 1");

                }
                        
                

            }
            if (soru == 3)
            {
                Console.WriteLine("2020-2021 Sezonu Spor toto süper lig şampiyonu hangi takımdır ? ");
                Console.WriteLine();
                Console.WriteLine("A) Beşiktaş");
                Console.WriteLine("B) fenerbahçe");
                Console.WriteLine("C) galatasaray");
                Console.WriteLine("D) Trabzonspor");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.Write("Tebrikler bütün soruları doğru cevapladınız");

                }
                else
                {
                    Console.Write("Yanlış cevap toplam puanınız: 2");

                }



            }






            Console.Read();

        }
    }
}
