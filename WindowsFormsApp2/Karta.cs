using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    enum Barve { Križ, Pik, Karo, Srce }
    enum Vrednosti { As = 1, Dva, Tri, Štiri, Pet, Šest, Sedem, Osem, Devet, Deset, Janez, Dama, Kralj }
    internal class Karta
    {
        public Barve Barva { get; set; }
        public Vrednosti Vrednost { get; set; }
        public int Value { get; set; }
        public char Symbol { get; }




        public Karta(Barve b, Vrednosti v)
        {
            Barva = b;
            Vrednost = v;
            
            switch (Barva)
            {
                case Barve.Križ:
                    Symbol = '♣';
                    break;
                case Barve.Pik:
                    Symbol = '♠';
                    break;
                case Barve.Karo:
                    Symbol = '♦';
                    break;
                case Barve.Srce:
                    Symbol = '♥';
                    break;
            }
            switch (Vrednost)
            {
                case Vrednosti.Deset:
                case Vrednosti.Janez:
                case Vrednosti.Dama:
                case Vrednosti.Kralj:
                    Value = 10;
                    break;
                case Vrednosti.As:
                    Value = 11;
                    break;
                default:
                    Value = (int)Vrednost /*+ 1*/;
                    break;
            }
        
        }
        public Karta() { }
        public string Ime
        {
            get { return Vrednost.ToString() + " " + Barva.ToString(); }
        }
        public override string ToString()
        {
            return Ime;
        }
    }
}
