namespace KitapYazar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Yazar y1 = new Yazar("Hilal Nur", "Tınas", 22);
            Yazar y2 = new Yazar("Ayşe", "Öztürk", 25);

            Kitap k1 = new Kitap("Java", 2018, 500);
            Kitap k2 = new Kitap("C", 2025, 500);
            Kitap k3 = new Kitap("Math", 2021, 900);
            Kitap k4 = new Kitap("C", 2018, 500);
            Kitap k5 = new Kitap("C#", 2018, 100);

            bool durum1 = k1 == k2; //false
            bool durum2 = k2 == k4; //false

            Console.WriteLine(k1.ToString() + "-----" + k2.ToString() + "-----" + k3.ToString() );
            Console.WriteLine(durum1 + "------->" + durum2);

            y1.KitapEkle(k1);
            y1.KitapEkle(k2);
            y1.KitapEkle(k3);

            y2.KitapEkle(k2);
            y2.KitapEkle(k5);

            Console.WriteLine("Toplam Yazar Sayısı: {0} ", Yazar.YazarSayisiGetir());

            y1.yazarTanit();
            y2.yazarTanit();




        }
    }
}
