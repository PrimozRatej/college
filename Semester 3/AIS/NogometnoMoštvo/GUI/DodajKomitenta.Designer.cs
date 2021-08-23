namespace GUI
{
    partial class buttonDodajKomitenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendarDatumRoj = new System.Windows.Forms.MonthCalendar();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxEMŠO = new System.Windows.Forms.TextBox();
            this.buttonShrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priimek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Davčna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rojstva";
            // 
            // monthCalendarDatumRoj
            // 
            this.monthCalendarDatumRoj.Location = new System.Drawing.Point(111, 170);
            this.monthCalendarDatumRoj.Name = "monthCalendarDatumRoj";
            this.monthCalendarDatumRoj.TabIndex = 4;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(111, 69);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(136, 20);
            this.textBoxIme.TabIndex = 5;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(111, 100);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(136, 20);
            this.textBoxPriimek.TabIndex = 6;
            // 
            // textBoxEMŠO
            // 
            this.textBoxEMŠO.Location = new System.Drawing.Point(111, 127);
            this.textBoxEMŠO.Name = "textBoxEMŠO";
            this.textBoxEMŠO.Size = new System.Drawing.Size(136, 20);
            this.textBoxEMŠO.TabIndex = 7;
            // 
            // buttonShrani
            // 
            this.buttonShrani.Location = new System.Drawing.Point(111, 358);
            this.buttonShrani.Name = "buttonShrani";
            this.buttonShrani.Size = new System.Drawing.Size(75, 23);
            this.buttonShrani.TabIndex = 8;
            this.buttonShrani.Text = "Shrani";
            this.buttonShrani.UseVisualStyleBackColor = true;
            this.buttonShrani.Click += new System.EventHandler(this.buttonShrani_Click);
            // 
            // buttonDodajKomitenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 486);
            this.Controls.Add(this.buttonShrani);
            this.Controls.Add(this.textBoxEMŠO);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.monthCalendarDatumRoj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "buttonDodajKomitenta";
            this.Text = "DodajKomitenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendarDatumRoj;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.TextBox textBoxEMŠO;
        private System.Windows.Forms.Button buttonShrani;
    }
}