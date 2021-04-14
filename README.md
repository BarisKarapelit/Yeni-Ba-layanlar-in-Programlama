# Yeni-Baslayanlar-icin-Programlama
<br><h2>Uyg1-Visual_Studio_Ortamini_Kullanma</h2><br>

<br><h2>Uyg2_SabitlerveDegiskenler</h2><br>
  <p><br><h3>Ornek1</h3>
            <br> //Bu kod Klavyeden değer okuyup okunan değeri mesaj olarak ekranda gösteren komuttur
             <br> //int yas;
              <br>//Console.Write("Yaşınız=");
             <br> //yas=int.Parse(Console.ReadLine());
             <br> //Console.WriteLine("Demek {0} yaşındasınız!!",yas);
 <br><h3>Örnek2</h3>
             <br> //yas değişkeni bellekte 1 byte (8bit) yer kapladıgı icin max 255 sayısı yazılabilir
              <br>//daha yüksek bir değer değişkenin icerisine atmak gerekiyorsa bellekte daha fazla yer kaplayan
             <br> //degisken kullanmalıyız
            <br>  //byte yas=255; // Dogru Kullanım
            <br>  //byte yasi=256; //Yanlis Kullanım

  <br><h3> Örnek 3</h3>
              <br>//char harf='A';
              <br>//string veri="ALI";

   <br><h3>Örnek 4</h3>
              <br>//bool yanit;
              <br>//yanit=true;
              <br>//yanit =false;
   <br><h3> Örnek 5<h3>
              <br>//int sayi1=1,sayi2=2;
              <br>//float bolum;
              <br>//bolum=(float)sayi1/sayi2;
              <br>//Console.WriteLine(bolum);

   <br><h3> Örnek6 - Lenght özelligi</h3>
            <br>  //string veri="Merhaba Dünya";
              <br>//int sayi=veri.Length;
              <br>//Console.WriteLine("Karakter sayısı="+sayi);

   <br><h3> Örnek 7 - ToLower<h3>
              <br>//string veri = "MerhAba DÜnya";
              <br>//Console.WriteLine(veri.ToLower());
             #endregion

   <br><h3> Örnek 8- ToUpper</h3>
              <br>//string veri = "MerhAba DÜnya"; 
              <br>//Console.WriteLine(veri.ToUpper());

   <br><h3>  Örnek 9 - Trim</h3>
             <br>//string veri = "      MerhAba DÜnya       ";
             <br>//Console.Write(veri.Trim());

   <br><h3>Örnek 10 - Substring</h3>
             <br>//string veri = "MerhAba DÜnya";
             <br>//Console.WriteLine(veri.Substring(8,5));

   <br><h3>Örnek 11 - IndexOf</h3>
             <br>//string veri = "MerhAba DÜnya";
             <br>//Console.WriteLine(veri.IndexOf('D'));

   <br><h3>Örnek 12 - Concat</h3>
             <br> //string veri1 = "Ali", veri2 = "Ahmet";
             <br>//string veri3=String.Concat(veri1," ",veri2);
             <br>//Console.WriteLine(veri3);

   <br><h3>Örnek 13 - Insert</h3>
             <br>//string veri="Ali Veli";
             <br>//string veri2=veri.Insert(4,"ve ");
             <br>//Console.WriteLine(veri2);

   <br><h3>Örnek 14 - replace</h3>
             <br>//string veri="Ayşe";
             <br>//string degistirilmisveri=veri.Replace("A","e");
             <br>//Console.WriteLine(degistirilmisveri);

  <br><h3>Örnek 15 - Remove</h3>
             <br>//string veri="Merhaba Dünya";
             <br>//string dveri=veri.Remove(3,3);
             <br>//Console.WriteLine(dveri);

  <br><h3>Örnek 16- Object Degiskenini Kullanma</h3>
             <br>//object veri;
             <br>//veri="gahsdghas";
             <br>//veri=123;
             <br>//veri='A';
             <br>//Console.WriteLine(veri);

   <br><h3>Örnek 17 - Tip Dönüsümleri</h3>
             <br>//float a;
             <br>//string b="12";
             <br>//a=(float)Convert.ToDouble(b);
             <br>//a=float.Parse(b);
             <br>//b=a.ToString();</p>

