using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathWrite = @"writerTeploty.txt";
            string pathRead = @"readerTeploty.txt";

            ArchivTeplot teploty = new ArchivTeplot();

            teploty.Load(pathRead);
            teploty.TiskTeplot();
            teploty.TiskPrumernychTeplot();
            teploty.TiskPrumernychMesicnichTeplot();

            teploty.Kalibrace(-0.1);
            teploty.Vyhledej(2018);

            teploty.Save(pathWrite);
        }
    }
}
