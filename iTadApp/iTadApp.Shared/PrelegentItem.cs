using System;
using System.Collections.Generic;
using System.Text;

namespace iTadApp
{
    public class PrelegentItem
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string PelneImie { get { return imie + " " + nazwisko; } }
        public string opis { get; set; }

        public PrelegentItem(string Imie, string Nazwisko, string Opis)
        {
            imie = Imie;
            nazwisko = Nazwisko;
            opis = Opis;
        }
    }
}
