namespace FerkvencnaAnaliza
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
            this.refDatButton = new System.Windows.Forms.Button();
            this.refDatTextBlock = new System.Windows.Forms.RichTextBox();
            this.analizaIzpisTextBlock = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.izpisAnalizeŠifDat = new System.Windows.Forms.RichTextBox();
            this.izpisŠifDat = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.desifriraj = new System.Windows.Forms.Button();
            this.dešifriranNiz = new System.Windows.Forms.RichTextBox();
            this.crkaKiJoZamenjujemoTextBlock = new System.Windows.Forms.TextBox();
            this.Zamenjaj = new System.Windows.Forms.Button();
            this.crkaZaZamenjavo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grafReferencna = new System.Windows.Forms.Button();
            this.grafSifrirna = new System.Windows.Forms.Button();
            this.grafOdkriptirana = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refDatButton
            // 
            this.refDatButton.Location = new System.Drawing.Point(92, 40);
            this.refDatButton.Name = "refDatButton";
            this.refDatButton.Size = new System.Drawing.Size(105, 23);
            this.refDatButton.TabIndex = 0;
            this.refDatButton.Text = "Dodaj ref. dat";
            this.refDatButton.UseVisualStyleBackColor = true;
            this.refDatButton.Click += new System.EventHandler(this.refDatButton_Click);
            // 
            // refDatTextBlock
            // 
            this.refDatTextBlock.Location = new System.Drawing.Point(92, 69);
            this.refDatTextBlock.Name = "refDatTextBlock";
            this.refDatTextBlock.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.refDatTextBlock.Size = new System.Drawing.Size(320, 376);
            this.refDatTextBlock.TabIndex = 1;
            this.refDatTextBlock.Text = "";
            // 
            // analizaIzpisTextBlock
            // 
            this.analizaIzpisTextBlock.Location = new System.Drawing.Point(12, 69);
            this.analizaIzpisTextBlock.Name = "analizaIzpisTextBlock";
            this.analizaIzpisTextBlock.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.analizaIzpisTextBlock.Size = new System.Drawing.Size(74, 376);
            this.analizaIzpisTextBlock.TabIndex = 2;
            this.analizaIzpisTextBlock.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Analiza referenčne datoteke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Št. Ponovitev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Št. Ponovitev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Analiza šifrirane datoteke";
            // 
            // izpisAnalizeŠifDat
            // 
            this.izpisAnalizeŠifDat.Location = new System.Drawing.Point(454, 69);
            this.izpisAnalizeŠifDat.Name = "izpisAnalizeŠifDat";
            this.izpisAnalizeŠifDat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.izpisAnalizeŠifDat.Size = new System.Drawing.Size(74, 376);
            this.izpisAnalizeŠifDat.TabIndex = 7;
            this.izpisAnalizeŠifDat.Text = "";
            // 
            // izpisŠifDat
            // 
            this.izpisŠifDat.Location = new System.Drawing.Point(534, 69);
            this.izpisŠifDat.Name = "izpisŠifDat";
            this.izpisŠifDat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.izpisŠifDat.Size = new System.Drawing.Size(320, 376);
            this.izpisŠifDat.TabIndex = 6;
            this.izpisŠifDat.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj šif. dat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // desifriraj
            // 
            this.desifriraj.Location = new System.Drawing.Point(860, 67);
            this.desifriraj.Name = "desifriraj";
            this.desifriraj.Size = new System.Drawing.Size(54, 23);
            this.desifriraj.TabIndex = 10;
            this.desifriraj.Text = "Encript";
            this.desifriraj.UseVisualStyleBackColor = true;
            this.desifriraj.Click += new System.EventHandler(this.desifriraj_Click);
            // 
            // dešifriranNiz
            // 
            this.dešifriranNiz.Location = new System.Drawing.Point(1000, 67);
            this.dešifriranNiz.Name = "dešifriranNiz";
            this.dešifriranNiz.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dešifriranNiz.Size = new System.Drawing.Size(320, 376);
            this.dešifriranNiz.TabIndex = 11;
            this.dešifriranNiz.Text = "";
            // 
            // crkaKiJoZamenjujemoTextBlock
            // 
            this.crkaKiJoZamenjujemoTextBlock.Location = new System.Drawing.Point(898, 179);
            this.crkaKiJoZamenjujemoTextBlock.Name = "crkaKiJoZamenjujemoTextBlock";
            this.crkaKiJoZamenjujemoTextBlock.Size = new System.Drawing.Size(36, 20);
            this.crkaKiJoZamenjujemoTextBlock.TabIndex = 12;
            // 
            // Zamenjaj
            // 
            this.Zamenjaj.Location = new System.Drawing.Point(881, 221);
            this.Zamenjaj.Name = "Zamenjaj";
            this.Zamenjaj.Size = new System.Drawing.Size(75, 23);
            this.Zamenjaj.TabIndex = 13;
            this.Zamenjaj.Text = "zamenjaj";
            this.Zamenjaj.UseVisualStyleBackColor = true;
            this.Zamenjaj.Click += new System.EventHandler(this.Zamenjaj_Click);
            // 
            // crkaZaZamenjavo
            // 
            this.crkaZaZamenjavo.Location = new System.Drawing.Point(898, 272);
            this.crkaZaZamenjavo.Name = "crkaZaZamenjavo";
            this.crkaZaZamenjavo.Size = new System.Drawing.Size(36, 20);
            this.crkaZaZamenjavo.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1000, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Shrani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grafReferencna
            // 
            this.grafReferencna.Location = new System.Drawing.Point(92, 452);
            this.grafReferencna.Name = "grafReferencna";
            this.grafReferencna.Size = new System.Drawing.Size(75, 23);
            this.grafReferencna.TabIndex = 16;
            this.grafReferencna.Text = "Graf";
            this.grafReferencna.UseVisualStyleBackColor = true;
            this.grafReferencna.Click += new System.EventHandler(this.grafReferencna_Click);
            // 
            // grafSifrirna
            // 
            this.grafSifrirna.Location = new System.Drawing.Point(534, 450);
            this.grafSifrirna.Name = "grafSifrirna";
            this.grafSifrirna.Size = new System.Drawing.Size(75, 23);
            this.grafSifrirna.TabIndex = 17;
            this.grafSifrirna.Text = "Graf";
            this.grafSifrirna.UseVisualStyleBackColor = true;
            this.grafSifrirna.Click += new System.EventHandler(this.grafSifrirna_Click);
            // 
            // grafOdkriptirana
            // 
            this.grafOdkriptirana.Location = new System.Drawing.Point(1081, 449);
            this.grafOdkriptirana.Name = "grafOdkriptirana";
            this.grafOdkriptirana.Size = new System.Drawing.Size(75, 23);
            this.grafOdkriptirana.TabIndex = 18;
            this.grafOdkriptirana.Text = "Graf";
            this.grafOdkriptirana.UseVisualStyleBackColor = true;
            this.grafOdkriptirana.Click += new System.EventHandler(this.grafOdkriptirana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 503);
            this.Controls.Add(this.grafOdkriptirana);
            this.Controls.Add(this.grafSifrirna);
            this.Controls.Add(this.grafReferencna);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crkaZaZamenjavo);
            this.Controls.Add(this.Zamenjaj);
            this.Controls.Add(this.crkaKiJoZamenjujemoTextBlock);
            this.Controls.Add(this.dešifriranNiz);
            this.Controls.Add(this.desifriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.izpisAnalizeŠifDat);
            this.Controls.Add(this.izpisŠifDat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analizaIzpisTextBlock);
            this.Controls.Add(this.refDatTextBlock);
            this.Controls.Add(this.refDatButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refDatButton;
        private System.Windows.Forms.RichTextBox refDatTextBlock;
        private System.Windows.Forms.RichTextBox analizaIzpisTextBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox izpisAnalizeŠifDat;
        private System.Windows.Forms.RichTextBox izpisŠifDat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button desifriraj;
        private System.Windows.Forms.RichTextBox dešifriranNiz;
        private System.Windows.Forms.TextBox crkaKiJoZamenjujemoTextBlock;
        private System.Windows.Forms.Button Zamenjaj;
        private System.Windows.Forms.TextBox crkaZaZamenjavo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button grafReferencna;
        private System.Windows.Forms.Button grafSifrirna;
        private System.Windows.Forms.Button grafOdkriptirana;
    }
}

