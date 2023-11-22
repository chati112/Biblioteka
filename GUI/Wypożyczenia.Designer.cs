using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class Wypożyczenia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLektura = new System.Windows.Forms.ComboBox();
            this.comboBoxCzytelnik = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataWyp = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataZwrotu = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownIlość = new System.Windows.Forms.NumericUpDown();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonDodajWyp = new System.Windows.Forms.Button();
            this.buttonEdytujWyp = new System.Windows.Forms.Button();
            this.buttonUsuńWyp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlość)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(49, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Czytelnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lektura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data wypożyczenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data zwrotu:";
            // 
            // comboBoxLektura
            // 
            this.comboBoxLektura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLektura.FormattingEnabled = true;
            this.comboBoxLektura.Location = new System.Drawing.Point(100, 338);
            this.comboBoxLektura.Name = "comboBoxLektura";
            this.comboBoxLektura.Size = new System.Drawing.Size(139, 21);
            this.comboBoxLektura.TabIndex = 7;
            // 
            // comboBoxCzytelnik
            // 
            this.comboBoxCzytelnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCzytelnik.FormattingEnabled = true;
            this.comboBoxCzytelnik.Location = new System.Drawing.Point(100, 290);
            this.comboBoxCzytelnik.Name = "comboBoxCzytelnik";
            this.comboBoxCzytelnik.Size = new System.Drawing.Size(139, 21);
            this.comboBoxCzytelnik.TabIndex = 8;
            // 
            // dateTimePickerDataWyp
            // 
            this.dateTimePickerDataWyp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataWyp.Location = new System.Drawing.Point(270, 292);
            this.dateTimePickerDataWyp.Name = "dateTimePickerDataWyp";
            this.dateTimePickerDataWyp.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataWyp.TabIndex = 10;
            // 
            // dateTimePickerDataZwrotu
            // 
            this.dateTimePickerDataZwrotu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataZwrotu.Location = new System.Drawing.Point(270, 337);
            this.dateTimePickerDataZwrotu.Name = "dateTimePickerDataZwrotu";
            this.dateTimePickerDataZwrotu.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataZwrotu.TabIndex = 11;
            // 
            // numericUpDownIlość
            // 
            this.numericUpDownIlość.Location = new System.Drawing.Point(229, 382);
            this.numericUpDownIlość.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownIlość.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIlość.Name = "numericUpDownIlość";
            this.numericUpDownIlość.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownIlość.TabIndex = 12;
            this.numericUpDownIlość.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(606, 184);
            this.dataGridView3.TabIndex = 13;
            // 
            // buttonDodajWyp
            // 
            this.buttonDodajWyp.Location = new System.Drawing.Point(405, 246);
            this.buttonDodajWyp.Name = "buttonDodajWyp";
            this.buttonDodajWyp.Size = new System.Drawing.Size(188, 43);
            this.buttonDodajWyp.TabIndex = 14;
            this.buttonDodajWyp.Text = "DODAJ WYPOŻYCZENIE";
            this.buttonDodajWyp.UseVisualStyleBackColor = true;
            this.buttonDodajWyp.Click += new System.EventHandler(this.buttonDodajWyp_Click_1);
            // 
            // buttonEdytujWyp
            // 
            this.buttonEdytujWyp.Location = new System.Drawing.Point(405, 306);
            this.buttonEdytujWyp.Name = "buttonEdytujWyp";
            this.buttonEdytujWyp.Size = new System.Drawing.Size(188, 43);
            this.buttonEdytujWyp.TabIndex = 15;
            this.buttonEdytujWyp.Text = "EDYTUJ WYPOŻYCZENIE";
            this.buttonEdytujWyp.UseVisualStyleBackColor = true;
            this.buttonEdytujWyp.Click += new System.EventHandler(this.buttonEdytujWyp_Click_1);
            // 
            // buttonUsuńWyp
            // 
            this.buttonUsuńWyp.Location = new System.Drawing.Point(405, 368);
            this.buttonUsuńWyp.Name = "buttonUsuńWyp";
            this.buttonUsuńWyp.Size = new System.Drawing.Size(188, 43);
            this.buttonUsuńWyp.TabIndex = 16;
            this.buttonUsuńWyp.Text = "USUŃ WYPOŻYCZENIE";
            this.buttonUsuńWyp.UseVisualStyleBackColor = true;
            this.buttonUsuńWyp.Click += new System.EventHandler(this.buttonUsuńWyp_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ilość sztuk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            this.label7.Visible = false;
            // 
            // Wypożyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 433);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonUsuńWyp);
            this.Controls.Add(this.buttonEdytujWyp);
            this.Controls.Add(this.buttonDodajWyp);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.numericUpDownIlość);
            this.Controls.Add(this.dateTimePickerDataZwrotu);
            this.Controls.Add(this.dateTimePickerDataWyp);
            this.Controls.Add(this.comboBoxCzytelnik);
            this.Controls.Add(this.comboBoxLektura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wypożyczenia";
            this.Text = "Wypożyczenia";
            this.Load += new System.EventHandler(this.Wypożyczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlość)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonDodajWyp;
        private System.Windows.Forms.Button buttonEdytujWyp;
        private System.Windows.Forms.Button buttonUsuńWyp;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataWyp;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataZwrotu;
        private System.Windows.Forms.ComboBox comboBoxLektura;
        private System.Windows.Forms.ComboBox comboBoxCzytelnik;
        private System.Windows.Forms.NumericUpDown numericUpDownIlość;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}