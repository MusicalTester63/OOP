using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
            + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
            + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
            + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
            + "posledni veta!"
            ;

            Console.WriteLine("Test text: " + testovaciText + "\n");

            StringStatistics testString = new StringStatistics(testovaciText);

            //Výpis počtu slov
            Console.WriteLine("Word count: "+testString.CountWords());
            
            //Výpis počtu riadkov
            Console.WriteLine("Line count: " + testString.CountLines());
            
            //Výpis počtu viet
            Console.WriteLine("Sentence count: " + testString.CountSentences());

            int n = 3;
            Console.WriteLine("How many word do you want to print?(If you want to keep default type 0.Default is 3)");
            
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp > 0)
            {
                n = temp;
            }
            



            //Výpis 3 najdlhších slov
            Console.Write(n + " longest words: ");            
            foreach(var word in testString.LongestWords().Take(n)) 
            {            
                Console.Write(word + ", ");
            }
            Console.WriteLine("");


            //Výpis 3 najkretších slov
            Console.Write(n+" shortest words: ");
            foreach (var word in testString.ShortestWords().Take(n))
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine("");


            //Výpis najčastejšieho slova
            Console.Write("Most common word: ");
            foreach (var word in testString.MostOftenWords())
            {
                Console.Write(word);
            }
            Console.WriteLine("");


            //Výpis abecedne zoradených slov
            Console.Write("Alphabetically sorted text: ");
            foreach (var word in testString.sortABC())
            {
                Console.Write(word+", ");
            }
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
