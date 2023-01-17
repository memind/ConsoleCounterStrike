using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal class TaramaliTufek : Tufek 
    {
        public string Tipi { get { return "Taramali Tufek"; } }
        public string MermiTipi { get { return "Cekirdekli"; } }
        public int MermiKapasitesi { get { return 50; } }
        public string Kalibre { get { return "5.56"; } }
        public int MermiSayisi { get; set; }
        public string AtisSesi { get;}
        public string SarjorSesi { get;}

        public int VerilenHasar { get; set; }

        public string Marka { get { return "M4 "; } }
        public string Model { get { return "Carbine"; } }
        public MenzilTipleri MenzilTipi { get { return (MenzilTipleri)2; } }
        public string Agirlik { get { return "3.5"; } }


        public TaramaliTufek()
        {
            MermiSayisi = MermiKapasitesi;
            Yakinlastirildi = false;

            Console.Clear();
            Console.WriteLine($"Tabanca Alindi\n\nMarkasi: {Marka}\nModeli: {Model}\nMenzil Tipi: {MenzilTipi}\nAgirlik: {Agirlik} KG\nTufek Tipi: {Tipi}\nMermi Tipi: {MermiTipi}\nMermi Kapasitesi: {MermiKapasitesi}\nKalibre: {Kalibre}\n");
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
            int hasar = rnd.Next(1, 7);
            VerilenHasar = hasar;

            Console.WriteLine($"Verilen Hasar: {VerilenHasar}");
        }
    }
}
