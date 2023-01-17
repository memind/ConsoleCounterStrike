using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal class Tabanca : Silah, IAtesliSilahlar
    {
        public string MermiTipi { get { return "Cekirdekli"; } }
        public int MermiKapasitesi { get { return 15; } }
        public string Kalibre { get { return "38"; } }
        public int MermiSayisi { get; set; }
        public string AtisSesi { get; }
        public string SarjorSesi { get; }

        public int VerilenHasar { get; set; }


        public string Marka { get { return "Smith & Wesson"; } }
        public string Model { get { return ".357 Magnum"; } }
        public MenzilTipleri MenzilTipi { get { return (MenzilTipleri)1; } }
        public string Agirlik { get { return "1.13"; } }

        public Tabanca()
        {
            Console.Clear();
            MermiSayisi = MermiKapasitesi;

            Console.WriteLine($"Tabanca Alindi\n\nMarkasi: {Marka}\nModeli: {Model}\nMenzil Tipi: {MenzilTipi}\nAgirlik: {Agirlik} KG\nMermi Tipi: {MermiTipi}\nMermi Kapasitesi: {MermiKapasitesi}\nKalibre: {Kalibre}\n");
        }
 
        public void SarjorDoldur()
        {
            if (MermiSayisi < MermiKapasitesi || MermiSayisi == 0)
            {
                MermiSayisi = MermiKapasitesi;
                Console.WriteLine($"Sarjor Dolduruldu. Mermi Sayisi: {MermiSayisi}");
            }
            

            else
                Console.WriteLine("Sarjor Tam Dolu!!");
        }

        public override void AtesEt()
        {
            MermiSayisi--;
            Console.WriteLine($"Ates Edildi! Kalan mermi sayisi: {MermiSayisi}");

            if (MermiSayisi == 0)
                SarjorDoldur();

            Random rnd = new Random();
            int hasar = rnd.Next(1,7);
            VerilenHasar = hasar;

            Console.WriteLine($"Verilen Hasar: {VerilenHasar}");

        }
    }
}
