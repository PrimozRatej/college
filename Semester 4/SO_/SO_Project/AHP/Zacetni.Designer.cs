namespace AHP
{
    partial class Zacetni
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
            this.btnUsdtvari = new System.Windows.Forms.Button();
            this.btnIzDiska = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsdtvari
            // 
            this.btnUsdtvari.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsdtvari.Location = new System.Drawing.Point(13, 13);
            this.btnUsdtvari.Name = "btnUsdtvari";
            this.btnUsdtvari.Size = new System.Drawing.Size(316, 112);
            this.btnUsdtvari.TabIndex = 0;
            this.btnUsdtvari.Text = "Ustvari model";
            this.btnUsdtvari.UseVisualStyleBackColor = true;
            this.btnUsdtvari.Click += new System.EventHandler(this.btnUsdtvari_Click);
            // 
            // btnIzDiska
            // 
            this.btnIzDiska.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzDiska.Location = new System.Drawing.Point(12, 131);
            this.btnIzDiska.Name = "btnIzDiska";
            this.btnIzDiska.Size = new System.Drawing.Size(316, 122);
            this.btnIzDiska.TabIndex = 1;
            this.btnIzDiska.Text = "Naloži model";
            this.btnIzDiska.UseVisualStyleBackColor = true;
            this.btnIzDiska.Click += new System.EventHandler(this.btnIzDiska_Click);
            // 
            // Zacetni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.btnIzDiska);
            this.Controls.Add(this.btnUsdtvari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zacetni";
            this.Text = "AHP metoda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsdtvari;
        private System.Windows.Forms.Button btnIzDiska;
    }
}