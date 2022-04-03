using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV09
{
    internal class Calculator
    {
        private enum Stav
        {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };
        private enum Operations
        {
            Plus,
            Minus,
            Multiply,
            Divide
        };

        private Stav _stav = Stav.PrvniCislo;
        private Operations operation;

        private string one = "";
        private string two = "";
        private string answer = "";


        public String Display { get; set; }//co se má zobrazit.
        public String Memory { get; set; }//vzdy prazdne


        public void Tlacitko(String btn)
        {

            var cislo = "";

            switch (btn)
            {
                case "0":
                    cislo += "0";
                    break;

                case "1":
                    cislo += "1";
                    break;

                case "2":
                    cislo += "2";
                    break;

                case "3":
                    cislo += "3";
                    break;

                case "4":
                    cislo += "4";
                    break;

                case "5":
                    cislo += "5";
                    break;

                case "6":
                    cislo += "6";
                    break;

                case "7":
                    cislo += "7";
                    break;

                case "8":
                    cislo += "8";
                    break;

                case "9":
                    cislo += "9";
                    break;

                case "+":
                    _stav = Stav.Operace;
                    operation = Operations.Plus;
                break;

                case "-":
                    _stav = Stav.Operace;
                    operation = Operations.Minus;
                break;

                case "*":
                    _stav = Stav.Operace;
                    operation = Operations.Multiply;
                break;

                case "/":
                    _stav = Stav.Operace;
                    operation = Operations.Divide;
                break;

                case "=":
                    _stav = Stav.Vysledek;
                    answer = FindAnswer();
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                break;

                case "+-":
                    if (Display != "")
                    {
                        if (_stav == Stav.PrvniCislo)
                        {
                            var tmp = Convert.ToDouble(one) * -1;
                            one = "" + tmp;
                        }
                        if (_stav == Stav.DruheCislo)
                        {
                            var tmp = Convert.ToDouble(two) * -1;
                            two = "" + tmp;
                        }
                    }
                break;

                case "CE":  //Zobrazené
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = "";
                        Display = one;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = "";
                        Display = two;
                    }

                    break;

                case "C":   //Všetky
                    _stav = Stav.PrvniCislo;
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                    break;

                case "<=":  //one letter
                    
                    if (Display == "" || Display == null)
                    {
                        break;
                    }
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = one.Substring(0, one.Length - 1);
                        Display = one;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = one.Substring(0, two.Length - 1);
                        Display = two;
                    }

                    break;

                case "MS":
                    if (Display != "" || Display != null) { 

                    Memory = Display;
                    
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "MR":
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = Memory;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = Memory;
                    }
                    Display = Memory;
                    break;

                case "MC":
                    Memory = "";
                    break;

                default:
                    break;
            }

            switch (_stav)
            {
                case Stav.PrvniCislo:
                    one += cislo;
                    Display = one;
                    break;

                case Stav.DruheCislo:
                    two += cislo;
                    Display = two;
                    break;

                case Stav.Operace:
                    _stav = Stav.DruheCislo;
                    break;

                case Stav.Vysledek:
                    _stav = Stav.PrvniCislo;
                    break;
            }
        }

        private string FindAnswer()
        {
            try { 
            var o = Convert.ToDouble(one);
            var t = Convert.ToDouble(two);
            
                double ans = 0;

                switch (operation)
                {
                    case Operations.Plus:
                        ans = o + t;
                        break;

                    case Operations.Minus:
                        ans = o - t;
                        break;

                    case Operations.Multiply:
                        ans = o * t;
                        break;

                    case Operations.Divide:
                        ans = o / t;
                        break;
                }
                return "" + ans;


            }
            catch (Exception ex)
            {
                return "";
            }
        }



    }
}
