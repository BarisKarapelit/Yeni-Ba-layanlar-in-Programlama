# Yeni-Baslayanlar-icin-Programlama
<br><h2>Uyg1-Visual_Studio_Ortamini_Kullanma</h2><br>

<br><h2>Uyg2_SabitlerveDegiskenler</h2>
  <h3>Ornek1</h3>
          
            
 ```csharp
              //Bu kod Klavyeden değer okuyup okunan değeri mesaj olarak ekranda gösteren komuttur
                    int yas;
                    Console.Write("Yaşınız=");
                    yas=int.Parse(Console.ReadLine());
                    Console.WriteLine("Demek {0} yaşındasınız!!",yas);
  ```
 <br><h3>Örnek2</h3>
 ```csharp
             //yas değişkeni bellekte 1 byte (8bit) yer kapladıgı icin max 255 sayısı yazılabilir
             //daha yüksek bir değer değişkenin icerisine atmak gerekiyorsa bellekte daha fazla yer kaplayan
             //degisken kullanmalıyız
                   byte yas=255; // Dogru Kullanım
                   byte yasi=256; //Yanlis Kullanım
  ```

  <br><h3> Örnek 3</h3>
```csharp
                  char harf='A';
                  string veri="ALI";
```

   <br><h3>Örnek 4</h3>
```csharp
                  bool yanit;
                  yanit=true;
                  yanit =false;
```
   <br><h3> Örnek 5</h3>
```csharp
                  int sayi1=1,sayi2=2;
                  float bolum;
                  bolum=(float)sayi1/sayi2;
                  Console.WriteLine(bolum);
```

   <br><h3> Örnek6 - Lenght özelligi</h3>
```csharp
                  string veri="Merhaba Dünya";
                  int sayi=veri.Length;
                  Console.WriteLine("Karakter sayısı="+sayi);
```
   <br><h3> Örnek 7 - ToLower</h3>
```csharp
                  string veri = "MerhAba DÜnya";
                  Console.WriteLine(veri.ToLower());
                  #endregion
```

   <br><h3> Örnek 8- ToUpper</h3>
```csharp
              <br>//string veri = "MerhAba DÜnya"; 
              <br>//Console.WriteLine(veri.ToUpper());
```

   <br><h3>  Örnek 9 - Trim</h3>
```csharp
             <br>//string veri = "      MerhAba DÜnya       ";
             <br>//Console.Write(veri.Trim());
```
   <br><h3>Örnek 10 - Substring</h3>
```csharp
             <br>//string veri = "MerhAba DÜnya";
             <br>//Console.WriteLine(veri.Substring(8,5));
```
   <br><h3>Örnek 11 - IndexOf</h3>
```csharp  
             <br>//string veri = "MerhAba DÜnya";
             <br>//Console.WriteLine(veri.IndexOf('D'));
```
   <br><h3>Örnek 12 - Concat</h3>
```csharp
             <br> //string veri1 = "Ali", veri2 = "Ahmet";
             <br>//string veri3=String.Concat(veri1," ",veri2);
             <br>//Console.WriteLine(veri3);
```
   <br><h3>Örnek 13 - Insert</h3>
```csharp
             <br>//string veri="Ali Veli";
             <br>//string veri2=veri.Insert(4,"ve ");
             <br>//Console.WriteLine(veri2);
```
   <br><h3>Örnek 14 - replace</h3>
```csharp
             <br>//string veri="Ayşe";
             <br>//string degistirilmisveri=veri.Replace("A","e");
             <br>//Console.WriteLine(degistirilmisveri);
```
  <br><h3>Örnek 15 - Remove</h3>
```csharp
             <br>//string veri="Merhaba Dünya";
             <br>//string dveri=veri.Remove(3,3);
             <br>//Console.WriteLine(dveri);
```
  <br><h3>Örnek 16- Object Degiskenini Kullanma</h3>
