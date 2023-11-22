using Logic;
using Model;
using System;
using System.IO;
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
    public partial class Menu : Form
    {
        public IFileService serwismenu = new MenuImplementująceInterfejs();

        public Menu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            serwismenu.LoadDataFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lektury form1 = new Lektury();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Czytelnicy form2 = new Czytelnicy();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wypożyczenia wypożyczenia = new Wypożyczenia();
            wypożyczenia.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Raport raport = new Raport();
            raport.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            serwismenu.SaveDataToFile();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
