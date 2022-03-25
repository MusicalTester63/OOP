using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni7
{
    class RocniTeplota
    {
        private double rok;
        private List<double> mesicniTeploty;
        private double maxTeplota;
        private double minTeplota;
        private double prumernaRocniTeplota;

        public RocniTeplota(double rok, List<double> teploty)
        {
            this.rok = rok;
            this.mesicniTeploty = new List<double>();
            this.mesicniTeploty = teploty;
        }

        public double MaxTeplota
        {
            get
            {
                maxTeplota = mesicniTeploty[0];
                foreach (double teplota in mesicniTeploty)
                {
                    if (teplota > maxTeplota)
                    {
                        maxTeplota = teplota;
                    }
                }
                return maxTeplota;
            }
        }

        public double MinTeplota
        {
            get
            {
                minTeplota = mesicniTeploty[0];
                foreach (double teplota in mesicniTeploty)
                {
                    if (teplota < minTeplota)
                    {
                        minTeplota = teplota;
                    }
                }
                return minTeplota;
            }
        }

        public double PrumernaRocniTeplota
        {
            get
            {
                prumernaRocniTeplota = mesicniTeploty.Average();
                return prumernaRocniTeplota;
            }
        }

        public int pocet()
        {
            return mesicniTeploty.Count;
        }

        public double Rok
        {
            get { return rok; }
            set { rok = value; }
        }

        public List<double> MesicniTeploty
        {
            get=> mesicniTeploty;
            set=> mesicniTeploty = value; 
        }
        
        

        

        
        
    }   

}
