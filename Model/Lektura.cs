using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public enum KategoriaWiekowa
    {
        Dzieci,
        Młodzież,
        Dorośli,
    }

    [Serializable]
    public abstract class Lektura
    {
        internal Lektura()
        {
            id++;
            idLektury = id;
        }

        public string tytuł;
        public string autor;
        public int rokWydania;
        public string wydawnictwo;
        public int ilośćDostępnychSztuk;
        public int idLektury;
        private KategoriaWiekowa kategoriaWiekowa;
        public override string ToString() => $"{tytuł} {autor} {RokWydania} ";

        public string Tytuł { get => tytuł; set => tytuł = value; }
        public string Autor { get => autor; set => autor = value; }
        public int RokWydania { get => rokWydania; set => rokWydania = value; }
        public string Wydawnictwo { get => wydawnictwo; set => wydawnictwo = value; }
        public int IlośćDostępnychSztuk { get => ilośćDostępnychSztuk; set => ilośćDostępnychSztuk = value; }
        public static int id = 0;
        public int Id { get => idLektury; set => idLektury = value; }
        public KategoriaWiekowa KategoriaWiekowa { get => kategoriaWiekowa; set => kategoriaWiekowa = value; }


    }
}
