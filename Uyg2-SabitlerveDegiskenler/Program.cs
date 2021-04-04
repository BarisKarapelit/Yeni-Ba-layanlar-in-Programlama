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

            #endregion

            #region Ornek 4 - Askerlik Durumu Sorgulama

            //char cinsiyet;

            //a1:

            //do
            //{
            //    Console.Write("Cinsiyetiniz= ");
            //} while (!Char.TryParse(Console.ReadLine(), out cinsiyet));



            //int yas;

            //do
            //{ // until the user input is valid, keep asking
            //    Console.Write("Yaşınız Giriniz: ");
            //} while (!int.TryParse(Console.ReadLine(), out yas));


            //if (cinsiyet == 'k' )
            //{
            //    Console.WriteLine("->" + cinsiyet);
            //    Console.WriteLine("Cinsiyet Hatası");
            //}else if(cinsiyet=='e')
            //{
            //    Console.WriteLine("->" + cinsiyet);
            //    if (yas>=18)
            //    {
            //        Console.WriteLine("Demek {0} yaşınızdasınız", yas);
            //        Console.WriteLine("Askerlik yapalirsiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yaş Hatası");
            //    }
            //}
            //else
            //{
            //    goto a1;
            //}


            #endregion

            #region Ornek 5 -replace
            //String s = "aaaa";
            //Console.WriteLine("The initial string: '{0}'", s);
            //s = s.Replace("aa", "bb").Replace("bb", "cc").Replace("cc", "dd");
            //Console.WriteLine("The final string: '{0}'", s);
            #endregion

            #region Ornek 5.1 -Replace

            //String username=" ";
            //Console.Write("Email giriş yapın :");
            //string email = Console.ReadLine();


            //if(email.IndexOf("hotmail")>0)
            //{
            //    username = email.Replace("@hotmail.com", " ");
            //    //Console.WriteLine("fd1");
            //}
            //else if (email.IndexOf("gmail")>0)
            //{
            //    username = email.Replace("@gmail.com", " ");
            //    //Console.WriteLine("fd2");

            //}
            //else if (email.IndexOf("outlook") > 0)
            //{
            //    username = email.Replace("@outlook.com", " ");
            //   // Console.WriteLine("fd3");

            //}
            //else if (email.IndexOf("yandex") > 0)
            //{
            //    username = email.Replace("@yandex.com", " ");
            //    //Console.WriteLine("fd");

            //}
            //else if (email.IndexOf("yahoo") > 0)
            //{
            //    username = email.Replace("@yahoo.com", " ");
            //    //Console.WriteLine("fd");

            //}

            //Console.WriteLine("Username : {0}",username);

            #endregion

            #region Ornek 6 - 5'lik Not Sistemi Yapimi
            //byte not;

            //do
            //{ // until the user input is valid, keep asking
            //    Console.Write("Notu Giriniz : ");
            //} while (!byte.TryParse(Console.ReadLine(), out not));

            //    if (not >= 85)
            //    {

            //        Console.WriteLine("5");

            //    }
            //    else if (not >= 70)
            //    {
            //        Console.WriteLine("4");
            //    }
            //    else if (not >= 55)
            //    {
            //        Console.WriteLine("3");
            //    }
            //    else if (not >= 45)
            //    {
            //        Console.WriteLine("2");
            //    }
            //    else if (not < 45)
            //    {
            //        Console.WriteLine("1");
            //    }


            #endregion

            #region Ornek 7 - Kullanıcı Kontrolu

            //string uname, upassword;
            //Console.Write("Kullanıcı Adi : ");
            //uname = Console.ReadLine();
            //Console.Write("Kullanıcı Şifresi :");
            //upassword = Console.ReadLine();

            //string dosya_yolu = @"C:\Users\baris\Desktop\userInformation.txt";
            //string[] data = System.IO.File.ReadAllLines(dosya_yolu);
            //if (data[0]==uname)
            //{
            //    Console.WriteLine("Username Succesful");
            //    if (data[1]==upassword)
            //    {
            //        Console.WriteLine("Password Succesful");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password Not Succesful");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Username Not Succesful");
            //}
            //Console.ReadKey();



            #endregion

            #region Ornek 8 - Basit Hesap Makinesi

            //float n1, n2, result=0;

            //char Process;

            //Console.WriteLine("---------Welcome To Calculater---------");
            //a1:
            //Console.WriteLine("Subtraction Process : -");
            //Console.WriteLine("Aggregation Processing : +");
            //Console.WriteLine("Multiplication Process : *");
            //Console.WriteLine("SplitTing Process :  /");




            //do
            //{
            //    Console.WriteLine("Select:");
            //} while (!Char.TryParse(Console.ReadLine(), out Process));

            //if(Process!='-'&&Process!='+'&&Process!='*'&&Process!='/')
            //{
            //    goto a1;
            //}

            //Console.WriteLine("Enter the 2 Numbers ");
            //do
            //{
            //    Console.Write("Enter 1.Number :");
            //} while (!float.TryParse(Console.ReadLine(), out n1));


            //do
            //{
            //    Console.Write("Enter 2.Number :");
            //} while (!float.TryParse(Console.ReadLine(), out n2));







            //if (Process=='-')
            //{
            //    result = n1 - n2;
            //}
            //else if (Process=='+')
            //{
            //    result = n1 + n2;
            //}
            //else if (Process=='*')
            //{
            //    result = n1 * n2;
            //}
            //else if (Process == '/')
            //{
            //    result = n1 / n2;
            //} 



            //Console.WriteLine("Result is {0}",result);
            //Console.WriteLine("Back :(Y/N)");
            //char back = Console.ReadLine()[0];
            //if (back=='Y'||back=='y')
            //{
            //    Console.Clear();
            //    goto a1;

            //}
            #endregion

            #region Ornek 9 - Switch - Case Deyimi

            int sayi;
            again:
            
        
            do
            {
              Console.Write("Please Your enter the random number :");
            } while (!int.TryParse(Console.ReadLine(),out sayi));
           

                switch (sayi)
            {
                case 1:
                    Console.WriteLine("Your number enter {0}",sayi);

                    break;
                case 2:
                    Console.WriteLine("Your number enter {0}", sayi);

                    break;
                case 3:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 4:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 5:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 6:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 7:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 8:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 9:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;
                case 10:
                    Console.WriteLine("Your number enter {0}", sayi);
                    break;

                default:
                    Console.WriteLine("Error Number :{0}", sayi);
                    goto again;
            }

            #endregion

            #endregion
        }


    }
    
}

