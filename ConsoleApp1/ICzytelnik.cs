using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public interface ICzytelnik

    {
        

        void DodajCzytelnika(Czytelnik czytelnik);
        void EdytujCzytelnika(int index, Czytelnik czytelnik);
        void UsunCzytelnika(Czytelnik czytelnik);


    }
}