```csharp
             <br>//object veri;
             <br>//veri="gahsdghas";
             <br>//veri=123;
             <br>//veri='A';
             <br>//Console.WriteLine(veri);
```
   <br><h3>Örnek 17 - Tip Dönüsümleri</h3>
```csharp
             <br>//float a;
             <br>//string b="12";
             <br>//a=(float)Convert.ToDouble(b);
             <br>//a=float.Parse(b);
             <br>//b=a.ToString();
```
   <h3>Uyg3_KararKontrolYapiları</h3>
   
     >> <h4>Ornek 1 - Ehliyet Durumu Sorgulama</h3>
```csharp 
           <br> //byte yas;
            <br>//Console.Write("Lütfen Yasınızı Giriniz=");
            <br>//yas=byte.Parse(Console.ReadLine());
            <br>//if (yas > 18)
            <br>//{
            <br>//    Console.WriteLine("Ehliyet Alabilirsiniz!!!");
            <br>//}
            <br>//else
            <br>//{
            <br>//    Console.WriteLine("Ehliyet Alamazsınız!!!");
            <br>//}
```            
   <h3>Ornek 2 - Soyad Sorgulama</h3>
            <br> //string soyad;
             <br>//Console.WriteLine("Ünlü şairimiz Mehmet Akif'in Soyadı Nedir?");
             <br>//soyad=Console.ReadLine();
            <br> //soyad=soyad.ToLower();
            <br> //if (soyad=="ersoy")
           <br>  //{
            <br> //    Console.WriteLine("Tebrikler Bildiniz!!!");
            <br> //}
            <br> //else
            <br> //{
            <br> //    Console.WriteLine("Üzgünüz Bilemediniz!!!");
            <br> //}
           
 <h3>Örnek 3 - 3e ve 5 e tam bolme islemi</h3>
           <br> //int sayi;
            <br>//Console.Write("Sayı Giriniz=");
           <br> //sayi=int.Parse(Console.ReadLine());
           <br> //if(sayi%3==0 && sayi%5==0)
           <br> //{
           <br> //    Console.WriteLine("Sayı Hem 3e hem 5e tam bolunur");
           <br> //}
           <br> //else
           <br> //    Console.WriteLine("Sayı 3 e ve 5 bolunemez");
           
   <h3> Ornek 4 - Askerlik Durumu Sorgulama</h3>
           <br> //char cinsiyet;
           <br> //byte yas;
           <br> //Console.Write("Cinsiyetiniz=");
           <br> //cinsiyet=Console.ReadLine()[0];
           <br> //if(cinsiyet=='e')
           <br> //{
           <br> //    Console.Write("Yasınız=");
          <br>  //    yas=byte.Parse(Console.ReadLine());
          <br>  //    if(yas>=20)
          <br>  //    {
           <br> //        Console.WriteLine("Askere Gidebilirsiniz!!!");
           <br> //    }
           <br> //    else
           <br> //        Console.WriteLine("Askere Gidemezsiniz!!!");
           <br> //}
            <br>//else
           <br> //    Console.WriteLine("Bayanlar Askere Gidemez");
            
  <h3> Ornek 5- Sayıların Karsılastırılması</h3>
          <br>  //int sayi1;
          <br>  //int sayi2;
           <br> //Console.Write("1. Sayı=");
           <br> //sayi1=int.Parse(Console.ReadLine());
           <br> //Console.Write("2. Sayı=");
           <br> //sayi2=int.Parse(Console.ReadLine());
           <br> //if(sayi1>sayi2)
           <br> //    Console.WriteLine("{0}>{1}",sayi1,sayi2);
           <br> //else if(sayi2>sayi1)
           <br> //    Console.WriteLine("{0}>{1}",sayi2,sayi1);
           <br> //else
           <br> //    Console.WriteLine("{0}={1}",sayi1,sayi2);
           
  <h3> Örnek 6 - 5'lik Not Sistemi yapımı</h3>
           <br> //byte not;
            <br>//Console.Write("Notu Giriniz");
            <br>//not=byte.Parse(Console.ReadLine());
          <br>  //if(not>=85)
           <br> //    Console.WriteLine("5");
           <br> //else if(not>=70)
           <br> //    Console.WriteLine("4");
           <br> //else if(not>=55)
           <br> //    Console.WriteLine("3");
           <br> //else if(not>=45)
          <br>  //    Console.WriteLine("2");
          <br>  //else
          <br>  //    Console.WriteLine("1");
            
   <h3> ORnek 7 Kullanıcı Kontrolu</h3>
           <br> //string kadi,sifre;
           <br> //Console.Write("Kullanıcı Adı=");
           <br> //kadi=Console.ReadLine();
           <br> //Console.Write("Sifre=");
           <br> //sifre=Console.ReadLine();
           <br> //if(kadi=="Admin" && sifre=="1234")
           <br> //{
           <br> //    Console.WriteLine("Admin Paneline Hoşgeldiniz!!!");
           <br> //}
            <br>//else
           <br> //    Console.WriteLine("Kullanıcı Adı yada Sifre Yanlıs");
           
   <h3>Ornek 8 - Basit Hesap Makinesi</h3>
          <br>  //float sayi1,sayi2,sonuc;
           <br> //char islem;
           <br> //Console.Write("Birinci sayıyı giriniz=");
           <br> //sayi1=int.Parse(Console.ReadLine());
           <br> //Console.Write("İkinci Sayıyı Giriniz=");
           <br> //sayi2=int.Parse(Console.ReadLine());
           <br> //Console.Write("Hangi İşlemi Yapmak İstiyorsunuz=");
            <br>//islem=Console.ReadLine()[0];
            <br>//if(islem=='+')
           <br> //    sonuc=sayi1+sayi2;
           <br> //else if(islem=='-')
           <br> //    sonuc=sayi1-sayi2;
           <br> //else if(islem=='*')
           <br> //    sonuc=sayi1*sayi2;
          <br>  //else 
          <br>  //    sonuc=sayi1/sayi2;
          <br>  //Console.WriteLine("Sonuc={0}",sonuc);
           
   <h3> Örnek 9 - Switch- Case DEyimi</h3>
           <br> //int sayi=9;
           <br> //switch (sayi)
          <br>  //{
          <br>  //    case 1:
          <br>  //        Console.WriteLine("1 e basıldı");
           <br> //        break;
          <br>  //    case 2:
           <br> //        Console.WriteLine("2 e basıldı");
           <br> //        break;
           <br> //    case 3:
           <br> //        Console.WriteLine("3 e basıldı");
           <br> //        break;
          <br>  //    default:
           <br> //        Console.WriteLine("Belirtilen sayılara basıldı");
           <br> //        break;
           <br> //}
            
  <h3> Örnek 10 - 1-12 ay degerlerinin sözel karsılıgını veren prg.</h3>
            <br>//byte ay;
            <br>//Console.Write("Sayısal olarak ay değerini giriniz=");
           <br> //ay=byte.Parse(Console.ReadLine());
           <br> //switch(ay)
           <br> //{
           <br> //    case 1: Console.WriteLine("Ocak"); break;
           <br> //    case 2: Console.WriteLine("Şubat"); break;
           <br> //    case 3: Console.WriteLine("Mart"); break;
           <br> //    case 4: Console.WriteLine("Nisan"); break;
           <br> //    case 5: Console.WriteLine("Mayıs"); break;
           <br> //    case 6: Console.WriteLine("Haziran"); break;
           <br> //    case 7: Console.WriteLine("Temmuz"); break;
           <br> //    case 8: Console.WriteLine("Agustos"); break;
           <br> //    case 9: Console.WriteLine("Eylül"); break;
           <br> //    case 10: Console.WriteLine("Ekim"); break;
           <br> //    case 11: Console.WriteLine("Kasım"); break;
           <br> //    case 12: Console.WriteLine("Aralık"); break;
           <br> //    default: Console.WriteLine("Belirtilen ay değeri bulunamadı!!"); break;
            <br>//}
            
