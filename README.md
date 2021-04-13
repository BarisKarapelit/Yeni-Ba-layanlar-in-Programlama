# Yeni-Baslayanlar-icin-Programlama
<br><h2>Uyg1-Visual_Studio_Ortamini_Kullanma</h2><br>

<br><h2>Uyg2_SabitlerveDegiskenler</h2><br>
 Ornek1
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
  
  <br><h3>#region Örnek 7 - ToLower<h3>
             <br>//string veri = "MerhAba DÜnya";
             <br>//Console.WriteLine(veri.ToLower());
            #endregion
  
   #region Örnek 8- ToUpper
            //string veri = "MerhAba DÜnya";
            //Console.WriteLine(veri.ToUpper());
            #endregion
            #region Örnek 9 - Trim
            //string veri = "      MerhAba DÜnya       ";
            //Console.Write(veri.Trim());
            #endregion
            #region Örnek 10 - Substring
            //string veri = "MerhAba DÜnya";
            //Console.WriteLine(veri.Substring(8,5));
            #endregion
            #region Örnek 11 - IndexOf
            //string veri = "MerhAba DÜnya";
            //Console.WriteLine(veri.IndexOf('D'));
            #endregion
            #region Örnek 12 - Concat
            //string veri1 = "Ali", veri2 = "Ahmet";
            //string veri3=String.Concat(veri1," ",veri2);
            //Console.WriteLine(veri3);
            #endregion
            #region ÖRnek 13 - Insert
            //string veri="Ali Veli";
            //string veri2=veri.Insert(4,"ve ");
            //Console.WriteLine(veri2);
            #endregion
            #region Örnek 14 - replace
            //string veri="Ayşe";
            //string degistirilmisveri=veri.Replace("A","e");
            //Console.WriteLine(degistirilmisveri);
            #endregion
            #region ÖRnek 15 - Remove
            //string veri="Merhaba Dünya";
            //string dveri=veri.Remove(3,3);
            //Console.WriteLine(dveri);
            #endregion
            #region ÖRnek 16- Object Degiskenini Kullanma
            //object veri;
            //veri="gahsdghas";
            //veri=123;
            //veri='A';
            //Console.WriteLine(veri);
            #endregion
            #region ÖRnek 17 - Tip Dönüsümleri
            float a;
            string b="12";
            a=(float)Convert.ToDouble(b);
            a=float.Parse(b);
            b=a.ToString();
            #endregion   
