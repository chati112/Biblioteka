namespace GUI
{
    partial class Raport
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
            this.buttonRaport = new System.Windows.Forms.Button();
            this.labelRaport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRaport
            // 
            this.buttonRaport.Location = new System.Drawing.Point(232, 336);
            this.buttonRaport.Name = "buttonRaport";
            this.buttonRaport.Size = new System.Drawing.Size(288, 50);
            this.buttonRaport.TabIndex = 0;
            this.buttonRaport.Text = "GENERUJ RAPORT DO PLIKU .TXT";
            this.buttonRaport.UseVisualStyleBackColor = true;
            this.buttonRaport.Click += new System.EventHandler(this.buttonRaport_Click);
            // 
            // labelRaport
            // 
            this.labelRaport.AutoSize = true;
            this.labelRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRaport.Location = new System.Drawing.Point(170, 80);
            this.labelRaport.Name = "labelRaport";
            this.labelRaport.Size = new System.Drawing.Size(70, 25);
            this.labelRaport.TabIndex = 1;
            this.labelRaport.Text = "label1";
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRaport);
            this.Controls.Add(this.buttonRaport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raport";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Raport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRaport;
        private System.Windows.Forms.Label labelRaport;
    }
}