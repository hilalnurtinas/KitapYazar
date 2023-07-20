using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYazar
{
    internal class Kitap
    {
        private string kitapAdi;
        private int kitapYil;
        private int sayfaSayisi;

        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public int KitapYil { get => kitapYil; set => kitapYil = value; }
        public int SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }

        
        public void setKitapAdi(string kitapAdi)
        {
            this.kitapAdi = kitapAdi;
        }

        public string getKitapAdi()
        {
            return this.kitapAdi;
        }


        //constructor method
        public Kitap(string kitapAdi, int kitapYil, int sayfaSayisi)
        {
            this.KitapAdi = kitapAdi;
            this.KitapYil = kitapYil;  
            this.sayfaSayisi = sayfaSayisi;
        }

        public void kitapTanit()
        {
            string text = "Kitap Adı: " + KitapAdi;
            text += "\t Yıl: " + KitapYil;
            text += "\t Sayfa Sayısı: " + SayfaSayisi;
            Console.WriteLine(text);
        }

        public static bool operator !=(Kitap k1, Kitap k2)
        {
            return !(k1 == k2); 
        }

        public static bool operator ==(Kitap k1, Kitap k2)
        {
            bool result = (k1.kitapAdi == k2.kitapAdi) && (k1.sayfaSayisi == k2.sayfaSayisi) && (k1.kitapYil == k2.kitapYil);
            return result;
        }



    }
}
