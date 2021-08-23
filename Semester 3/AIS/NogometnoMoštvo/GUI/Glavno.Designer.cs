namespace GUI
{
    partial class Glavno
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
            this.dataGridGlavni = new System.Windows.Forms.DataGridView();
            this.listBoxFunkcije = new System.Windows.Forms.ListBox();
            this.textBoxIšči = new System.Windows.Forms.TextBox();
            this.buttonIšči = new System.Windows.Forms.Button();
            this.radioButtonTransakcija = new System.Windows.Forms.RadioButton();
            this.radioButtonKomitent = new System.Windows.Forms.RadioButton();
            this.radioButtonRačun = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKajVnesti = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGlavni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGlavni
            // 
            this.dataGridGlavni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGlavni.Location = new System.Drawing.Point(219, 71);
            this.dataGridGlavni.Name = "dataGridGlavni";
            this.dataGridGlavni.Size = new System.Drawing.Size(660, 435);
            this.dataGridGlavni.TabIndex = 0;
            // 
            // listBoxFunkcije
            // 
            this.listBoxFunkcije.FormattingEnabled = true;
            this.listBoxFunkcije.Location = new System.Drawing.Point(12, 71);
            this.listBoxFunkcije.Name = "listBoxFunkcije";
            this.listBoxFunkcije.Size = new System.Drawing.Size(186, 433);
            this.listBoxFunkcije.TabIndex = 1;
            this.listBoxFunkcije.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxIšči
            // 
            this.textBoxIšči.Location = new System.Drawing.Point(1002, 40);
            this.textBoxIšči.Name = "textBoxIšči";
            this.textBoxIšči.Size = new System.Drawing.Size(100, 20);
            this.textBoxIšči.TabIndex = 2;
            // 
            // buttonIšči
            // 
            this.buttonIšči.Location = new System.Drawing.Point(1108, 40);
            this.buttonIšči.Name = "buttonIšči";
            this.buttonIšči.Size = new System.Drawing.Size(75, 23);
            this.buttonIšči.TabIndex = 3;
            this.buttonIšči.Text = "Išči";
            this.buttonIšči.UseVisualStyleBackColor = true;
            this.buttonIšči.Click += new System.EventHandler(this.buttonIšči_Click);
            // 
            // radioButtonTransakcija
            // 
            this.radioButtonTransakcija.AutoSize = true;
            this.radioButtonTransakcija.Location = new System.Drawing.Point(925, 94);
            this.radioButtonTransakcija.Name = "radioButtonTransakcija";
            this.radioButtonTransakcija.Size = new System.Drawing.Size(72, 17);
            this.radioButtonTransakcija.TabIndex = 4;
            this.radioButtonTransakcija.TabStop = true;
            this.radioButtonTransakcija.Text = "transakciji";
            this.radioButtonTransakcija.UseVisualStyleBackColor = true;
            this.radioButtonTransakcija.CheckedChanged += new System.EventHandler(this.radioButtonTransakcija_CheckedChanged);
            // 
            // radioButtonKomitent
            // 
            this.radioButtonKomitent.AutoSize = true;
            this.radioButtonKomitent.Location = new System.Drawing.Point(925, 117);
            this.radioButtonKomitent.Name = "radioButtonKomitent";
            this.radioButtonKomitent.Size = new System.Drawing.Size(72, 17);
            this.radioButtonKomitent.TabIndex = 5;
            this.radioButtonKomitent.TabStop = true;
            this.radioButtonKomitent.Text = "Komitentu";
            this.radioButtonKomitent.UseVisualStyleBackColor = true;
            this.radioButtonKomitent.CheckedChanged += new System.EventHandler(this.radioButtonKomitent_CheckedChanged);
            // 
            // radioButtonRačun
            // 
            this.radioButtonRačun.AutoSize = true;
            this.radioButtonRačun.Location = new System.Drawing.Point(925, 140);
            this.radioButtonRačun.Name = "radioButtonRačun";
            this.radioButtonRačun.Size = new System.Drawing.Size(63, 17);
            this.radioButtonRačun.TabIndex = 6;
            this.radioButtonRačun.TabStop = true;
            this.radioButtonRačun.Text = "Računu";
            this.radioButtonRačun.UseVisualStyleBackColor = true;
            this.radioButtonRačun.CheckedChanged += new System.EventHandler(this.radioButtonRačun_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Išči po";
            // 
            // labelKajVnesti
            // 
            this.labelKajVnesti.AutoSize = true;
            this.labelKajVnesti.Location = new System.Drawing.Point(1020, 94);
            this.labelKajVnesti.Name = "labelKajVnesti";
            this.labelKajVnesti.Size = new System.Drawing.Size(0, 13);
            this.labelKajVnesti.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(888, 40);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 9;
            this.textBoxId.Visible = false;
            // 
            // Glavno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 658);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelKajVnesti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonRačun);
            this.Controls.Add(this.radioButtonKomitent);
            this.Controls.Add(this.radioButtonTransakcija);
            this.Controls.Add(this.buttonIšči);
            this.Controls.Add(this.textBoxIšči);
            this.Controls.Add(this.listBoxFunkcije);
            this.Controls.Add(this.dataGridGlavni);
            this.Name = "Glavno";
            this.Text = "Glavno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavno_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGlavni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGlavni;
        private System.Windows.Forms.ListBox listBoxFunkcije;
        private System.Windows.Forms.TextBox textBoxIšči;
        private System.Windows.Forms.Button buttonIšči;
        private System.Windows.Forms.RadioButton radioButtonTransakcija;
        private System.Windows.Forms.RadioButton radioButtonKomitent;
        private System.Windows.Forms.RadioButton radioButtonRačun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKajVnesti;
        private System.Windows.Forms.TextBox textBoxId;
    }
}