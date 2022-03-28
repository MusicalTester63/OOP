﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08_Enhanced
{
    class ArchivTeplot
    {
        private SortedDictionary<double,RocniTeplota> _archiv;

        public void Load(string path)
        {
            StreamReader reader = File.OpenText(path);
            _archiv = new SortedDictionary<double,RocniTeplota>();
            double rok = 0;
            double cislo = 0;
 
            //prectu jeden radek
            string radek = null;
            while ((radek = reader.ReadLine()) != null)
            {
                List<double> teploty = new List<double>();
                radek = radek.Replace(" ","");
                List<string> values = radek.Split(':',';').ToList();

                for (int i = 0; i < values.Count; i++) {
                    cislo = Convert.ToDouble(values[i]);

                    if (i == 0) rok = cislo;
                    else {
                        teploty.Add(cislo);
                    }
                }

                _archiv.Add(rok, new RocniTeplota(rok, teploty));
            }
        }
        
        public bool Save(string path)
        {
            try { 
            StreamWriter writer = File.CreateText(path);
            foreach (var item in _archiv.Values)
            {
                writer.Write("{0}: ", item.Rok);               

                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    if (i + 1 == item.MesicniTeploty.Count)
                    {
                        writer.Write("{0:0.00} ", item.MesicniTeploty[i]);                       
                    }
                    else
                    {
                        writer.Write("{0:0.00}; ", item.MesicniTeploty[i]);
                    }                        
                }
                writer.WriteLine();
            }
            writer.Close();
            return true;
            }
            catch(Exception e) 
            {
                return false;            
            }   

        }

        public string Kalibrace(double number)
        {
            foreach (var item in _archiv.Values)
            {
                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    item.MesicniTeploty[i] = item.MesicniTeploty[i] + number;
                }
            }
            return TiskTeplot();
        }

        public string Vyhledej(int rok)
        {
            string value = "";
            string defaultValue = "String is null";

            if (_archiv.ContainsKey(rok))
            {
                value += string.Format("{0}: ", _archiv[rok].Rok);
                for (int i = 0; i < _archiv[rok].MesicniTeploty.Count; i++)
                {
                    value += string.Format("{0:0.00} ", _archiv[rok].MesicniTeploty[i])+" ";
                    //value += _archiv[rok].MesicniTeploty[i];
                }
            }
            else { return "Not found"; }

            if (value != null)
            {
                return value;
            }
            else
            {
                return defaultValue;
            }
        }

        public string TiskTeplot()
        {
            string value = "";
            string defaultValue = "String is null";

            foreach(var item in _archiv.Values) 
            {
                value += item.Rok.ToString()+": ";

                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {

                    if (i + 1 == item.MesicniTeploty.Count)
                    {
                        //String.Format("{0:0.0} ", item.MesicniTeploty[i]);
                        value += string.Format("{0:0.00}",item.MesicniTeploty[i])+Environment.NewLine;
                    }
                    else
                    {
                        value += string.Format(" {0:0.00} ", item.MesicniTeploty[i]);
                        //Console.Write("{0:0.0}; ", item.MesicniTeploty[i]);
                    }

                }

            }

            if (value != null)
            {
                return value;
            }
            else
            {
                return defaultValue;
            }
        }

        public string TiskPrumernychTeplot()
        {
            string value = "";
            string defaultValue = "String is null";

            foreach (var item in _archiv.Values)
            {
                value += item.Rok.ToString() + ": ";                
                
                value += string.Format("{0:0.00} ", item.PrumernaRocniTeplota)+Environment.NewLine;
                //Console.Write("{0:0.0}; ", item.MesicniTeploty[i]);
                              

            }

            if (value != null)
            {
                return value;
            }
            else
            {
                return defaultValue;
            }
        }

        public void TiskPrumernychMesicnichTeplot()
        {
            Console.Write("Prum.: ");
            List<double> prumerMesic = new List<double>() {0};
            for(int i = 0; i < 12; i++)
            {
                prumerMesic.Add(0);
            }

            foreach (var item in _archiv.Values)
            {
                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    prumerMesic[i] += item.MesicniTeploty[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                prumerMesic[i] = prumerMesic[i] / _archiv.Keys.Count;
                Console.Write(" {0:0.0};", prumerMesic[i]);
            }
            Console.WriteLine("\n");
        }

    }
}
