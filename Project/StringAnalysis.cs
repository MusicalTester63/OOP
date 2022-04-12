using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public class StringAnalysis 
    {
        string text;
        string textNoPunctuation;
                
        public StringAnalysis(string text)
        {

            this.text = text;

            this.textNoPunctuation = Regex.Replace(text, @"[\n]", " ");
            this.textNoPunctuation = Regex.Replace(this.textNoPunctuation, @"[\r]", "");
            this.textNoPunctuation = Regex.Replace(textNoPunctuation, @"[^\w\d\s]+", "");
            this.textNoPunctuation = Regex.Replace(textNoPunctuation, @"\s+", " ");

        }
        public string getText() { return this.text; }
        public string getTextNoPunctuation() { return textNoPunctuation; }
        
        //Metóda na spočítanie slov 
        public int CountWords()
        {
            var count = textNoPunctuation.Split(' ').Length;
            return count;
        }

        //Metóda na spočítanie riadkov 
        public int CountLines()
        {
            var count = text.Split('\n').Length;
            return count;
        }

        //Metóda na spočítanie viet
        public int CountSentences()
        {
            
            var st = Regex.Replace(text, @"[\n]", " ");
            st = Regex.Replace(st, @"[\r]", "");
            st = Regex.Replace(st, @"[,()]", "");

            string[] splitSentences = Regex.Split(st, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");

            return splitSentences.Length;
        }

        //Metóda na zistenie najdlhšieho slova
        public List<string> LongestWords()
        {
            string[] stringOfWords = textNoPunctuation.Split(' ');
            var ordered = stringOfWords.OrderBy(x => x.Length).ToList();   //Zoradenie podľa dĺžky
                                                                           //ToList() Zapísanie slov do listu vzostupne
            ordered.Reverse();

            return ordered;

        }

        //Metóda na zistenie najkratšieho slova(V zásade to isté ako najdlhšie ale pár zmien.)
        public List<string> ShortestWords()
        {
            string[] stringOfWords = textNoPunctuation.Split(' ');
            var ordered = stringOfWords.OrderBy(n => n.Length).ToList();
            
            return ordered;
        }

        //Metóda na zistenie najčastejšieho slova
        public string[] MostOftenWords()
        {
            string[] stringOfWords = textNoPunctuation.Split(' '); //Zapísanie slov do poľa

            var nameGroup = stringOfWords.GroupBy(x => x);  //Zoskupenie rovnakých slov

            int maxCount = nameGroup.Max(g => g.Count());   //Počet najčastejšieho slova

            var mostCommons = nameGroup.Where(x => x.Count() == maxCount) //Vyberie načastejšie slovo
                                       .Select(x => x.Key)
                                       .ToArray();

            return mostCommons;
        }

        //Metóda na zoradnie slov podľa abecedy
        public List<string> sortABC()
        {
            string[] stringOfWords = textNoPunctuation.Split(' ');

            var listWords = new List<string>();

            foreach (var word in stringOfWords)
            {
                listWords.Add(word);            //Pridanie slov do listu
            }

            listWords.Sort();                   //Zoradenie listu podľa abecedy

            return listWords;
        }
    }
}
