using System;

namespace Uyg2_SabitlerveDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ornek1
            //int yas;
            //Console.Write("Yaşınız Giriniz: ");

            //yas = int.Parse(Console.ReadLine());

            // Console.WriteLine("Demek {0} yaşınızdasınız", yas);
            #endregion

            #region Ornek2
            // byte yas = 0;
            // Console.WriteLine(yas);
            #endregion

            #region Ornek3
            //int yas;

            // do
            // { // until the user input is valid, keep asking
            //  Console.Write("Yaşınız Giriniz: ");
            //} while (!int.TryParse(Console.ReadLine(), out yas));

            //Console.WriteLine("Demek {0} yaşınızdasınız", yas);

            #endregion

            #region Ornek4
            /*bool yanit;
            Console.WriteLine("Doğum tarihinizi Girin :");
            int year = int.Parse(Console.ReadLine());
            if(year==1995)
            {
                yanit = true;
                Console.WriteLine("Doğum yılımızı doğru girdiniz {0}  {1}", year,yanit);

            }
            else
            {
                yanit = false;
                Console.WriteLine("Doğum yılımızı yanlış girdiniz {0}", year);
            }*/
            #endregion

            #region Ornek5
            //int sayi = 1, sayi2 = 2;
            //float bolum;
            //bolum = (float)sayi / sayi2;
            //Console.WriteLine(bolum);
            #endregion
            #region Ornek6
            string veri ;
            Console.Write("Metin Giriniz :"); 
            veri = Console.ReadLine();
            Console.WriteLine("Girilen Metnin Uzunkuğu :"+veri.Length);
            #endregion
        }


    }
}