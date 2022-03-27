using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CV08_Enhanced
{
     class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());



            string pathWrite = @"writerTeploty.txt";
            string pathRead = @"readerTeploty.txt";

            ArchivTeplot teploty = new ArchivTeplot();


            teploty.Load(pathRead);
            teploty.TiskTeplot();
            teploty.TiskPrumernychTeplot();
            teploty.TiskPrumernychMesicnichTeplot();

            Console.Write("Please input calibration constant: ");
            double cal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            teploty.Kalibrace(cal);

            Console.Write("Search: ");
            int year = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            teploty.Vyhledej(year);

            teploty.Save(pathWrite);

        }

     }
}