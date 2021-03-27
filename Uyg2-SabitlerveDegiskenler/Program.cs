using System;
using System.IO;
using System.Net;

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


            #region Basit İşlemler

            //int n1,n2;

            //do
            //{ 

            //    Console.Write("Lutfen birinci sayiyi giriniz: ");


            //} while (!int.TryParse(Console.ReadLine(), out n1));

            //do
            //{

            //    Console.Write("Lutfen ikinci sayiyi giriniz:");


            //} while (!int.TryParse(Console.ReadLine(), out n2));

            //Console.WriteLine("Toplam :" + (n1 + n2));
            //Console.WriteLine("Fark :" + (n1 - n2));
            //Console.WriteLine("Çarpim :" + (n1 * n2));
            //Console.WriteLine("Bölüm :" + (n1 / n2));
            //Console.WriteLine("Kalan :" + (n1 % n2));
            #endregion


            #region ReEkrana Tarihi Basan Kod
            //string yil ,ay, gün;

            //Console.Write("Lütfen günü giriniz:");
            //gün =Console.ReadLine();

            //Console.Write("Lütfen ayını giriniz:");
            //ay = Console.ReadLine();

            //Console.Write("Lütfen yıl giriniz:");
            //yil = Console.ReadLine();

            //Console.WriteLine("Gün ay yıl : {0}.{1}.{2}", gün, ay, yil);

            //Console.WriteLine("Ay gün yıl : {1}.{0}.{2}", gün, ay, yil);

            //Console.WriteLine("Yıl ay gün: : {2}.{1}.{0}", gün, ay, yil);
            #endregion

            #region Uyg3-KararKontrolYapiları

            #region Ornek 1 - Ehliyet Durum Sorgulama 

            //byte yas=0;
            //int modDegeri=0;
            //int UserGun, UserAy, UserYil;
            //int yil = DateTime.Now.Year;
            //int ay = DateTime.Now.Month;
            //int gun = DateTime.Now.Day;

            //Console.Write("Lütfen Doğum Yılınız Girin:");

            //UserYil = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Doğum Ayınızı Girin:");

            //UserAy = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Doğum Gününüzü Girin:");

            //UserGun = int.Parse(Console.ReadLine());

            //yil = yil - UserYil-1;
            //UserAy = 12-UserAy;
            //UserGun = 30-UserGun;

            //ay = ay + UserAy;
            //gun = gun + UserGun;

            ////Console.WriteLine(yil+"-"+ay+"-"+gun);
            //if(ay>=12)
            //{
            //    ay = ay % 12;
            //    modDegeri++;
            //}

            //yil = modDegeri + yil;
            //yas = (byte)yil;

            //if (yas>18)
            //{
            //    Console.WriteLine("Tam olarak "+yil+" yaşınızda ve "+ay+" ay "+gun+" günlüksünüz.");
            //    Console.WriteLine("Ehliyet Alabilirsiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Tam olarak " + yil + " yaşınızda ve " + ay + " ay " + gun + " günlüksünüz.");
            //    Console.WriteLine("Ehliyet Alamazsınız");
            //}
            #endregion

            #region Ornek 2 Soyad Sorgulama
            string word = "What is C#";
            string source = (new WebClient()).DownloadString("http://stackoverflow.com/");
            if (source.Contains(word))
                Console.WriteLine(source);
                Console.WriteLine("Found it " + word);

            #endregion
            #endregion
        }


    }
}