<h3> Örnek 11 - Alan ve Cevre Hesabı</h3>
           <br> //string sekil;
           <br> //int alan=0;
            <br>//int cevre=0;
            <br>//Console.Write("Sekil Giriniz=");
            <br>//sekil=Console.ReadLine();
           <br> //switch(sekil)
            <br>//{
            <br>//    case "kare":
           <br> //        int kenar;
           <br> //        Console.Write("Kenar uzunlugunu giriniz=");
            <br>//        kenar=int.Parse(Console.ReadLine());
            <br>//        alan=kenar*kenar;
            <br>//        cevre=4*kenar;
           <br> //        break;
            <br>//    case "ücgen":
            <br>//        int yukseklik;
           <br> //        Console.Write("Kenar Uzunlugu=");
            <br>//        kenar=int.Parse(Console.ReadLine());
           <br> //        Console.WriteLine("Yuksekligi giriniz=");
            <br>//        yukseklik=int.Parse(Console.ReadLine());
            <br>//        alan=kenar*yukseklik/2;
            <br>//        cevre=3*kenar;
            <br>//        break;
            <br>//    default:
           <br> //        Console.WriteLine("Belirtilen sekil degeri degildir!!!");
           <br> //        break;
           <br> //}
           <br> //Console.WriteLine("Alan={0}",alan);
            <br>//Console.WriteLine("Cevre={0}",cevre);
           
