using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    partial class Lektury
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxKategoriaWiekowa = new System.Windows.Forms.ComboBox();
            this.textBoxNumer = new System.Windows.Forms.TextBox();
            this.textBoxWydawnictwo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTytul = new System.Windows.Forms.TextBox();
            this.NumericUpDownRokWydania = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownIlosc = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCzyKsiazka = new System.Windows.Forms.RadioButton();
            this.radioButtonCzyCzasopismo = new System.Windows.Forms.RadioButton();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonFiltruj = new System.Windows.Forms.Button();
            this.checkBoxRokWydaniaOD = new System.Windows.Forms.CheckBox();
            this.checkBoxIlośćSztukDO = new System.Windows.Forms.CheckBox();
            this.checkBoxIlośćsztukOD = new System.Windows.Forms.CheckBox();
            this.checkBoxAutor = new System.Windows.Forms.CheckBox();
            this.checkBoxWydawnictwo = new System.Windows.Forms.CheckBox();
            this.checkBoxKsiazka = new System.Windows.Forms.CheckBox();
            this.checkBoxCzasopismo = new System.Windows.Forms.CheckBox();
            this.numericUpDownFiltrujRok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFiltrujIlośćOD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFiltrujIlośćDO = new System.Windows.Forms.NumericUpDown();
            this.textBoxFiltrujAutor = new System.Windows.Forms.TextBox();
            this.textBoxFiltrujWydawnictwo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRokWydania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćDO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxKategoriaWiekowa
            // 
            this.comboBoxKategoriaWiekowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategoriaWiekowa.FormattingEnabled = true;
            this.comboBoxKategoriaWiekowa.Location = new System.Drawing.Point(10, 24);
            this.comboBoxKategoriaWiekowa.Name = "comboBoxKategoriaWiekowa";
            this.comboBoxKategoriaWiekowa.Size = new System.Drawing.Size(313, 21);
            this.comboBoxKategoriaWiekowa.TabIndex = 36;
            // 
            // textBoxNumer
            // 
            this.textBoxNumer.Location = new System.Drawing.Point(9, 149);
            this.textBoxNumer.Name = "textBoxNumer";
            this.textBoxNumer.Size = new System.Drawing.Size(151, 20);
            this.textBoxNumer.TabIndex = 1;
            // 
            // textBoxWydawnictwo
            // 
            this.textBoxWydawnictwo.Location = new System.Drawing.Point(174, 65);
            this.textBoxWydawnictwo.Name = "textBoxWydawnictwo";
            this.textBoxWydawnictwo.Size = new System.Drawing.Size(151, 20);
            this.textBoxWydawnictwo.TabIndex = 12;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(9, 104);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(151, 20);
            this.textBoxAutor.TabIndex = 2;
            // 
            // textBoxTytul
            // 
            this.textBoxTytul.Location = new System.Drawing.Point(9, 62);
            this.textBoxTytul.Name = "textBoxTytul";
            this.textBoxTytul.Size = new System.Drawing.Size(151, 20);
            this.textBoxTytul.TabIndex = 3;
            // 
            // NumericUpDownRokWydania
            // 
            this.NumericUpDownRokWydania.Location = new System.Drawing.Point(175, 104);
            this.NumericUpDownRokWydania.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.NumericUpDownRokWydania.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownRokWydania.Name = "NumericUpDownRokWydania";
            this.NumericUpDownRokWydania.Size = new System.Drawing.Size(149, 20);
            this.NumericUpDownRokWydania.TabIndex = 20;
            this.NumericUpDownRokWydania.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // NumericUpDownIlosc
            // 
            this.NumericUpDownIlosc.Location = new System.Drawing.Point(175, 149);
            this.NumericUpDownIlosc.Name = "NumericUpDownIlosc";
            this.NumericUpDownIlosc.Size = new System.Drawing.Size(149, 20);
            this.NumericUpDownIlosc.TabIndex = 11;
            this.NumericUpDownIlosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonCzyKsiazka
            // 
            this.radioButtonCzyKsiazka.AutoSize = true;
            this.radioButtonCzyKsiazka.Location = new System.Drawing.Point(10, 174);
            this.radioButtonCzyKsiazka.Name = "radioButtonCzyKsiazka";
            this.radioButtonCzyKsiazka.Size = new System.Drawing.Size(62, 17);
            this.radioButtonCzyKsiazka.TabIndex = 13;
            this.radioButtonCzyKsiazka.TabStop = true;
            this.radioButtonCzyKsiazka.Text = "Książka";
            this.radioButtonCzyKsiazka.UseVisualStyleBackColor = true;
            // 
            // radioButtonCzyCzasopismo
            // 
            this.radioButtonCzyCzasopismo.AutoSize = true;
            this.radioButtonCzyCzasopismo.Location = new System.Drawing.Point(175, 180);
            this.radioButtonCzyCzasopismo.Name = "radioButtonCzyCzasopismo";
            this.radioButtonCzyCzasopismo.Size = new System.Drawing.Size(81, 17);
            this.radioButtonCzyCzasopismo.TabIndex = 6;
            this.radioButtonCzyCzasopismo.TabStop = true;
            this.radioButtonCzyCzasopismo.Text = "Czasopismo";
            this.radioButtonCzyCzasopismo.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(8, 202);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(316, 42);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click_1);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(7, 302);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(320, 42);
            this.buttonUsun.TabIndex = 5;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click_1);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(7, 250);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(316, 46);
            this.buttonEdytuj.TabIndex = 7;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click_1);
            // 
            // buttonFiltruj
            // 
            this.buttonFiltruj.Location = new System.Drawing.Point(9, 197);
            this.buttonFiltruj.Name = "buttonFiltruj";
            this.buttonFiltruj.Size = new System.Drawing.Size(304, 29);
            this.buttonFiltruj.TabIndex = 35;
            this.buttonFiltruj.Text = "FILTRUJ";
            this.buttonFiltruj.UseVisualStyleBackColor = true;
            this.buttonFiltruj.Click += new System.EventHandler(this.buttonFiltruj_Click_1);
            // 
            // checkBoxRokWydaniaOD
            // 
            this.checkBoxRokWydaniaOD.AutoSize = true;
            this.checkBoxRokWydaniaOD.Location = new System.Drawing.Point(8, 31);
            this.checkBoxRokWydaniaOD.Name = "checkBoxRokWydaniaOD";
            this.checkBoxRokWydaniaOD.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRokWydaniaOD.TabIndex = 39;
            this.checkBoxRokWydaniaOD.Text = "Rok wydania od:";
            this.checkBoxRokWydaniaOD.UseVisualStyleBackColor = true;
            // 
            // checkBoxIlośćSztukDO
            // 
            this.checkBoxIlośćSztukDO.AutoSize = true;
            this.checkBoxIlośćSztukDO.Location = new System.Drawing.Point(169, 67);
            this.checkBoxIlośćSztukDO.Name = "checkBoxIlośćSztukDO";
            this.checkBoxIlośćSztukDO.Size = new System.Drawing.Size(94, 17);
            this.checkBoxIlośćSztukDO.TabIndex = 36;
            this.checkBoxIlośćSztukDO.Text = "Ilość sztuk do:";
            this.checkBoxIlośćSztukDO.UseVisualStyleBackColor = true;
            // 
            // checkBoxIlośćsztukOD
            // 
            this.checkBoxIlośćsztukOD.AutoSize = true;
            this.checkBoxIlośćsztukOD.Location = new System.Drawing.Point(8, 67);
            this.checkBoxIlośćsztukOD.Name = "checkBoxIlośćsztukOD";
            this.checkBoxIlośćsztukOD.Size = new System.Drawing.Size(94, 17);
            this.checkBoxIlośćsztukOD.TabIndex = 40;
            this.checkBoxIlośćsztukOD.Text = "Ilość sztuk od:";
            this.checkBoxIlośćsztukOD.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutor
            // 
            this.checkBoxAutor.AutoSize = true;
            this.checkBoxAutor.Location = new System.Drawing.Point(164, 115);
            this.checkBoxAutor.Name = "checkBoxAutor";
            this.checkBoxAutor.Size = new System.Drawing.Size(54, 17);
            this.checkBoxAutor.TabIndex = 42;
            this.checkBoxAutor.Text = "Autor:";
            this.checkBoxAutor.UseVisualStyleBackColor = true;
            // 
            // checkBoxWydawnictwo
            // 
            this.checkBoxWydawnictwo.AutoSize = true;
            this.checkBoxWydawnictwo.Location = new System.Drawing.Point(9, 115);
            this.checkBoxWydawnictwo.Name = "checkBoxWydawnictwo";
            this.checkBoxWydawnictwo.Size = new System.Drawing.Size(96, 17);
            this.checkBoxWydawnictwo.TabIndex = 41;
            this.checkBoxWydawnictwo.Text = "Wydawnictwo:";
            this.checkBoxWydawnictwo.UseVisualStyleBackColor = true;
            // 
            // checkBoxKsiazka
            // 
            this.checkBoxKsiazka.AutoSize = true;
            this.checkBoxKsiazka.Location = new System.Drawing.Point(9, 174);
            this.checkBoxKsiazka.Name = "checkBoxKsiazka";
            this.checkBoxKsiazka.Size = new System.Drawing.Size(63, 17);
            this.checkBoxKsiazka.TabIndex = 38;
            this.checkBoxKsiazka.Text = "Książka";
            this.checkBoxKsiazka.UseVisualStyleBackColor = true;
            // 
            // checkBoxCzasopismo
            // 
            this.checkBoxCzasopismo.AutoSize = true;
            this.checkBoxCzasopismo.Location = new System.Drawing.Point(167, 174);
            this.checkBoxCzasopismo.Name = "checkBoxCzasopismo";
            this.checkBoxCzasopismo.Size = new System.Drawing.Size(82, 17);
            this.checkBoxCzasopismo.TabIndex = 39;
            this.checkBoxCzasopismo.Text = "Czasopismo";
            this.checkBoxCzasopismo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFiltrujRok
            // 
            this.numericUpDownFiltrujRok.Location = new System.Drawing.Point(110, 28);
            this.numericUpDownFiltrujRok.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownFiltrujRok.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownFiltrujRok.Name = "numericUpDownFiltrujRok";
            this.numericUpDownFiltrujRok.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownFiltrujRok.TabIndex = 34;
            this.numericUpDownFiltrujRok.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownFiltrujIlośćOD
            // 
            this.numericUpDownFiltrujIlośćOD.Location = new System.Drawing.Point(99, 63);
            this.numericUpDownFiltrujIlośćOD.Name = "numericUpDownFiltrujIlośćOD";
            this.numericUpDownFiltrujIlośćOD.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownFiltrujIlośćOD.TabIndex = 25;
            this.numericUpDownFiltrujIlośćOD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownFiltrujIlośćDO
            // 
            this.numericUpDownFiltrujIlośćDO.Location = new System.Drawing.Point(260, 63);
            this.numericUpDownFiltrujIlośćDO.Name = "numericUpDownFiltrujIlośćDO";
            this.numericUpDownFiltrujIlośćDO.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownFiltrujIlośćDO.TabIndex = 36;
            this.numericUpDownFiltrujIlośćDO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxFiltrujAutor
            // 
            this.textBoxFiltrujAutor.Location = new System.Drawing.Point(167, 138);
            this.textBoxFiltrujAutor.Name = "textBoxFiltrujAutor";
            this.textBoxFiltrujAutor.Size = new System.Drawing.Size(109, 20);
            this.textBoxFiltrujAutor.TabIndex = 22;
            // 
            // textBoxFiltrujWydawnictwo
            // 
            this.textBoxFiltrujWydawnictwo.Location = new System.Drawing.Point(9, 138);
            this.textBoxFiltrujWydawnictwo.Name = "textBoxFiltrujWydawnictwo";
            this.textBoxFiltrujWydawnictwo.Size = new System.Drawing.Size(109, 20);
            this.textBoxFiltrujWydawnictwo.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFiltruj);
            this.groupBox1.Controls.Add(this.numericUpDownFiltrujIlośćDO);
            this.groupBox1.Controls.Add(this.textBoxFiltrujAutor);
            this.groupBox1.Controls.Add(this.numericUpDownFiltrujIlośćOD);
            this.groupBox1.Controls.Add(this.textBoxFiltrujWydawnictwo);
            this.groupBox1.Controls.Add(this.numericUpDownFiltrujRok);
            this.groupBox1.Controls.Add(this.checkBoxIlośćsztukOD);
            this.groupBox1.Controls.Add(this.checkBoxKsiazka);
            this.groupBox1.Controls.Add(this.checkBoxIlośćSztukDO);
            this.groupBox1.Controls.Add(this.checkBoxAutor);
            this.groupBox1.Controls.Add(this.checkBoxRokWydaniaOD);
            this.groupBox1.Controls.Add(this.checkBoxCzasopismo);
            this.groupBox1.Controls.Add(this.checkBoxWydawnictwo);
            this.groupBox1.Location = new System.Drawing.Point(7, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 232);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROWANIE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Numer inwentarzowy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Kategoria wiekowa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ilość dostępnych sztuk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Wydawnictwo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Rok wydania:";
            // 
            // Lektury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 589);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.radioButtonCzyCzasopismo);
            this.Controls.Add(this.radioButtonCzyKsiazka);
            this.Controls.Add(this.NumericUpDownIlosc);
            this.Controls.Add(this.NumericUpDownRokWydania);
            this.Controls.Add(this.textBoxTytul);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxWydawnictwo);
            this.Controls.Add(this.textBoxNumer);
            this.Controls.Add(this.comboBoxKategoriaWiekowa);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lektury";
            this.Text = "Lektury";
            this.Load += new System.EventHandler(this.Lektury_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRokWydania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltrujIlośćDO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxKategoriaWiekowa;
        private System.Windows.Forms.TextBox textBoxNumer;
        private System.Windows.Forms.TextBox textBoxWydawnictwo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTytul;
        private System.Windows.Forms.NumericUpDown NumericUpDownRokWydania;
        private System.Windows.Forms.NumericUpDown NumericUpDownIlosc;
        private System.Windows.Forms.RadioButton radioButtonCzyKsiazka;
        private System.Windows.Forms.RadioButton radioButtonCzyCzasopismo;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonFiltruj;
        private System.Windows.Forms.CheckBox checkBoxRokWydaniaOD;
        private System.Windows.Forms.CheckBox checkBoxIlośćSztukDO;
        private System.Windows.Forms.CheckBox checkBoxIlośćsztukOD;
        private System.Windows.Forms.CheckBox checkBoxAutor;
        private System.Windows.Forms.CheckBox checkBoxWydawnictwo;
        private System.Windows.Forms.CheckBox checkBoxKsiazka;
        private System.Windows.Forms.CheckBox checkBoxCzasopismo;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltrujRok;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltrujIlośćOD;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltrujIlośćDO;
        private System.Windows.Forms.TextBox textBoxFiltrujAutor;
        private System.Windows.Forms.TextBox textBoxFiltrujWydawnictwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}