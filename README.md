# Yeni-Baslayanlar-icin-Programlama
<h2>Uyg1-Visual_Studio_Ortamini_Kullanma</h2>

<h2>Uyg2_SabitlerveDegiskenler</h2>
 
 ><h4>Ornek1</h4>
 ```csharp
                  //Bu kod Klavyeden değer okuyup okunan değeri mesaj olarak ekranda gösteren komuttur
                    int yas;
                    Console.Write("Yaşınız=");
                    yas=int.Parse(Console.ReadLine());
                    Console.WriteLine("Demek {0} yaşındasınız!!",yas);
  ```
 ><h4>Örnek2</h4>
 ```csharp
                  //yas değişkeni bellekte 1 byte (8bit) yer kapladıgı icin max 255 sayısı yazılabilir
                  //daha yüksek bir değer değişkenin icerisine atmak gerekiyorsa bellekte daha fazla yer kaplayan
                  //degisken kullanmalıyız
                   byte yas=255;     //Dogru Kullanım
                   byte yasi=256;      //Yanlis Kullanım
  ```
 ><h4> Örnek 3</h4>
```csharp
                  char harf='A';
                  string veri="ALI";
```

  ><h4>Örnek 4</h4>
```csharp
                  bool yanit;
                  yanit=true;
                  yanit =false;
```
  ><h4> Örnek 5</h4>
```csharp
                  int sayi1=1,sayi2=2;
                  float bolum;
                  bolum=(float)sayi1/sayi2;
                  Console.WriteLine(bolum);
```

  ><h4> Örnek6 - Lenght özelligi</h4>
```csharp
                  string veri="Merhaba Dünya";
                  int sayi=veri.Length;
                  Console.WriteLine("Karakter sayısı="+sayi);
```
   ><h4> Örnek 7 - ToLower</h4>
```csharp
                  string veri = "MerhAba DÜnya";
                  Console.WriteLine(veri.ToLower());
                  #endregion
```

   ><h4> Örnek 8- ToUpper</h4>
```csharp
                  string veri = "MerhAba DÜnya"; 
                  Console.WriteLine(veri.ToUpper());
```

   ><h4>  Örnek 9 - Trim</h4>
```csharp
                  string veri = "      MerhAba DÜnya       ";
                  Console.Write(veri.Trim());
```
   ><h4>Örnek 10 - Substring</h4>
```csharp
                  string veri = "MerhAba DÜnya";
                  Console.WriteLine(veri.Substring(8,5));
```
   ><h4>Örnek 11 - IndexOf</h4>
```csharp  
                  string veri = "MerhAba DÜnya";
                  Console.WriteLine(veri.IndexOf('D'));
```
   ><h4>Örnek 12 - Concat</h4>
```csharp
                  string veri1 = "Ali", veri2 = "Ahmet";
                  string veri3=String.Concat(veri1," ",veri2);
                  Console.WriteLine(veri3);
```
   ><h4>Örnek 13 - Insert</h4>
```csharp
                  string veri="Ali Veli";
                  string veri2=veri.Insert(4,"ve ");
                  Console.WriteLine(veri2);
```
   ><h4>Örnek 14 - replace</h4>
```csharp
                  string veri="Ayşe";
                  string degistirilmisveri=veri.Replace("A","e");
                  Console.WriteLine(degistirilmisveri);
```
  ><h4>Örnek 15 - Remove</h4>
```csharp
                  string veri="Merhaba Dünya";
                  string dveri=veri.Remove(3,3);
                  Console.WriteLine(dveri);
```
  ><h4>Örnek 16- Object Degiskenini Kullanma</h4>
```csharp
                  object veri;
                  veri="gahsdghas";
                  veri=123;
                  veri='A';
                  Console.WriteLine(veri);
```
   ><h4>Örnek 17 - Tip Dönüsümleri</h4>
```csharp
                  float a;
                  string b="12";
                  a=(float)Convert.ToDouble(b);
                  a=float.Parse(b);
                  b=a.ToString();
```
   ><h4>Uyg3_KararKontrolYapiları</h4>
   
  ><h4>Ornek 1 - Ehliyet Durumu Sorgulama</h4>
```csharp 
               byte yas;
               Console.Write("Lütfen Yasınızı Giriniz=");
               yas=byte.Parse(Console.ReadLine());
               if (yas > 18)
               {
                   Console.WriteLine("Ehliyet Alabilirsiniz!!!");
               }
               else
               {
                   Console.WriteLine("Ehliyet Alamazsınız!!!");
               }
```            
   ><h4>Ornek 2 - Soyad Sorgulama</h4>
