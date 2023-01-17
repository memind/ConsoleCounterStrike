using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStirke
{
    internal abstract class Silah
    {
        public string Marka { get; }
        public string Model { get; }
        public MenzilTipleri MenzilTipi { get; }
        public string Agirlik { get; }

        public virtual void AtesEt() { }


        public enum MenzilTipleri
        {
            YakinMesafe,
            UzakMesafe,
            DahaUzakMesafe
        }
    }
}
