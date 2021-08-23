namespace SmartRetsaurant
{
    partial class Zemljevid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zemljevid));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SmartRestaurant_link = new System.Windows.Forms.LinkLabel();
            this.nazaj_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 366);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restavracije v vaši bližini";
            // 
            // SmartRestaurant_link
            // 
            this.SmartRestaurant_link.AutoSize = true;
            this.SmartRestaurant_link.BackColor = System.Drawing.Color.Transparent;
            this.SmartRestaurant_link.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.SmartRestaurant_link.Location = new System.Drawing.Point(201, 173);
            this.SmartRestaurant_link.Name = "SmartRestaurant_link";
            this.SmartRestaurant_link.Size = new System.Drawing.Size(115, 17);
            this.SmartRestaurant_link.TabIndex = 2;
            this.SmartRestaurant_link.TabStop = true;
            this.SmartRestaurant_link.Text = "SmartRestaurant";
            this.SmartRestaurant_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SmartRestaurant_link_LinkClicked);
            // 
            // nazaj_button
            // 
            this.nazaj_button.Location = new System.Drawing.Point(12, 12);
            this.nazaj_button.Name = "nazaj_button";
            this.nazaj_button.Size = new System.Drawing.Size(171, 55);
            this.nazaj_button.TabIndex = 3;
            this.nazaj_button.Text = "NAZAJ";
            this.nazaj_button.UseVisualStyleBackColor = true;
            this.nazaj_button.Click += new System.EventHandler(this.nazaj_button_Click);
            // 
            // Zemljevid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 742);
            this.Controls.Add(this.nazaj_button);
            this.Controls.Add(this.SmartRestaurant_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Zemljevid";
            this.Text = "Zemljevid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel SmartRestaurant_link;
        private System.Windows.Forms.Button nazaj_button;
    }
}