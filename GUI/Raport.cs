using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class Raport : Form
    {
        public Raport()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        int wypozyczenia_ilosc = WypożyczeniaImplementująceInterfejs.wypożyczenia.Count;
        int czytelnicy_ilosc = CzytelnikImplementującyInterfejs.czytelnicy.Count;
        static int ksiazki_ilosc = Ksiazka.ksiazki.Count;
        static int czasopisma_ilosc = Czasopismo.czasopisma.Count;
        int lektury_ilosc = ksiazki_ilosc + czasopisma_ilosc;
        

        private void Raport_Load(object sender, EventArgs e)
        {
            labelRaport.Text = "Obecnie w bibliotece znajduje się:\n " + "- " + ksiazki_ilosc + " książek, \n " + "- " + czasopisma_ilosc + " czasopism \n"
               + "Razem: " + lektury_ilosc + " lektur.\n" + "Aktualnie biblioteka posiada: " + czytelnicy_ilosc + " czytelników i " + wypozyczenia_ilosc + " wypożyczeń.";
        }

        public void GenerujRaport(string NazwaPliku, string text)
        {
            try
            {
                string path = $"../../../Pliki/{NazwaPliku}.txt";
                File.WriteAllText(path, text);
                MessageBox.Show("Pomyślnie wygenerowano raport", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania raportu:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRaport_Click(object sender, EventArgs e)
        {
            GenerujRaport("raport", $"ksiazki:{ksiazki_ilosc}\nczasopisma:{czasopisma_ilosc}\nlektury:{lektury_ilosc}\nczytelnicy:{czytelnicy_ilosc}\n");
        }


    }
}
