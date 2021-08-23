namespace WindowsFormsApplication1
{
    partial class OknoZacetno
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBoxKritičnaVozila = new System.Windows.Forms.ListBox();
            this.buttonVnosPodatkov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(214, 459);
            this.listBox.TabIndex = 0;
            this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // listBoxKritičnaVozila
            // 
            this.listBoxKritičnaVozila.FormattingEnabled = true;
            this.listBoxKritičnaVozila.Location = new System.Drawing.Point(232, 12);
            this.listBoxKritičnaVozila.Name = "listBoxKritičnaVozila";
            this.listBoxKritičnaVozila.Size = new System.Drawing.Size(598, 355);
            this.listBoxKritičnaVozila.TabIndex = 1;
            // 
            // buttonVnosPodatkov
            // 
            this.buttonVnosPodatkov.Location = new System.Drawing.Point(233, 394);
            this.buttonVnosPodatkov.Name = "buttonVnosPodatkov";
            this.buttonVnosPodatkov.Size = new System.Drawing.Size(114, 23);
            this.buttonVnosPodatkov.TabIndex = 2;
            this.buttonVnosPodatkov.Text = "button1";
            this.buttonVnosPodatkov.UseVisualStyleBackColor = true;
            this.buttonVnosPodatkov.Click += new System.EventHandler(this.buttonVnosPodatkov_Click);
            // 
            // OknoZacetno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.buttonVnosPodatkov);
            this.Controls.Add(this.listBoxKritičnaVozila);
            this.Controls.Add(this.listBox);
            this.Name = "OknoZacetno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBoxKritičnaVozila;
        private System.Windows.Forms.Button buttonVnosPodatkov;
    }
}

