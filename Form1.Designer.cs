namespace KlasaArrayListt
{
    partial class Form1
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
            this.buttonNovi = new System.Windows.Forms.Button();
            this.textBoxNovi = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(13, 13);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(110, 26);
            this.buttonNovi.TabIndex = 0;
            this.buttonNovi.Text = "Novi automobil";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNovi
            // 
            this.textBoxNovi.Enabled = false;
            this.textBoxNovi.Location = new System.Drawing.Point(12, 56);
            this.textBoxNovi.Name = "textBoxNovi";
            this.textBoxNovi.Size = new System.Drawing.Size(150, 20);
            this.textBoxNovi.TabIndex = 1;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Enabled = false;
            this.buttonUnesi.Location = new System.Drawing.Point(181, 56);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(76, 20);
            this.buttonUnesi.TabIndex = 2;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(244, 165);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(12, 282);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(111, 23);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obrisi listu";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 327);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBoxNovi);
            this.Controls.Add(this.buttonNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.TextBox textBoxNovi;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonObrisi;
    }
}

