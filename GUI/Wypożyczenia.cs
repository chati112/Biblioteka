using Logic;
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
    public partial class Wypożyczenia : Form
    {
        public IWypożyczenie serwiswypożyczeń = new WypożyczeniaImplementująceInterfejs();

        public Wypożyczenia()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Wypożyczenia_Load(object sender, EventArgs e)
        {
            foreach (Czytelnik czytelnik in CzytelnikImplementującyInterfejs.czytelnicy)
            {
                comboBoxCzytelnik.Items.Add(czytelnik);
            }

            foreach (Ksiazka książka in Ksiazka.ksiazki)
            {
                comboBoxLektura.Items.Add(książka);
            }

            foreach (Czasopismo czasopismo in Czasopismo.czasopisma)
            {
                comboBoxLektura.Items.Add(czasopismo);
            }

            dataGridView3.Columns.Add("Nr karty bibl.", "Nr karty bibl.");
            dataGridView3.Columns.Add("Czytelnik", "Czytelnik");
            dataGridView3.Columns.Add("Lektura", "Lektura");
            dataGridView3.Columns.Add("Ilość szt.", "Ilość szt.");
            dataGridView3.Columns.Add("Data wypożyczenia", "Data wypożyczenia");
            dataGridView3.Columns.Add("Data zwrotu", "Data zwrotu");
            dataGridView3.Columns.Add("Ilość dni", "Ilość dni");
            UpdateDataGridView3();
        }

        public void UpdateDataGridView3()
        {
            label7.Text = WypożyczeniaImplementująceInterfejs.wypożyczenia.Count.ToString();

            dataGridView3.Rows.Clear();
            foreach (var wypozyczenie in WypożyczeniaImplementująceInterfejs.wypożyczenia)
            {
                int index = dataGridView3.Rows.Add(wypozyczenie.id_Wypożyczenia, wypozyczenie.czytelnik, wypozyczenie.lektura, wypozyczenie.ilosc, wypozyczenie.dataWypozyczenia.ToString("d.MM.yyyy"), wypozyczenie.dataZwrotu.ToString("d.MM.yyy"), Math.Round(wypozyczenie.CzasWypozyczenia.TotalDays));
                dataGridView3.Rows[index].Tag = wypozyczenie;
            }
        }

        private void buttonDodajWyp_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCzytelnik.SelectedItem == null || comboBoxLektura.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano czytelnika lub lektury!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Compare( dateTimePickerDataZwrotu.Value, dateTimePickerDataWyp.Value) < 0)
            {
                MessageBox.Show("Nie można dodać wypożyczenia z datą wsteczną!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Wypożyczenie wypożyczenie = new Wypożyczenie();
            wypożyczenie.dataWypozyczenia = dateTimePickerDataWyp.Value;
            wypożyczenie.dataZwrotu = dateTimePickerDataZwrotu.Value;
            wypożyczenie.lektura = (Lektura)comboBoxLektura.SelectedItem;
            wypożyczenie.czytelnik = (Czytelnik)comboBoxCzytelnik.SelectedItem;
            wypożyczenie.ilosc = (int)numericUpDownIlość.Value;
            serwiswypożyczeń.DodajWypozyczenie(wypożyczenie);
            UpdateDataGridView3();
            dateTimePickerDataWyp.Value = DateTime.Now;
            dateTimePickerDataZwrotu.Value = DateTime.Now;
            comboBoxCzytelnik.SelectedIndex = -1;
            comboBoxLektura.SelectedIndex = -1;
            numericUpDownIlość.Value = 1;
        }

        private void buttonEdytujWyp_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0 )
            {
                MessageBox.Show("Brak danych!");
                return;
            }
            if (dataGridView3.SelectedRows.Count > 0 & DateTime.Compare(dateTimePickerDataZwrotu.Value, dateTimePickerDataWyp.Value) >= 0)
            {
                int indeks = dataGridView3.SelectedRows[0].Index;
                Wypożyczenie wypożyczenie = new Wypożyczenie();
                wypożyczenie.dataWypozyczenia = dateTimePickerDataWyp.Value;
                wypożyczenie.dataZwrotu = dateTimePickerDataZwrotu.Value;
                wypożyczenie.lektura = (Lektura)comboBoxLektura.SelectedItem;
                wypożyczenie.czytelnik = (Czytelnik)comboBoxCzytelnik.SelectedItem;
                wypożyczenie.ilosc = (int)numericUpDownIlość.Value;
                serwiswypożyczeń.EdytujWypozyczenie(indeks, wypożyczenie);
            }
            UpdateDataGridView3();
            dateTimePickerDataWyp.Value = DateTime.Now;
            dateTimePickerDataZwrotu.Value = DateTime.Now;
            comboBoxCzytelnik.SelectedIndex = -1;
            comboBoxLektura.SelectedIndex = -1;
            numericUpDownIlość.Value = 1;
        }

        private void buttonUsuńWyp_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Brak danych!");
                return;
            }
            serwiswypożyczeń.UsuńWypozyczenie((Wypożyczenie)dataGridView3.SelectedRows[0].Tag);
            UpdateDataGridView3();
            dateTimePickerDataWyp.Value = DateTime.Now;
            dateTimePickerDataZwrotu.Value = DateTime.Now;
            comboBoxCzytelnik.SelectedIndex = -1;
            comboBoxLektura.SelectedIndex = -1;
            numericUpDownIlość.Value = 1;
        }
    }
}
