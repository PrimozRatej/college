namespace GUI
{
    partial class DodajTransakcijo
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
            this.textBoxIšči = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonIšči = new System.Windows.Forms.Button();
            this.dataGridViewIšči = new System.Windows.Forms.DataGridView();
            this.labelObvestila = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxZnesek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonVstavi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIšči)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIšči
            // 
            this.textBoxIšči.Location = new System.Drawing.Point(277, 12);
            this.textBoxIšči.Name = "textBoxIšči";
            this.textBoxIšči.Size = new System.Drawing.Size(100, 20);
            this.textBoxIšči.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Davčna";
            // 
            // ButtonIšči
            // 
            this.ButtonIšči.Location = new System.Drawing.Point(383, 9);
            this.ButtonIšči.Name = "ButtonIšči";
            this.ButtonIšči.Size = new System.Drawing.Size(75, 23);
            this.ButtonIšči.TabIndex = 2;
            this.ButtonIšči.Text = "Išči";
            this.ButtonIšči.UseVisualStyleBackColor = true;
            this.ButtonIšči.Click += new System.EventHandler(this.ButtonIšči_Click);
            // 
            // dataGridViewIšči
            // 
            this.dataGridViewIšči.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIšči.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewIšči.Name = "dataGridViewIšči";
            this.dataGridViewIšči.Size = new System.Drawing.Size(446, 161);
            this.dataGridViewIšči.TabIndex = 3;
            this.dataGridViewIšči.SelectionChanged += new System.EventHandler(this.dataGridViewIšči_SelectionChanged);
            // 
            // labelObvestila
            // 
            this.labelObvestila.AutoSize = true;
            this.labelObvestila.Location = new System.Drawing.Point(13, 219);
            this.labelObvestila.Name = "labelObvestila";
            this.labelObvestila.Size = new System.Drawing.Size(0, 13);
            this.labelObvestila.TabIndex = 4;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonVstavi);
            this.groupBox.Controls.Add(this.monthCalendar1);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.textBoxZnesek);
            this.groupBox.Location = new System.Drawing.Point(12, 290);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(445, 203);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // textBoxZnesek
            // 
            this.textBoxZnesek.Location = new System.Drawing.Point(55, 34);
            this.textBoxZnesek.Name = "textBoxZnesek";
            this.textBoxZnesek.Size = new System.Drawing.Size(100, 20);
            this.textBoxZnesek.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Znesek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(216, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // buttonVstavi
            // 
            this.buttonVstavi.Location = new System.Drawing.Point(9, 168);
            this.buttonVstavi.Name = "buttonVstavi";
            this.buttonVstavi.Size = new System.Drawing.Size(86, 27);
            this.buttonVstavi.TabIndex = 4;
            this.buttonVstavi.Text = "Vstavi";
            this.buttonVstavi.UseVisualStyleBackColor = true;
            this.buttonVstavi.Click += new System.EventHandler(this.buttonVstavi_Click);
            // 
            // DodajTransakcijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 505);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.labelObvestila);
            this.Controls.Add(this.dataGridViewIšči);
            this.Controls.Add(this.ButtonIšči);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIšči);
            this.Name = "DodajTransakcijo";
            this.Text = "DodajTransakcijo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIšči)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIšči;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonIšči;
        private System.Windows.Forms.DataGridView dataGridViewIšči;
        private System.Windows.Forms.Label labelObvestila;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonVstavi;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZnesek;
    }
}