using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Ksiazka : Lektura
    {
        public string NumerISBN { get; set; }

        public static List<Ksiazka> ksiazki = new List<Ksiazka>();

        public static void DodajKsiazke(Ksiazka ksiazka)
        {
            ksiazki.Add(ksiazka);
            
        }

        public static void UsunKsiazke(Ksiazka ksiazka)
        {
            ksiazki.Remove(ksiazka);
        }

        public static void EdytujKsiazke(int index, Ksiazka ksiazka)
        {
            ksiazki[index].Tytuł = ksiazka.Tytuł;
            ksiazki[index].Autor = ksiazka.Autor;
            ksiazki[index].RokWydania = ksiazka.RokWydania;
            ksiazki[index].Wydawnictwo = ksiazka.Wydawnictwo;
            ksiazki[index].IlośćDostępnychSztuk = ksiazka.IlośćDostępnychSztuk;
            ksiazki[index].NumerISBN = ksiazka.NumerISBN;
            ksiazki[index].Id = ksiazka.Id;
        }
    }

}
