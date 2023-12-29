using GoFish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp2
{
    
     class Igranje
     {
        List<Karta> karte;

        private List<Igralec> igralci;
        private Dictionary<Vrednosti, Igralec> kompleti;
        private Kup blackJack;
        Random r = new Random();

       

        public Igranje()
        {
            Random r = new Random();    
            blackJack = new Kup(); //ne pozabi, če kličem brez parametrov

            karte = new List<Karta>();
            for (int b = 0; b <= 3; b++)
                for (int v = 1; v <= 13; v++)
                    karte.Add(new Karta((Barve)b, (Vrednosti)v));
            Mešaj();
            igralci = new List<Igralec>();  // imam tu vse možne karte
            Deli();
            //igralci[0].SortRoka();

        }
        public void Deli()
        {
            blackJack.Mešaj();
            for (int i = 0; i < 2; i++)
            {
                foreach (Igralec ig in igralci)
                {
                    ig.VzemiKarto(blackJack.Deli());
                }


                //Tukaj se igra začne. Premešaj kup daj vsakemu igralcu 5 kart
                // nato kliči metodo IzločiKomplete
            }
        }

        public void Mešaj()
        {
            List<Karta> noveKarte = new List<Karta>();
            while (karte.Count > 0)
            {
                int zaPremik = r.Next(karte.Count);
                noveKarte.Add(karte[zaPremik]);
                karte.RemoveAt(zaPremik);
            }
            karte = noveKarte;
        }
        public void Shuffle()
        {
            Random r = new Random();

            int n = karte.Count;
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                Karta card = karte[k];
                karte[k] = karte[n];
                karte[n] = card;
            }
        }
        public List<Karta> DealHand()
        {
            List<Karta> hand = new List<Karta>();
            hand.Add(karte[0]);
            hand.Add(karte[1]);

            karte.RemoveRange(0, 2);

            return hand;
        }
        public Karta DrawCard()
        {
            Karta card = karte[0];
            karte.Remove(card);

            return card;
        }



     }
    

    

}
