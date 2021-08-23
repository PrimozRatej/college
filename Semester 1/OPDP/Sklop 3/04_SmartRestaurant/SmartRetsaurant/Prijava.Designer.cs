namespace SmartRetsaurant
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ime_textBox = new System.Windows.Forms.TextBox();
            this.Prijava_button = new System.Windows.Forms.Button();
            this.Geslo_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 440);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geslo";
            // 
            // ime_textBox
            // 
            this.ime_textBox.Location = new System.Drawing.Point(126, 381);
            this.ime_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ime_textBox.Name = "ime_textBox";
            this.ime_textBox.Size = new System.Drawing.Size(177, 22);
            this.ime_textBox.TabIndex = 3;
            // 
            // Prijava_button
            // 
            this.Prijava_button.Location = new System.Drawing.Point(126, 502);
            this.Prijava_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prijava_button.Name = "Prijava_button";
            this.Prijava_button.Size = new System.Drawing.Size(179, 60);
            this.Prijava_button.TabIndex = 5;
            this.Prijava_button.Text = "Prijava";
            this.Prijava_button.UseVisualStyleBackColor = true;
            this.Prijava_button.Click += new System.EventHandler(this.Prijava_button_Click);
            // 
            // Geslo_textBox
            // 
            this.Geslo_textBox.Location = new System.Drawing.Point(126, 437);
            this.Geslo_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Geslo_textBox.Name = "Geslo_textBox";
            this.Geslo_textBox.PasswordChar = '*';
            this.Geslo_textBox.Size = new System.Drawing.Size(177, 22);
            this.Geslo_textBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "NAZAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prijava_button);
            this.Controls.Add(this.Geslo_textBox);
            this.Controls.Add(this.ime_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ime_textBox;
        private System.Windows.Forms.Button Prijava_button;
        private System.Windows.Forms.TextBox Geslo_textBox;
        private System.Windows.Forms.Button button1;

    }
}