```csharp   
                  string soyad;
                  Console.WriteLine("Ünlü şairimiz Mehmet Akif'in Soyadı Nedir?");
                  soyad=Console.ReadLine();
                  soyad=soyad.ToLower();
                  if (soyad=="ersoy")
                  {
                      Console.WriteLine("Tebrikler Bildiniz!!!");
                  }
                  else
                  {
                      Console.WriteLine("Üzgünüz Bilemediniz!!!");
                  }
```           
 ><h4>Örnek 3 - 3e ve 5 e tam bolme islemi</h4>
```csharp
               int sayi;
               Console.Write("Sayı Giriniz=");
               sayi=int.Parse(Console.ReadLine());
               if(sayi%3==0 && sayi%5==0)
               {
                   Console.WriteLine("Sayı Hem 3e hem 5e tam bolunur");
               }
               else
                   Console.WriteLine("Sayı 3 e ve 5 bolunemez");
```           
 >  ><h4> Ornek 4 - Askerlik Durumu Sorgulama</h4>
```csharp  
               char cinsiyet;
               byte yas;
               Console.Write("Cinsiyetiniz=");
               cinsiyet=Console.ReadLine()[0];
               if(cinsiyet=='e')
               {
                   Console.Write("Yasınız=");
                   yas=byte.Parse(Console.ReadLine());
                   if(yas>=20)
                   {
                       Console.WriteLine("Askere Gidebilirsiniz!!!");
                   }
                   else
                       Console.WriteLine("Askere Gidemezsiniz!!!");
               }
               else
                   Console.WriteLine("Bayanlar Askere Gidemez");
```            
><h4> Ornek 5- Sayıların Karsılastırılması</h4>
```csharp
               int sayi1;
               int sayi2;
               Console.Write("1. Sayı=");
               sayi1=int.Parse(Console.ReadLine());
               Console.Write("2. Sayı=");
               sayi2=int.Parse(Console.ReadLine());
               if(sayi1>sayi2)
                   Console.WriteLine("{0}>{1}",sayi1,sayi2);
               else if(sayi2>sayi1)
                   Console.WriteLine("{0}>{1}",sayi2,sayi1);
               else
                   Console.WriteLine("{0}={1}",sayi1,sayi2);
```           
>  ><h4> Örnek 6 - 5'lik Not Sistemi yapımı</h4>
```csharp
               byte not;
               Console.Write("Notu Giriniz");
               not=byte.Parse(Console.ReadLine());
               if(not>=85)
                   Console.WriteLine("5");
               else if(not>=70)
                   Console.WriteLine("4");
               else if(not>=55)
                   Console.WriteLine("3");
               else if(not>=45)
                   Console.WriteLine("2");
               else
                   Console.WriteLine("1");
 ```           
 >  ><h4> ORnek 7 Kullanıcı Kontrolu</h4>
 ```csharp
               string kadi,sifre;
               Console.Write("Kullanıcı Adı=");
               kadi=Console.ReadLine();
               Console.Write("Sifre=");
               sifre=Console.ReadLine();
               if(kadi=="Admin" && sifre=="1234")
               {
                   Console.WriteLine("Admin Paneline Hoşgeldiniz!!!");
               }
               else
                   Console.WriteLine("Kullanıcı Adı yada Sifre Yanlıs");
```           
>   ><h4>Ornek 8 - Basit Hesap Makinesi</h4>
```csharp
               float sayi1,sayi2,sonuc;
               char islem;
               Console.Write("Birinci sayıyı giriniz=");
               sayi1=int.Parse(Console.ReadLine());
               Console.Write("İkinci Sayıyı Giriniz=");
               sayi2=int.Parse(Console.ReadLine());
               Console.Write("Hangi İşlemi Yapmak İstiyorsunuz=");
               islem=Console.ReadLine()[0];
               if(islem=='+')
                   sonuc=sayi1+sayi2;
               else if(islem=='-')
                   sonuc=sayi1-sayi2;
               else if(islem=='*')
                   sonuc=sayi1*sayi2;
               else 
                   sonuc=sayi1/sayi2;
               Console.WriteLine("Sonuc={0}",sonuc);
```           
>   ><h4> Örnek 9 - Switch- Case DEyimi</h4>
```csharp
               int sayi=9;
               switch (sayi)
               {
                   case 1:
                       Console.WriteLine("1 e basıldı");
                       break;
                   case 2:
                       Console.WriteLine("2 e basıldı");
                       break;
                   case 3:
                       Console.WriteLine("3 e basıldı");
                       break;
                   default:
                       Console.WriteLine("Belirtilen sayılara basıldı");
                       break;
               }
```            
>  ><h4> Örnek 10 - 1-12 ay degerlerinin sözel karsılıgını veren prg.</h4>
```csharp
               byte ay;
               Console.Write("Sayısal olarak ay değerini giriniz=");
               ay=byte.Parse(Console.ReadLine());
               switch(ay)
               {
                   case 1: Console.WriteLine("Ocak"); break;
                   case 2: Console.WriteLine("Şubat"); break;
                   case 3: Console.WriteLine("Mart"); break;
                   case 4: Console.WriteLine("Nisan"); break;
                   case 5: Console.WriteLine("Mayıs"); break;
                   case 6: Console.WriteLine("Haziran"); break;
                   case 7: Console.WriteLine("Temmuz"); break;
                   case 8: Console.WriteLine("Agustos"); break;
                   case 9: Console.WriteLine("Eylül"); break;
                   case 10: Console.WriteLine("Ekim"); break;
                   case 11: Console.WriteLine("Kasım"); break;
                   case 12: Console.WriteLine("Aralık"); break;
                   default: Console.WriteLine("Belirtilen ay değeri bulunamadı!!"); break;
               }
```            
><h4> Örnek 11 - Alan ve Cevre Hesabı</h4>
```csharp
               string sekil;
               int alan=0;
               int cevre=0;
               Console.Write("Sekil Giriniz=");
               sekil=Console.ReadLine();
               switch(sekil)
               {
                   case "kare":
                       int kenar;
                       Console.Write("Kenar uzunlugunu giriniz=");
                       kenar=int.Parse(Console.ReadLine());
                       alan=kenar*kenar;
                       cevre=4*kenar;
                       break;
                   case "ücgen":
                       int yukseklik;
                       Console.Write("Kenar Uzunlugu=");
                       kenar=int.Parse(Console.ReadLine());
                       Console.WriteLine("Yuksekligi giriniz=");
                       yukseklik=int.Parse(Console.ReadLine());
                       alan=kenar*yukseklik/2;
                       cevre=3*kenar;
                       break;
                   default:
                       Console.WriteLine("Belirtilen sekil degeri degildir!!!");
                       break;
               }
               Console.WriteLine("Alan={0}",alan);
               Console.WriteLine("Cevre={0}",cevre);
```           
><h4> Örnek 12 - Hesap Makinesi</h4>
```csharp
               int sayi1,sayi2,sonuc=0;
               char islem;
               Console.Write("1. Sayıyı Giriniz=");
               sayi1=int.Parse(Console.ReadLine());
               Console.Write("2. Sayıyı Giriniz");
               sayi2=int.Parse(Console.ReadLine());
               Console.Write("Hangi işlemi yapmak istiyorsunuz(+-*/)=");
               islem=Console.ReadLine()[0];
               switch (islem)
               {
                   case '+': sonuc=sayi1+sayi2; break;
                   case '-': sonuc = sayi1 - sayi2; break;
                   case '*': sonuc = sayi1 * sayi2; break;
                   case '/': sonuc = sayi1 / sayi2; break;
                   default: Console.WriteLine("Belirtilen islem girilmedi!!!"); break;
               }
               Console.WriteLine("İşlem Sonucu ={0}",sonuc);
```          
<h2>Uyg4_DonguDeyimleri</h2>

