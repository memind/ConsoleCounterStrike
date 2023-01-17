using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal class RoketAtar : Silah, IAtesliSilahlar, IYakinlastirmaUzaklastirma
    {
        public string MermiTipi { get { return "Roket"; } }
        public int MermiKapasitesi { get { return 1; } }
        public string Kalibre { get { return "106mm"; } }
        public int MermiSayisi { get; set; }
        public string AtisSesi { get;}
        public string SarjorSesi { get;}

        public int VerilenHasar { get; set; }

        public string Marka { get { return "Bofors Defence"; } }
        public string Model { get { return "RBS 70"; } }
        public MenzilTipleri MenzilTipi { get { return (MenzilTipleri)2; } }
        public string Agirlik { get { return "87"; } }

        public bool Yakinlastirildi { get; set; }

        public RoketAtar()
        {
            MermiSayisi = MermiKapasitesi;
            Yakinlastirildi = false;

            Console.Clear();
            Console.WriteLine($"Roket Atar Alindi\n\nMarkasi: {Marka}\nModeli: {Model}\nMenzil Tipi: {MenzilTipi}\nAgirlik: {Agirlik} KG\nMermi Tipi: {MermiTipi}\nMermi Kapasitesi: {MermiKapasitesi}\nKalibre: {Kalibre}\n");
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

        public void Uzaklastir()
        {
            if (Yakinlastirildi)
            {
                Console.WriteLine("Uzaklastirildi!");
                Yakinlastirildi = false;
            }
            else
                Console.WriteLine("Zaten Uzaklastirilmis Halde!!");
        }

        public void Yakinlastir()
        {
            if (!Yakinlastirildi)
            {
                Console.WriteLine("Yakinlastirildi!");
                Yakinlastirildi = true;
            }
            else
                Console.WriteLine("Zaten Yakinlastirilmis Halde!!");
        }
    }
}
