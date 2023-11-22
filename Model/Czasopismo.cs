using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Czasopismo : Lektura
    {
        public string NumerISSN { get; set; }
        public static List<Czasopismo> czasopisma = new List<Czasopismo>();

        public static void DodajCzasopismo(Czasopismo czasopismo)
        {
            czasopisma.Add(czasopismo);
        }

        public static void UsunCzasopismo(Czasopismo czasopismo)
        {
            czasopisma.Remove(czasopismo);
        }

        public static void EdytujCzasopismo(int index, Czasopismo czasopismo)
        {
            czasopisma[index].Tytuł = czasopismo.Tytuł;
            czasopisma[index].Autor = czasopismo.Autor;
            czasopisma[index].RokWydania = czasopismo.RokWydania;
            czasopisma[index].Wydawnictwo = czasopismo.Wydawnictwo;
            czasopisma[index].IlośćDostępnychSztuk = czasopismo.IlośćDostępnychSztuk;
            czasopisma[index].NumerISSN = czasopismo.NumerISSN;
            czasopisma[index].Id=czasopismo.Id;
                
        }
    }
}
