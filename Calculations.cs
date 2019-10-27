using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCalculator
{
    class Calculations
    {

        public double Berekenen(string op, double EersteNummer, double TweedeNummer)
        {
            double resultaat;
            resultaat = TweedeNummer; //Voor als iemand een nummer invoert en gelijk op '=' drukt zonder operator te gebruiken.

            if (op == "+")
            {
                resultaat = EersteNummer + TweedeNummer;
            }
            if (op == "-")
            {
                resultaat = EersteNummer + TweedeNummer; //Optellen, omdat de operator "-" ook als getal "-" fungeert, en dus niet dubbel moet aftrekken.
            }
            if (op == "x")
            {
                resultaat = EersteNummer * TweedeNummer;
            }
            if (op == "÷")
            {
                resultaat = EersteNummer / TweedeNummer;
            }
            return resultaat;
        }
    }
}
