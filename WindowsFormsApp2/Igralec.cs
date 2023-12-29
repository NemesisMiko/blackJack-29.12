using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace GoFish
{
    internal class Igralec //clovek ali racunalnik
    {
        public string Ime;
        public Kup roka; // Karte, ki jih ima igralec v roki
        Random r = new Random();

        //igralec izloči komplete
        public IEnumerable<Vrednosti> IzlociKomplete()
        {
            List<Vrednosti> kompleti = new List<Vrednosti>();
            for (int i = 1; i < 13; i++)
            {
                Vrednosti v = (Vrednosti)i;
                int st = 0;
                for (int k = 0; k < roka.Count; k++)
                {
                    if (roka.Peek(k).Vrednost == v)
                        st++;
                }
                if (st == 4)
                {
                    kompleti.Add(v);
                    roka.PullOutValues(v);
                }
            }

            return kompleti;
        }
        //računalnik mora izbrati naključno vrednost, a jo mora imeti v rokah
        public Vrednosti DobiNakljucnoVrednost()
        {
            Karta n = roka.Peek(r.Next(roka.Count));
            return n.Vrednost;
        }
        //ImašKakšno?



        public int ŠtevecKart { get { return roka.Count; } }
        public void VzemiKarto(Karta k)
        {
            roka.Add(k);
        }
        public IEnumerable<string> Imena()
        {
            return roka.ImenaKart();
        }
        public Karta Peek(int št)
        {
            return roka.Peek(št);
        }
        //public void SortRoka()
        //{
        //    roka.Sort();
        //}
    }
}
