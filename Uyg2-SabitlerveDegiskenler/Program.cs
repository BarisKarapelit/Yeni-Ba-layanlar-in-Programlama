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

            #region Ornek6 -Length Ozellikleri
            //string veri ;
            //Console.Write("Metin Giriniz :"); 
            //veri = Console.ReadLine();
            //Console.WriteLine("Girilen Metnin Uzunkuğu :"+veri.Length);
            #endregion

            #region Ornek 7 - Tolower
            //Console.Write("Metin Giriniz :");
            //string veri;
            //veri = Console.ReadLine();
            //Console.WriteLine("Girilen Metni küçük harfle dönüştüyor ="+ veri.ToLower());
            #endregion

            #region Ornek  8- ToUpper 
            //string veri;
            //Console.Write("Metin Giriniz =");
            //veri=Console.ReadLine();
            //Console.Write("Girilen metni Büyük Harfle Çevirdi =" + veri.ToUpper());
            //Console.WriteLine("\n");
            #endregion

            #region Ornek 9- Trim()

            //string veri;
            //Console.Write("Metin Giriniz =");
            //veri = Console.ReadLine();
            //Console.Write("Girilen metinin sağ ve soldaki boşluklarını siler =" + veri.Trim());

            #endregion

            #region Ornek 10 -Substring 

            //String verilerde istenilen karakter kadar verinin geri
            //döndürülmesini sağlamak için SUBSTRING fonksiyonu kullanılır
            //string veri;
            //Console.Write("Metin Giriniz =");
            //veri = Console.ReadLine();
            //int uzunlukluk = veri.Length;
            //Console.WriteLine("Girdiğiniz Metin "+uzunlukluk+" karakterli" +
            //  "ve buna göre 2 değer girmesiniz \n1 . değer karakterin başlangıç değeri  \n 2. değer uzunluğu olamalıdır");
            //int start, len;
            //Console.Write("1.Değer =");
            //start = int.Parse(Console.ReadLine());
            //Console.Write("2.Değer =");
            //len = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sonuc " + veri.Substring(start, len));

            #endregion

            #region Ornek 11 - IndexOf 

            //string veri;
            //Console.Write("Enter Text :");
            //veri = Console.ReadLine();
            //Console.Write("Aranacak karakter :");
            //string data = Console.ReadLine();
            //data = data.Trim();
            //Console.WriteLine("Sonuc : " + veri.IndexOf(data));

            #endregion

            #region Ornek 12 - Concat 

            //string name, surname;

            //Console.Write("Please Enter Name :");
            //name = Console.ReadLine();

            //Console.Write("Please Enter Surname :");
            //surname = Console.ReadLine();

            //string User = String.Concat(name, " ", surname);
            //Console.WriteLine("User Information :" + User);
            #endregion

            #region Ornek 13 - Insert
            //string name, surname;

            //Console.Write("Please Enter Name :");
            //name = Console.ReadLine();

            //Console.Write("Please Enter Surname :");
            //surname = Console.ReadLine();

            //int nameInt = name.Trim().Length;
            //string User = name.Trim()+surname.Trim();
            //Console.WriteLine(User.Insert(nameInt," "));


            #endregion

            #region Ornek 15 - Remove

            //Console.Write("Enter E-mail address :");
            //string email = Console.ReadLine();



            //email = email.Trim();
            //int at = email.IndexOf("@");
            //string userName = email.Remove(at);
            //Console.WriteLine("Username :" + userName);
            #endregion

            #region Ornek 16 - Object Degiskenini Kullanma

            //object veri;
            //veri = "dasdsadasd";
            //veri = 546465;
            //veri = 'f';

            //Console.WriteLine(veri);

            #endregion

            #region Ornek 17 - Tip Donusumleri

            //int a;
            //string b = "12";

            //a = Convert.ToInt32(b);


            #endregion
        }


    }
}