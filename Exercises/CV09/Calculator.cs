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
            FirstNumber,
            Operation,
            SecondNumber,
            Result
        };
        private enum Operations
        {
            Plus,
            Minus,
            Multiply,
            Divide
        };

        private Stav _stav = Stav.FirstNumber;
        private Operations operation;

        private string one = "";
        private string two = "";
        private string answer = "";


        public String Display { get; set; }
        public String Memory { get; set; }


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
                    _stav = Stav.Operation;
                    operation = Operations.Plus;
                break;

                case "-":
                    _stav = Stav.Operation;
                    operation = Operations.Minus;
                break;

                case "*":
                    _stav = Stav.Operation;
                    operation = Operations.Multiply;
                break;

                case "/":
                    _stav = Stav.Operation;
                    operation = Operations.Divide;
                break;

                case "=":
                    _stav = Stav.Result;
                    answer = FindAnswer();
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                break;

                case "+-":
                    //Nie je ošetrene ak je displej prázdny


                    if (Display != "")
                    {
                        if (_stav == Stav.FirstNumber)
                        {
                            var tmp = Convert.ToDouble(one) * -1;
                            one = "" + tmp;
                        }
                        if (_stav == Stav.SecondNumber)
                        {
                            var tmp = Convert.ToDouble(two) * -1;
                            two = "" + tmp;
                        }
                    }
                break;

                case "CE":  
                    if (_stav == Stav.FirstNumber)
                    {
                        one = "";
                        Display = one;
                    }
                    if (_stav == Stav.SecondNumber)
                    {
                        two = "";
                        Display = two;
                    }

                    break;

                case "C":   //Všetky
                    _stav = Stav.FirstNumber;
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
                    if (_stav == Stav.FirstNumber)
                    {
                        one = one.Substring(0, one.Length - 1);
                        Display = one;
                    }
                    if (_stav == Stav.SecondNumber)
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
                    if (_stav == Stav.FirstNumber)
                    {
                        one = Memory;
                    }
                    if (_stav == Stav.SecondNumber)
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
                case Stav.FirstNumber:
                    one += cislo;
                    Display = one;
                    break;

                case Stav.SecondNumber:
                    two += cislo;
                    Display = two;
                    break;

                case Stav.Operation:
                    _stav = Stav.SecondNumber;
                break;

                case Stav.Result:
                    _stav = Stav.FirstNumber;
                break;
            }
        }

        private string FindAnswer()
        {
            try { 
            var first = Convert.ToDouble(one);
            var second = Convert.ToDouble(two);
            
                double ans = 0;

                switch (operation)
                {
                    case Operations.Plus:
                        ans = first + second;
                        break;

                    case Operations.Minus:
                        ans = first - second;
                        break;

                    case Operations.Multiply:
                        ans = first * second;
                        break;

                    case Operations.Divide:
                        ans = first / second;
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
