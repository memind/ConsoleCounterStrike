using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal abstract class Tufek : Silah, IAtesliSilahlar, IYakinlastirmaUzaklastirma
    {
        public string Tipi { get; }
        public string MermiTipi { get; }
        public int MermiKapasitesi { get; }
        public string Kalibre { get; }
        public int MermiSayisi { get; set; }
        public string AtisSesi { get; }
        public string SarjorSesi { get; }
        public bool Yakinlastirildi { get; set; }


        public void SarjorDoldur(){}

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

        public override void AtesEt() { }
    }
}
