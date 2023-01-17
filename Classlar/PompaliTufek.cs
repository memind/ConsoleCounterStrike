using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CounterStirke.Silah;

namespace CounterStirke
{
    internal class PompaliTufek : Tufek
    {
        public string Tipi { get { return "Pompali Tufek"; } }
        public string MermiTipi { get { return "Sacma"; } }
        public int MermiKapasitesi { get { return 4; } }
        public string Kalibre { get { return "20 Gauge"; } }
        public int MermiSayisi { get; set; }
        public string AtisSesi { get; }
        public string SarjorSesi { get; }

        public int VerilenHasar { get; set; }

        public bool Yakinlastirildi { get; set; }
        public string Marka { get { return "Wincester"; } }
        public string Model { get { return "Model 21"; } }
        public MenzilTipleri MenzilTipi { get { return 0; } }
        public string Agirlik { get { return "6"; } }

        public PompaliTufek()
        {
            Yakinlastirildi = false;
            MermiSayisi = 0;
            SarjorDoldur();

            Console.WriteLine($"Pompali Tufek Alindi\n\nMarkasi: {Marka}\nModeli: {Model}\nMenzil Tipi: {MenzilTipi}\nAgirlik: {Agirlik} KG\nTufek Tipi: {Tipi}\nMermi Tipi: {MermiTipi}\nMermi Kapasitesi: {MermiKapasitesi}\nKalibre: {Kalibre}\n");
        }

        public void SarjorDoldur()
        {
            if (MermiSayisi < MermiKapasitesi || MermiSayisi == 0)
            {
                for (int sarjordekiMermi = MermiSayisi; sarjordekiMermi < MermiKapasitesi; sarjordekiMermi++)
                {
                    MermiSayisi++;
                    Console.WriteLine($"Mermi Dolduruluyor, Mermi Sayisi: {MermiSayisi}");
                }

                Console.WriteLine($"Sarjor Dolduruldu. Mermi Sayisi: {MermiSayisi}");
            }

            else
                Console.WriteLine("Sarjor Tam Dolu!!");
        }

        public override void AtesEt()
        {
            MermiSayisi--;
            Console.WriteLine($"Ates Edildi! Kalan mermi sayisi: {MermiSayisi}");

            if (MermiSayisi <= 0)
                SarjorDoldur();

            Random rnd = new Random();
            int hasar = rnd.Next(1, 7);
            VerilenHasar = hasar;

            Console.WriteLine($"Verilen Hasar: {VerilenHasar}");
        }
    }
}
