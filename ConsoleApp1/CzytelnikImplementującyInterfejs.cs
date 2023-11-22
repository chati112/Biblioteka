
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{

    public class CzytelnikImplementującyInterfejs : ICzytelnik
    {
        public static List<Czytelnik> czytelnicy = new List<Czytelnik>();

        public void DodajCzytelnika(Czytelnik czytelnik)
        {
            czytelnicy.Add(czytelnik);
        }

        public void EdytujCzytelnika(int index, Czytelnik czytelnik)
        {
            czytelnicy[index].Imie = czytelnik.Imie;
            czytelnicy[index].Nazwisko = czytelnik.Nazwisko;
            czytelnicy[index].RokUrodzenia = czytelnik.RokUrodzenia;
            czytelnicy[index].NrKartyBibliotecznej = czytelnik.NrKartyBibliotecznej;
        }

        public void UsunCzytelnika(Czytelnik czytelnik)
        {
            czytelnicy.Remove(czytelnik);
        }

    }
}
