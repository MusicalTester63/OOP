﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Project
{
    public class StringStatistics
    {
        string text;
        string textNoPunctuation;


        //Constructor, vymazanie interpunkčných znamienok
        public StringStatistics(string text) {

            this.text = text;

            textNoPunctuation = text.Replace(".", "")
                                    .Replace(",", "")
                                    .Replace("?", "")
                                    .Replace("!", "")           //Odstránenie interpunkcie
                                    .Replace("\n", " ")
                                    .Replace("(", "")
                                    .Replace(")", "");
        
        }



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
            var st = text.Replace("\n", " ")
                         .Replace(",", "")
                         .Replace("(", "")
                         .Replace(")", "");

            string[] splitSentences = Regex.Split(st, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");

            return splitSentences.Length;
        }


        //Metóda na zistenie najdlhšieho slova
        public List<string> LongestWords()
        {
            string[] stringOfWords = textNoPunctuation.Split(' ');
            List<string> ordered = stringOfWords.OrderBy(x => x.Length) //Zoradenie podľa dĺžky
                                                .ToList();             //Zapísanie slov do listu vzostupne
            
            ordered.Reverse();                                         //Obrátenie poradia na zostupné

           //foreach(var word in ordered){Console.WriteLine("* "+word);}

            return ordered;

        }


        //Metóda na zistenie najkratšieho slova(V zásade to isté ako najdlhšie ale pár zmien.)
        public List<string> ShortestWords()
        {
            string[] stringOfWords = textNoPunctuation.Split(' ');
            var ordered = stringOfWords.OrderBy(x => x.Length).ToList();                       
            return ordered;
        }


        //Metóda na zistenie najčastejšieho slova
        public string[] MostOftenWords()
        {
            string[] stringOfWords = textNoPunctuation.Split(' '); //Zapísanie slov do poľa
            
            /*
            foreach(string word in stringOfWords)
            {
                Console.Write(word+" ");
            }*/

            var nameGroup = stringOfWords.GroupBy(x => x);  //Zoskupenie rovnakých slov

            /*
            foreach (var group in nameGroup)
            {
                Console.WriteLine(group.Key + ": ");
                foreach(var x in group)
                {
                    Console.WriteLine("* "+x);
                }
            }*/

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
