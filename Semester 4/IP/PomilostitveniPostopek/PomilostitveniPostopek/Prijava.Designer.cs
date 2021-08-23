namespace PomilostitveniPostopek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrijava_ime = new System.Windows.Forms.TextBox();
            this.textBoxPrijava_geslo = new System.Windows.Forms.TextBox();
            this.buttonLoggin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(135, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uporabniško ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geslo";
            // 
            // textBoxPrijava_ime
            // 
            this.textBoxPrijava_ime.Location = new System.Drawing.Point(160, 94);
            this.textBoxPrijava_ime.Name = "textBoxPrijava_ime";
            this.textBoxPrijava_ime.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrijava_ime.TabIndex = 3;
            // 
            // textBoxPrijava_geslo
            // 
            this.textBoxPrijava_geslo.Location = new System.Drawing.Point(160, 122);
            this.textBoxPrijava_geslo.Name = "textBoxPrijava_geslo";
            this.textBoxPrijava_geslo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrijava_geslo.TabIndex = 4;
            // 
            // buttonLoggin
            // 
            this.buttonLoggin.Location = new System.Drawing.Point(157, 164);
            this.buttonLoggin.Name = "buttonLoggin";
            this.buttonLoggin.Size = new System.Drawing.Size(75, 23);
            this.buttonLoggin.TabIndex = 5;
            this.buttonLoggin.Text = "Prijava";
            this.buttonLoggin.UseVisualStyleBackColor = true;
            this.buttonLoggin.Click += new System.EventHandler(this.buttonLoggin_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 282);
            this.Controls.Add(this.buttonLoggin);
            this.Controls.Add(this.textBoxPrijava_geslo);
            this.Controls.Add(this.textBoxPrijava_ime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrijava_ime;
        private System.Windows.Forms.TextBox textBoxPrijava_geslo;
        private System.Windows.Forms.Button buttonLoggin;
    }
}