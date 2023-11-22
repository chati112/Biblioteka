using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Klasy;

namespace WinFormsApp2
{
    public interface ICzytelnik

    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        int RokUrodzenia { get; set; }
        long NrKartyBibliotecznej { get; set; }

        void DodajCzytelnika(Czytelnik czytelnik);
        void EdytujCzytelnika(int index, Czytelnik czytelnik);
        void UsunCzytelnika(Czytelnik czytelnik);


    }
}
