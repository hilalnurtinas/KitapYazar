using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KitapYazar
{
    internal class Yazar
    {
        public string ad;
        public string soyad;
        public int yas;
        public Kitap[] kitaplar;
        private string TCKimlikNo;
        private static int YazarSayisi = 0; 
        
        //Kitap.cs'de oldugu gibi get set yapmamızın sebebi burada public degerlerin olmasından kaynaklı
        
        public static int YazarSayisiGetir()
        {
            return YazarSayisi;
        }

        public Yazar(string ad, string soyad, int yas)
        {
            this.ad = ad;
            this.soyad = soyad; 
            this.yas = yas;
            YazarSayisi++;
        }

        public Yazar(string ad, string soyad) : this(ad, soyad, 0)
        {
            
        }

        public void KitapEkle(Kitap k)
        {
            if(kitaplar == null)
            {
                // 1 elemanlı dizi oluşturup kitap ekledik
                kitaplar = new Kitap[1];
                kitaplar[0] = k;
            }
            else
            {
                int kitapSayisi = this.kitaplar.Length; 
                int temp = kitapSayisi + 1; //kitap sayısına 1 ekliyoruz yeni kitap ekleyebilmek için
                int i;

                Kitap[] kitaplarYedek = new Kitap[temp];

                for (i = 0; i < kitapSayisi; i++)//kitaplarYedek dizisine kitaplar dizisindeki kitapları ekliyoruz
                {
                    kitaplarYedek[i] = kitaplar[i];
                }
                kitaplarYedek[i] = k;//eklemek istenilen k kitabını kitaplarYedek dizisine attık
                this.kitaplar = kitaplarYedek; //kitaplarYedek dizisini, kitaplara at yani kitaplar dizisine kopyala
            }
        }

        public void yazarTanit()
        {
            string text = "Yazar Ad: " + ad;
            text += "\t Soyad: " + soyad;
            text += "\t Yas: " + yas;
            text += "\n Kitap Listesi:  ";
            Console.WriteLine(text);

            if (kitaplar != null)
            {
                foreach (Kitap k in kitaplar)
                {
                    k.kitapTanit();
                }
            }
            else
            {
                Console.WriteLine("Yazarın henüz kitabı yok!!!");
            }
        }
    }
}
