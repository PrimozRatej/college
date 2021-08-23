namespace SmartRetsaurant
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restavracije_button = new System.Windows.Forms.Button();
            this.Prijava_button = new System.Windows.Forms.Button();
            this.Zemljevid_button = new System.Windows.Forms.Button();
            this.Registracija1_button = new System.Windows.Forms.Button();
            this.Nastavitve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ime_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Restavracije_button
            // 
            this.Restavracije_button.Location = new System.Drawing.Point(155, 251);
            this.Restavracije_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Restavracije_button.Name = "Restavracije_button";
            this.Restavracije_button.Size = new System.Drawing.Size(196, 60);
            this.Restavracije_button.TabIndex = 1;
            this.Restavracije_button.Text = "Restavracije";
            this.Restavracije_button.UseVisualStyleBackColor = true;
            this.Restavracije_button.Click += new System.EventHandler(this.Restavracije_button_Click_1);
            // 
            // Prijava_button
            // 
            this.Prijava_button.Location = new System.Drawing.Point(47, 251);
            this.Prijava_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prijava_button.Name = "Prijava_button";
            this.Prijava_button.Size = new System.Drawing.Size(100, 60);
            this.Prijava_button.TabIndex = 2;
            this.Prijava_button.Text = "Prijava";
            this.Prijava_button.UseVisualStyleBackColor = true;
            this.Prijava_button.Click += new System.EventHandler(this.Prijava_button_Click);
            // 
            // Zemljevid_button
            // 
            this.Zemljevid_button.Location = new System.Drawing.Point(47, 319);
            this.Zemljevid_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zemljevid_button.Name = "Zemljevid_button";
            this.Zemljevid_button.Size = new System.Drawing.Size(100, 60);
            this.Zemljevid_button.TabIndex = 3;
            this.Zemljevid_button.Text = "Zemljevid";
            this.Zemljevid_button.UseVisualStyleBackColor = true;
            this.Zemljevid_button.Click += new System.EventHandler(this.Zemljevid_button_Click);
            // 
            // Registracija1_button
            // 
            this.Registracija1_button.Location = new System.Drawing.Point(368, 697);
            this.Registracija1_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registracija1_button.Name = "Registracija1_button";
            this.Registracija1_button.Size = new System.Drawing.Size(131, 31);
            this.Registracija1_button.TabIndex = 4;
            this.Registracija1_button.Text = "Registracija";
            this.Registracija1_button.UseVisualStyleBackColor = true;
            this.Registracija1_button.Click += new System.EventHandler(this.Restavracije_button_Click);
            // 
            // Nastavitve
            // 
            this.Nastavitve.Location = new System.Drawing.Point(155, 319);
            this.Nastavitve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nastavitve.Name = "Nastavitve";
            this.Nastavitve.Size = new System.Drawing.Size(196, 60);
            this.Nastavitve.TabIndex = 5;
            this.Nastavitve.Text = "Nastavitve";
            this.Nastavitve.UseVisualStyleBackColor = true;
            this.Nastavitve.Click += new System.EventHandler(this.Nastavitve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 697);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prijavljeni ste kot: ";
            // 
            // ime_label
            // 
            this.ime_label.AutoSize = true;
            this.ime_label.Location = new System.Drawing.Point(165, 697);
            this.ime_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ime_label.Name = "ime_label";
            this.ime_label.Size = new System.Drawing.Size(0, 17);
            this.ime_label.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Odjava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ime_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nastavitve);
            this.Controls.Add(this.Registracija1_button);
            this.Controls.Add(this.Zemljevid_button);
            this.Controls.Add(this.Prijava_button);
            this.Controls.Add(this.Restavracije_button);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Restavracije_button;
        private System.Windows.Forms.Button Prijava_button;
        private System.Windows.Forms.Button Zemljevid_button;
        private System.Windows.Forms.Button Registracija1_button;
        private System.Windows.Forms.Button Nastavitve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ime_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

