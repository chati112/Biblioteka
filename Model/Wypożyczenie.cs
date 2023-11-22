using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Wypożyczenie
    {
        public Wypożyczenie()
        {
            id++;
            id_Wypożyczenia = id;
        }

        public int id_Wypożyczenia;
        public DateTime dataWypozyczenia;
        public DateTime dataZwrotu;
        public Czytelnik czytelnik;
        public Lektura lektura;
        public int ilosc;
        
        public int Id_Wypożyczenia { get => id_Wypożyczenia; set => id_Wypożyczenia = value; }
        public DateTime DataWypozyczenia { get => dataWypozyczenia; set => dataWypozyczenia = value; }
        public DateTime DataZwrotu { get => dataZwrotu; set => dataZwrotu = value; }
        public Czytelnik Czytelnik { get => czytelnik; set => czytelnik = value; }
        public Lektura Lektura { get => lektura; set => lektura = value; }
        public int Ilosc { get => ilosc; set => ilosc = value; }
        public  int id = 0;

        public TimeSpan CzasWypozyczenia
        {
            get
            {
                if (dataZwrotu != DateTime.MinValue)
                {
                    TimeSpan roznicaCzasu = dataZwrotu - dataWypozyczenia; 
                    return roznicaCzasu; 
                }
                else
                {
                    TimeSpan roznicaCzasu = DateTime.Now - dataWypozyczenia;
                    return roznicaCzasu; 
                }
            }
        }

        
    }
}
