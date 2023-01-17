using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal interface IYakinlastirmaUzaklastirma
    {
        public bool Yakinlastirildi { get; set; }
        //void Yakinlastir();
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
        void Uzaklastir();
    }
}
