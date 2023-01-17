using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal interface IAtesliSilahlar
    {
        public string MermiTipi { get; }
        public int MermiKapasitesi { get; }
        public string Kalibre { get; }
        public int MermiSayisi { get; set; }
        public string AtisSesi { get; }
        public string SarjorSesi { get; }

        void SarjorDoldur();

    }
}
