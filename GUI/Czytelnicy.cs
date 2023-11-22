using System;
using System.Collections.Generic;
using System.ComponentModel;
using Logic;
using Model;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Czytelnicy : Form
    {
        public ICzytelnik serwisczytelników = new CzytelnikImplementującyInterfejs();
        
        public Czytelnicy()
        {
            
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Czytelnicy_Load_1(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("Nr Karty", "Nr Karty");
            dataGridView2.Columns.Add("Imię", "Imię");
            dataGridView2.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView2.Columns.Add("Rok Urodzenia", "Rok Urodzenia");
            dataGridView2.Columns.Add("Wiek", "Wiek");
            UpdatedataGridView2();
            numericUpDownRokUrodzenia.Maximum = DateTime.Now.Year - 1;
        }

        private void UpdatedataGridView2()
        {
            label2.Text = CzytelnikImplementującyInterfejs.czytelnicy.Count.ToString();

            dataGridView2.Rows.Clear();

            foreach (var czytelnik in CzytelnikImplementującyInterfejs.czytelnicy)
            {
                int index = dataGridView2.Rows.Add(czytelnik.NrKartyBibliotecznej, czytelnik.Imie, czytelnik.Nazwisko, czytelnik.RokUrodzenia, czytelnik.Wiek);
                dataGridView2.Rows[index].Tag = czytelnik;
            }

        }

        private void buttonEdytuj_Click_1(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Brak danych!");
                return;
            }
            if (!Regex.IsMatch(textBoxImie.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(textBoxNazwisko.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Imię i nazwisko mogą zawierać tylko litery!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView2.SelectedRows.Count > 0)
            {
                int indeks = dataGridView2.SelectedRows[0].Index;
                Czytelnik czytelnik = new Czytelnik();
                czytelnik.Imie = textBoxImie.Text;
                czytelnik.Nazwisko = textBoxNazwisko.Text;
                czytelnik.RokUrodzenia = (int)numericUpDownRokUrodzenia.Value;
                serwisczytelników.EdytujCzytelnika(indeks, czytelnik);
            }
            UpdatedataGridView2();
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
            numericUpDownRokUrodzenia.Value = 1900;
        }

        private void buttonUsun_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Brak danych!");
                return;
            }
            serwisczytelników.UsunCzytelnika((Czytelnik)dataGridView2.SelectedRows[0].Tag);
            UpdatedataGridView2();
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
        }
        
        private void buttonDodaj_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBoxImie.Text) || string.IsNullOrEmpty(textBoxNazwisko.Text))
            {
                MessageBox.Show("Podaj wszystkie dane czytelnika !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxImie.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(textBoxNazwisko.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Imię i nazwisko mogą zawierać tylko litery!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Czytelnik czytelnik = new Czytelnik();
            czytelnik.Imie = textBoxImie.Text;
            czytelnik.Nazwisko = textBoxNazwisko.Text;
            czytelnik.RokUrodzenia = (int)numericUpDownRokUrodzenia.Value;
            serwisczytelników.DodajCzytelnika(czytelnik);
            UpdatedataGridView2();
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
            numericUpDownRokUrodzenia.Value = 1900;
            
        }
    }
}