<h3> Örnek 12 - Hesap Makinesi</h3>
            <br>//int sayi1,sayi2,sonuc=0;
           <br> //char islem;
            <br>//Console.Write("1. Sayıyı Giriniz=");
           <br> //sayi1=int.Parse(Console.ReadLine());
           <br> //Console.Write("2. Sayıyı Giriniz");
           <br> //sayi2=int.Parse(Console.ReadLine());
           <br> //Console.Write("Hangi işlemi yapmak istiyorsunuz(+-*/)=");
           <br> //islem=Console.ReadLine()[0];
           <br> //switch (islem)
           <br> //{
            <br>//    case '+': sonuc=sayi1+sayi2; break;
           <br> //    case '-': sonuc = sayi1 - sayi2; break;
           <br> //    case '*': sonuc = sayi1 * sayi2; break;
           <br> //    case '/': sonuc = sayi1 / sayi2; break;
            <br>//    default: Console.WriteLine("Belirtilen islem girilmedi!!!"); break;
            <br>//}
           <br> //Console.WriteLine("İşlem Sonucu ={0}",sonuc);
           
<h2>Uyg4_DonguDeyimleri</h2>
<h3>  ÖRnek 1- 1-10 arası sayıları ekrana yazan prg.</h3> 
            <br> //int i;
             <br>//for (i=1;i<=10;i++)
            <br> //{
            <br> //    Console.WriteLine(i);
           <br>  //}
           
   <h3>  Örnek 2 - d-r arası harfleri ekrana yazan prg.</h3> 
           <br>  //char harf='d';
            <br> //for(;harf<='r';)
           <br>  //{
           <br>  //    harf++;
           <br>  //    Console.WriteLine(harf);
           <br>  //}
            
   <h3>  ÖRnek 3 - 10-0 arası sayıları ekrana yazan prg.</h3> 
           <br>  //for(int i=10;i>=1;i--)
           <br>  //    Console.WriteLine(i);
            #endregion
            #region Örnek 4 - Degiskenlerin durumlarını kontrol eden prog.
           <br>  //for(int i=0,j=10;j>=i;j--,i++)
             <br>//    Console.WriteLine("i:{0}    j:{1}",i,j);
          
   <h3> Örnek 5 - Klavyeden girilen sayıya kadar olan sayıların top.</h3> 
                <br> //int sayi;
                 <br>//int sayac=0;
                 <br>//Console.Write("Sayı Gir=");
                 <br>//sayi=int.Parse(Console.ReadLine());
                <br> //for(int i=1;i<=sayi;i++)
                <br> //    sayac+=i;
                <br> //Console.WriteLine("Toplam={0}",sayac);
          
