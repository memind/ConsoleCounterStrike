using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal class Bicak : Silah
    {
        public string Marka { get { return "KABAR"; } }
        public string Model { get { return "KA-1245"; } }
        public MenzilTipleri MenzilTipi { get { return 0; } }
        public double VerilenHasar { get; set; }
        public string Agirlik { get { return "0.33"; } }
        public byte BicakSaglik { get { return 2; } }
        public byte BicakSaglikDurumu { get; set; }

        public Bicak()
        {
            BicakSaglikDurumu = BicakSaglik;
            Console.Clear();
            Console.WriteLine($"Bicak Alindi\n\nMarkasi: {Marka}\nModeli: {Model}\nMenzil Tipi: {MenzilTipi}\nAgirlik: {Agirlik} KG\n");
        }

        public void Bileyle()
        {
            if (BicakSaglikDurumu < BicakSaglik || BicakSaglikDurumu == 0)
            {
                BicakSaglikDurumu = BicakSaglik;
                Console.WriteLine($"Bicak Bileylendi! Bicak Cani: {BicakSaglikDurumu}");
            }

            else
                Console.WriteLine("Bicak Tam Keskin!!");
        }
        public void Kes()
        {
            BicakSaglikDurumu--;
            Console.WriteLine($"Dusman Kesildi! Bicak Cani: {BicakSaglikDurumu}");

            if (BicakSaglikDurumu == 0)
                Bileyle();
        }
    }
}
