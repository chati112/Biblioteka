using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public class WypożyczeniaImplementująceInterfejs : IWypożyczenie
    {
        public static List<Wypożyczenie> wypożyczenia = new List<Wypożyczenie>();

        public  void DodajWypozyczenie(Wypożyczenie wypożyczenie)
        {
            wypożyczenia.Add(wypożyczenie);
        }

        public  void EdytujWypozyczenie(int index, Wypożyczenie wypożyczenie)
        {
            wypożyczenia[index].dataWypozyczenia = wypożyczenie.dataWypozyczenia;
            wypożyczenia[index].dataZwrotu = wypożyczenie.dataZwrotu;
            wypożyczenia[index].czytelnik = wypożyczenie.czytelnik;
            wypożyczenia[index].lektura = wypożyczenie.lektura;
            wypożyczenia[index].ilosc = wypożyczenie.ilosc;
        }

        public  void UsuńWypozyczenie(Wypożyczenie wypożyczenie)
        {
            wypożyczenia.Remove(wypożyczenie);
        }
    }
}