><h4>  ÖRnek 1- 1-10 arası sayıları ekrana yazan prg.</h4> 

```csharp
                  int i;
                  for (i=1;i<=10;i++)
                  {
                      Console.WriteLine(i);
                  }
```

><h4>  Örnek 2 - d-r arası harfleri ekrana yazan prg.</h4> 

```csharp
                  char harf='d';
                  for(;harf<='r';)
                  {
                      harf++;
                      Console.WriteLine(harf);
                  }
```            
><h4>  ÖRnek 3 - 10-0 arası sayıları ekrana yazan prg.</h4> 
```csharp
                  for(int i=10;i>=1;i--)
                      Console.WriteLine(i);
```

><h4> Örnek 4 - Degiskenlerin durumlarını kontrol eden prog.
```csharp
                  for(int i=0,j=10;j>=i;j--,i++)
                      Console.WriteLine("i:{0}    j:{1}",i,j);
```
><h4> Örnek 5 - Klavyeden girilen sayıya kadar olan sayıların top.</h4> 
```csharp
                     int sayi;
                     int sayac=0;
                     Console.Write("Sayı Gir=");
                     sayi=int.Parse(Console.ReadLine());
                     for(int i=1;i<=sayi;i++)
                         sayac+=i;
                     Console.WriteLine("Toplam={0}",sayac);
 ```         
