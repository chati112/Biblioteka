using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IWypożyczenie
    {
        void DodajWypozyczenie(Wypożyczenie wypożyczenie);
        void UsuńWypozyczenie(Wypożyczenie wypożyczenie);
        void EdytujWypozyczenie(int index, Wypożyczenie wypożyczenie);
    }
}
