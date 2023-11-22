using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Lektury : Form
    {
        public Ksiazka ksiazka = null;
        public Czasopismo czasopismo = null;

        public Lektury()
        {
            
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void UpdateDataGridView1()
        {

            dataGridView1.Rows.Clear();

            foreach (var ksiazka in Ksiazka.ksiazki)
            {
                int index = dataGridView1.Rows.Add(ksiazka.Id, ksiazka.Tytuł, ksiazka.Autor, ksiazka.NumerISBN, string.Empty, ksiazka.RokWydania, ksiazka.Wydawnictwo, ksiazka.KategoriaWiekowa, ksiazka.IlośćDostępnychSztuk);
                dataGridView1.Rows[index].Tag = ksiazka;
                if (ksiazka.KategoriaWiekowa == KategoriaWiekowa.Dorośli)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }

            foreach (var czasopismo in Czasopismo.czasopisma)
            {
                int index = dataGridView1.Rows.Add(czasopismo.Id, czasopismo.Tytuł, czasopismo.Autor, string.Empty, czasopismo.NumerISSN, czasopismo.RokWydania, czasopismo.Wydawnictwo, czasopismo.KategoriaWiekowa, czasopismo.IlośćDostępnychSztuk);
                dataGridView1.Rows[index].Tag = czasopismo;
                if (czasopismo.KategoriaWiekowa == KategoriaWiekowa.Dorośli)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }

        }



        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAutor.Text) || string.IsNullOrEmpty(textBoxTytul.Text) || string.IsNullOrEmpty(textBoxNumer.Text) || string.IsNullOrEmpty(textBoxWydawnictwo.Text))
            {
                MessageBox.Show("Podaj wszystkie dane lektury !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButtonCzyCzasopismo.Checked == false && radioButtonCzyKsiazka.Checked == false)
            {
                MessageBox.Show("Wybierz typ lektury !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButtonCzyKsiazka.Checked)
            {
                ksiazka = new Ksiazka();
                ksiazka.Tytuł = textBoxTytul.Text;
                ksiazka.Autor = textBoxAutor.Text;
                ksiazka.RokWydania = (int)NumericUpDownRokWydania.Value;
                ksiazka.Wydawnictwo = textBoxWydawnictwo.Text;
                ksiazka.NumerISBN = textBoxNumer.Text;
                ksiazka.IlośćDostępnychSztuk = (int)NumericUpDownIlosc.Value;
                ksiazka.KategoriaWiekowa = (KategoriaWiekowa)comboBoxKategoriaWiekowa.SelectedItem;
                Ksiazka.DodajKsiazke(ksiazka);
            }

            else
            {
                czasopismo = new Czasopismo();
                czasopismo.Tytuł = textBoxTytul.Text;
                czasopismo.Autor = textBoxAutor.Text;
                czasopismo.RokWydania = (int)NumericUpDownRokWydania.Value;
                czasopismo.Wydawnictwo = textBoxWydawnictwo.Text;
                czasopismo.NumerISSN = textBoxNumer.Text;
                czasopismo.IlośćDostępnychSztuk = (int)NumericUpDownIlosc.Value;
                czasopismo.KategoriaWiekowa = (KategoriaWiekowa)comboBoxKategoriaWiekowa.SelectedItem;
                Czasopismo.DodajCzasopismo(czasopismo);
            }

            UpdateDataGridView1();
        }

        private void Lektury_Load(object sender, EventArgs e)
        {
            numericUpDownFiltrujRok.Maximum = DateTime.Now.Year;
            NumericUpDownRokWydania.Maximum = DateTime.Now.Year;
            comboBoxKategoriaWiekowa.DataSource = Enum.GetValues(typeof(KategoriaWiekowa));

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Tytuł", "Tytuł");
            dataGridView1.Columns.Add("Autor", "Autor");
            dataGridView1.Columns.Add("NumerIS", "Numer ISBN");
            dataGridView1.Columns.Add("NumerCS", "Numer ISSN");
            dataGridView1.Columns.Add("Rok wydania", "Rok wydania");
            dataGridView1.Columns.Add("Wydawnictwo", "Wydawnictwo");
            dataGridView1.Columns.Add("Kategoria wiekowa", "Kategoria wiekowa");
            dataGridView1.Columns.Add("Ilość Dost. Szt.", "Ilość Dost. Szt.");
  
            UpdateDataGridView1(); 
        }

        private void buttonDodaj_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAutor.Text) || string.IsNullOrEmpty(textBoxTytul.Text) || string.IsNullOrEmpty(textBoxNumer.Text) || string.IsNullOrEmpty(textBoxWydawnictwo.Text))
            {
                MessageBox.Show("Podaj wszystkie dane lektury !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButtonCzyCzasopismo.Checked == false && radioButtonCzyKsiazka.Checked == false)
            {
                MessageBox.Show("Wybierz typ lektury !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButtonCzyKsiazka.Checked)
            {
                ksiazka = new Ksiazka();
                ksiazka.Tytuł = textBoxTytul.Text;
                ksiazka.Autor = textBoxAutor.Text;
                ksiazka.RokWydania = (int)NumericUpDownRokWydania.Value;
                ksiazka.Wydawnictwo = textBoxWydawnictwo.Text;
                ksiazka.NumerISBN = textBoxNumer.Text;
                ksiazka.IlośćDostępnychSztuk = (int)NumericUpDownIlosc.Value;
                ksiazka.KategoriaWiekowa = (KategoriaWiekowa)comboBoxKategoriaWiekowa.SelectedItem;
                Ksiazka.DodajKsiazke(ksiazka);
            }

            else
            {
                czasopismo = new Czasopismo();
                czasopismo.Tytuł = textBoxTytul.Text;
                czasopismo.Autor = textBoxAutor.Text;
                czasopismo.RokWydania = (int)NumericUpDownRokWydania.Value;
                czasopismo.Wydawnictwo = textBoxWydawnictwo.Text;
                czasopismo.NumerISSN = textBoxNumer.Text;
                czasopismo.IlośćDostępnychSztuk = (int)NumericUpDownIlosc.Value;
                czasopismo.KategoriaWiekowa = (KategoriaWiekowa)comboBoxKategoriaWiekowa.SelectedItem;
                Czasopismo.DodajCzasopismo(czasopismo);
            }

            UpdateDataGridView1();
        }



        private void buttonEdytuj_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Brak danych!");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indeks = dataGridView1.SelectedRows[0].Index;
                DataGridViewCell cell = dataGridView1.Rows[indeks].Cells[3];

                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    Czasopismo czasopismo = new Czasopismo();
                    czasopismo.tytuł = textBoxTytul.Text;
                    czasopismo.Autor = textBoxAutor.Text;
                    czasopismo.Wydawnictwo = textBoxWydawnictwo.Text;
                    czasopismo.NumerISSN = textBoxNumer.Text;
                    czasopismo.rokWydania = (int)NumericUpDownRokWydania.Value;
                    czasopismo.ilośćDostępnychSztuk = (int)NumericUpDownIlosc.Value;
                    Czasopismo.EdytujCzasopismo(indeks, czasopismo);
                }
                else
                {
                    Ksiazka ksiazka = new Ksiazka();
                    ksiazka.tytuł = textBoxTytul.Text;
                    ksiazka.Autor = textBoxAutor.Text;
                    ksiazka.Wydawnictwo = textBoxWydawnictwo.Text;
                    ksiazka.NumerISBN = textBoxNumer.Text;
                    ksiazka.rokWydania = (int)NumericUpDownRokWydania.Value;
                    ksiazka.ilośćDostępnychSztuk = (int)NumericUpDownIlosc.Value;
                    Ksiazka.EdytujKsiazke(indeks, ksiazka);
                }
                UpdateDataGridView1();
                textBoxTytul.Clear();
                textBoxAutor.Clear();
                textBoxNumer.Clear();
                textBoxWydawnictwo.Clear();
                NumericUpDownIlosc.Value = 1;
                NumericUpDownRokWydania.Value = 1900;
            }
        }

        private void buttonUsun_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Brak danych!");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indeks = dataGridView1.SelectedRows[0].Index;
                DataGridViewCell cell = dataGridView1.Rows[indeks].Cells[3];

                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    Czasopismo.UsunCzasopismo((Czasopismo)dataGridView1.SelectedRows[0].Tag);
                    UpdateDataGridView1();
                }
                else Ksiazka.UsunKsiazke((Ksiazka)dataGridView1.SelectedRows[0].Tag);
                UpdateDataGridView1();
                textBoxTytul.Clear();
                textBoxAutor.Clear();
                textBoxNumer.Clear();
                textBoxWydawnictwo.Clear();
                NumericUpDownIlosc.Value = 0;
                NumericUpDownRokWydania.Value = 1900;
            }
        }

        private void buttonFiltruj_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var ksiazka in Ksiazka.ksiazki)
            {
                bool dodaj = true;
                if (checkBoxAutor.Checked && !string.Equals(textBoxFiltrujWydawnictwo.Text.ToLower(), ksiazka.wydawnictwo.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    dodaj = false;
                }

                if (checkBoxWydawnictwo.Checked && !string.Equals(textBoxFiltrujWydawnictwo.Text.ToLower(), ksiazka.wydawnictwo.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    dodaj = false;
                }

                if (checkBoxIlośćSztukDO.Checked && (int)ksiazka.ilośćDostępnychSztuk > numericUpDownFiltrujIlośćDO.Value)
                {
                    dodaj = false;
                }

                if (checkBoxIlośćsztukOD.Checked && (int)ksiazka.ilośćDostępnychSztuk < numericUpDownFiltrujIlośćOD.Value)
                {
                    dodaj = false;
                }

                if (checkBoxRokWydaniaOD.Checked && (int)ksiazka.RokWydania < numericUpDownFiltrujRok.Value)
                {
                    dodaj = false;
                }

                if (checkBoxCzasopismo.Checked && checkBoxKsiazka.Checked == false)
                {
                    dodaj = false;
                }

                if (dodaj == true)
                {
                    int index = dataGridView1.Rows.Add(ksiazka.Id, ksiazka.Tytuł, ksiazka.Autor, ksiazka.NumerISBN, string.Empty, ksiazka.RokWydania, ksiazka.Wydawnictwo,ksiazka.KategoriaWiekowa, ksiazka.IlośćDostępnychSztuk);
                }
            }

            foreach (var czasopismo in Czasopismo.czasopisma)
            {
                bool dodaj = true;
                if (checkBoxAutor.Checked && !string.Equals(textBoxFiltrujAutor.Text.ToLower(), czasopismo.autor.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    dodaj = false;
                }

                if (checkBoxWydawnictwo.Checked && !string.Equals(textBoxFiltrujWydawnictwo.Text.ToLower(), czasopismo.wydawnictwo.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    dodaj = false;
                }

                if (checkBoxIlośćSztukDO.Checked && (int)czasopismo.ilośćDostępnychSztuk > numericUpDownFiltrujIlośćDO.Value)
                {
                    dodaj = false;
                }

                if (checkBoxIlośćsztukOD.Checked && (int)czasopismo.ilośćDostępnychSztuk < numericUpDownFiltrujIlośćOD.Value)
                {
                    dodaj = false;
                }

                if (checkBoxRokWydaniaOD.Checked && (int)czasopismo.RokWydania < numericUpDownFiltrujRok.Value)
                {
                    dodaj = false;
                }

                if (checkBoxKsiazka.Checked && checkBoxCzasopismo.Checked == false)
                {
                    dodaj = false;
                }

                if (dodaj == true)
                {
                    int index = dataGridView1.Rows.Add(czasopismo.Id, czasopismo.Tytuł, czasopismo.Autor, string.Empty, czasopismo.NumerISSN, czasopismo.RokWydania, czasopismo.Wydawnictwo,czasopismo.KategoriaWiekowa, czasopismo.IlośćDostępnychSztuk);
                }
            }
        }
    }
}
