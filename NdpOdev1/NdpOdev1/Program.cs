/****************************************************************************
**                            SAKARYA ÜNİVERSİTESİ
**                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                          2019-2020 BAHAR DÖNEMİ
**
**           ÖDEV NUMARASI..........: 1
**           ÖĞRENCİ ADI............: Emrecan Güzelaydın    
**           ÖĞRENCİ NUMARASI.......: B191200301
**           DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace OgrenciKontrol

{
    class Ogrenci
    {
        // Özelliklere diğer sınıflardan erişebiliriz. (Public)
        public string AdSoyad;
        public int Numara;
        public int Sinif;
        public string VeliAdiSoyadi;

    }
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr = new Ogrenci();
            int toplamogrenci = 0;
            ArrayList OgrenciListesi = new ArrayList();
        //koleksiyon olusturuldu...
        basa: Console.WriteLine(".......Ogrenci Kayit Sistemi.......");
            Console.WriteLine("...................................");
            Console.WriteLine("Yapacaginiz islemi seciniz.........");
            Console.WriteLine("1-Ogrenci Kayit Ekleme");
            Console.WriteLine("2-Ogrenci Kayit Silme");
            Console.WriteLine("3-Ogrenci Kayit Goruntuleme");
            Console.WriteLine("4-Diziyi ters cevir");
            Console.WriteLine("5-Kayit Kontrol");
            Console.WriteLine("6-Diziyi sirala");
            Console.WriteLine("7-Tum kayitlari sil!");
            Console.WriteLine("8-Öğrenci Kayıt Listesini Yazdırma");
            Console.WriteLine("9-Ogrenci Kayit Cikis");
            Console.WriteLine("...................................");
            Console.WriteLine(" ");

            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1://burada öğrenci ekliyoruz
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogrenci Kayit Ekleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yapacaginiz ogrenci sayisini giriniz :");
                    int sayi = int.Parse(Console.ReadLine());

                    for (int i = 0; i < sayi; i++)
                    {
                        Console.Write(i + 1 + ".ci Öğrencinin Adı Soyadı\n");
                        ogr.AdSoyad = Console.ReadLine();
                        Console.Write("\nNumarası\n");
                        ogr.Numara = int.Parse(Console.ReadLine());
                        Console.Write("\nSınıfı\n");
                        ogr.Sinif = int.Parse(Console.ReadLine());
                        Console.Write("\nVeli Adı Soyadı\n");
                        ogr.VeliAdiSoyadi = (Console.ReadLine());
                        string GeriDondur()
                        {
                            return ogr.AdSoyad + " " + ogr.Numara + " " + ogr.Sinif + " " + ogr.VeliAdiSoyadi;
                        }
                        string gecici = GeriDondur();
                        OgrenciListesi.Add(gecici);
                    }

                    for (int i = 0; i < sayi; i++)
                    {
                        toplamogrenci++;
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ekleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;
                case 2: //burada öğrenci siliyoruz
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogrenci Kayit Silme Ekranina Hosgeldiniz...");
                    Console.WriteLine("Adı Soyadı...: Numarası...: Sınıfı...: Veli Adı Soyadı...: ");
                    foreach (object gecici in OgrenciListesi)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kaydini sileceğiniz öğrencinin adını, numarasını, sınıfını, velisini bir bosluk bırakarak ve yukarıdaki şekilde  giriniz!!! Aksi takdirde hata verecektir.!!");
                    string silme = Console.ReadLine();
                    if (OgrenciListesi.Contains(silme))
                    {
                        OgrenciListesi.Remove(silme);
                        toplamogrenci--;
                    }
                    else
                    {
                        Console.WriteLine("*****Silmek istenen öğrenci kayıtı bulunamadı.*****");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit silme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;
                case 3://burada kayıtlarımızı görüntülüyoruz
                    Console.WriteLine("Ogrenci Kayit Goruntuleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Adı Soyadı...: Numarası...: Sınıfı...: Veli Adı Soyadı...: ");
                    foreach (object gecici in OgrenciListesi)
                    {
                        Console.WriteLine(gecici);
                    }

                    Console.WriteLine(" " + "Toplam Öğrenci Sayısı....: " + toplamogrenci);
                    Console.WriteLine("Kayit goruntuleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;
                case 4://burada kayıtları ters çeviriyoruz
                    Console.WriteLine(" ");
                    //tabi bilgiler bellekte gecici tutuldugu icin once kayit ekleme yapmaniz gerekmektedir...
                    Console.WriteLine("Kayitlari ters cevirme islemi");
                    Console.WriteLine("Adı Soyadı...: Numarası...: Sınıfı...: Veli Adı Soyadı...: ");
                    OgrenciListesi.Reverse();
                    foreach (object gecici in OgrenciListesi)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ters cevirme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;
                case 5://burada istenilen bilgileri girerek kayıtları görüntüleyebiliyoruz
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayıt kontrol islemi");
                    Console.Write("Kayıtını kontrol etmek istediğiniz ögrencinin adını, numarasını sınıfını ve velisini bir bosluk bırakarak giriniz!!! Aksi takdirde hata verecektir.!!: ");
                    Console.WriteLine("Adı Soyadı...: Numarası...: Sınıfı...: Veli Adı Soyadı...: ");
                    string kontrol = Console.ReadLine();
                    if (OgrenciListesi.Contains(kontrol) == true)
                    {
                        Console.WriteLine("Kayit dizide mevcut...");
                    }
                    else
                    {
                        Console.WriteLine("Kayit dizide mevcut degil...");
                    }
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    goto basa;
                case 6://burada ise öğrenciler alfabetik bir şekilde sıralanıyor
                    Console.WriteLine(" ");
                    Console.WriteLine("Diziyi alfabetik siralama islemi");
                    Console.WriteLine("Adı Soyadı...: Numarası...: Sınıfı...: Veli Adı Soyadı...: ");
                    OgrenciListesi.Sort();
                    foreach (object gecici in OgrenciListesi)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    goto basa;
                case 7:// burada öğrencilerimizi tümüyle silebiliyoruz
                    Console.WriteLine(" ");
                    Console.WriteLine("Tum dizi silindi!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    OgrenciListesi.Clear();
                    goto basa;
                case 8:
                    Console.WriteLine("Ogrenci kayitlarini yazdirmaya hosgeldiniz.");
                    Console.WriteLine(" ");
                    Console.WriteLine("******** ********** ******** ********* ********");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yazdirmalar basariyla tamamlanmistir. Press Enter");
                    Console.WriteLine(" ");
                    using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\emrec\source\repos\NdpOdev1\ogrenciler.txt", true))
                    {
                        dosya.Write("Adı Soyadı/  " + "Numarası/  " + "Sınıfı/  " + "Veli Adı Soyadı/\n");
                        foreach (object gecici in OgrenciListesi)
                        {
                            dosya.WriteLine(gecici);
                        }

                    }
                    Console.ReadLine();
                    goto basa;
                case 9:
                    break;
                default:
                    Console.WriteLine("Lutfen 1 ile 8 arasinda bir numara giriniz!");
                    goto basa;
            }
        }
    }
}