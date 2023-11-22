using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Czytelnik
    {
        public Czytelnik()
        {
            nr++;
            NrKartyBibliotecznej = nr;
        }

        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public long NrKartyBibliotecznej;
        public override string ToString() => $"{NrKartyBibliotecznej} : {Imie} {Nazwisko}";

        

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int RokUrodzenia { get => rokUrodzenia; set => rokUrodzenia = value; }
        public long nrKartyBbiliotecznej { get => NrKartyBibliotecznej; set => NrKartyBibliotecznej = value; }
        public static long nr = 100;
        public int Wiek {get=> DateTime.Now.Year - RokUrodzenia; }
        

    }
}
