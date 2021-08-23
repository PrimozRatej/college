namespace AHP
{
    partial class AHPOkno
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
            this.hierarhija = new System.Windows.Forms.TreeView();
            this.dgAlternative = new System.Windows.Forms.DataGridView();
            this.NazivAlternative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShrani = new System.Windows.Forms.Button();
            this.lblDodajanjeAlternativ = new System.Windows.Forms.Label();
            this.kontekstniMeni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstraniParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHierarhija = new System.Windows.Forms.Panel();
            this.lblGrajenje = new System.Windows.Forms.Label();
            this.btnGrid = new System.Windows.Forms.Button();
            this.flowGridi = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVrednotenje = new System.Windows.Forms.Label();
            this.btnNaDisk = new System.Windows.Forms.Button();
            this.btnOvrednoti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlternative)).BeginInit();
            this.kontekstniMeni.SuspendLayout();
            this.panelHierarhija.SuspendLayout();
            this.SuspendLayout();
            // 
            // hierarhija
            // 
            this.hierarhija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarhija.Location = new System.Drawing.Point(0, 0);
            this.hierarhija.Name = "hierarhija";
            this.hierarhija.Size = new System.Drawing.Size(231, 551);
            this.hierarhija.TabIndex = 0;
            // 
            // dgAlternative
            // 
            this.dgAlternative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgAlternative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlternative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivAlternative});
            this.dgAlternative.Location = new System.Drawing.Point(12, 32);
            this.dgAlternative.Name = "dgAlternative";
            this.dgAlternative.Size = new System.Drawing.Size(163, 551);
            this.dgAlternative.TabIndex = 1;
            // 
            // NazivAlternative
            // 
            this.NazivAlternative.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivAlternative.HeaderText = "Naziv alternative";
            this.NazivAlternative.Name = "NazivAlternative";
            // 
            // btnShrani
            // 
            this.btnShrani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShrani.Location = new System.Drawing.Point(12, 589);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(163, 23);
            this.btnShrani.TabIndex = 2;
            this.btnShrani.Text = "Shrani alternative";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // lblDodajanjeAlternativ
            // 
            this.lblDodajanjeAlternativ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDodajanjeAlternativ.AutoSize = true;
            this.lblDodajanjeAlternativ.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajanjeAlternativ.Location = new System.Drawing.Point(12, 9);
            this.lblDodajanjeAlternativ.Name = "lblDodajanjeAlternativ";
            this.lblDodajanjeAlternativ.Size = new System.Drawing.Size(121, 20);
            this.lblDodajanjeAlternativ.TabIndex = 3;
            this.lblDodajanjeAlternativ.Text = "Dodajanje alternativ:";
            // 
            // kontekstniMeni
            // 
            this.kontekstniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajParameterToolStripMenuItem,
            this.odstraniParameterToolStripMenuItem});
            this.kontekstniMeni.Name = "contextMenuStrip1";
            this.kontekstniMeni.ShowImageMargin = false;
            this.kontekstniMeni.Size = new System.Drawing.Size(152, 48);
            // 
            // dodajParameterToolStripMenuItem
            // 
            this.dodajParameterToolStripMenuItem.Name = "dodajParameterToolStripMenuItem";
            this.dodajParameterToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dodajParameterToolStripMenuItem.Text = "Dodaj parameter";
            this.dodajParameterToolStripMenuItem.Click += new System.EventHandler(this.dodajParameterToolStripMenuItem_Click);
            // 
            // odstraniParameterToolStripMenuItem
            // 
            this.odstraniParameterToolStripMenuItem.Name = "odstraniParameterToolStripMenuItem";
            this.odstraniParameterToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.odstraniParameterToolStripMenuItem.Text = "Odstrani parameter";
            this.odstraniParameterToolStripMenuItem.Click += new System.EventHandler(this.odstraniParameterToolStripMenuItem_Click);
            // 
            // panelHierarhija
            // 
            this.panelHierarhija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelHierarhija.ContextMenuStrip = this.kontekstniMeni;
            this.panelHierarhija.Controls.Add(this.hierarhija);
            this.panelHierarhija.Enabled = false;
            this.panelHierarhija.Location = new System.Drawing.Point(181, 32);
            this.panelHierarhija.Name = "panelHierarhija";
            this.panelHierarhija.Size = new System.Drawing.Size(231, 551);
            this.panelHierarhija.TabIndex = 6;
            // 
            // lblGrajenje
            // 
            this.lblGrajenje.AutoSize = true;
            this.lblGrajenje.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrajenje.Location = new System.Drawing.Point(181, 9);
            this.lblGrajenje.Name = "lblGrajenje";
            this.lblGrajenje.Size = new System.Drawing.Size(115, 20);
            this.lblGrajenje.TabIndex = 7;
            this.lblGrajenje.Text = "Grajenje hierarhije:";
            // 
            // btnGrid
            // 
            this.btnGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGrid.Enabled = false;
            this.btnGrid.Location = new System.Drawing.Point(181, 589);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(115, 23);
            this.btnGrid.TabIndex = 8;
            this.btnGrid.Text = "Generiraj tabele";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // flowGridi
            // 
            this.flowGridi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowGridi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowGridi.Location = new System.Drawing.Point(418, 32);
            this.flowGridi.Name = "flowGridi";
            this.flowGridi.Size = new System.Drawing.Size(533, 551);
            this.flowGridi.TabIndex = 9;
            this.flowGridi.WrapContents = false;
            this.flowGridi.SizeChanged += new System.EventHandler(this.flowGridi_SizeChanged);
            // 
            // lblVrednotenje
            // 
            this.lblVrednotenje.AutoSize = true;
            this.lblVrednotenje.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrednotenje.Location = new System.Drawing.Point(414, 9);
            this.lblVrednotenje.Name = "lblVrednotenje";
            this.lblVrednotenje.Size = new System.Drawing.Size(78, 20);
            this.lblVrednotenje.TabIndex = 11;
            this.lblVrednotenje.Text = "Vrednotenje:";
            // 
            // btnNaDisk
            // 
            this.btnNaDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNaDisk.Enabled = false;
            this.btnNaDisk.Location = new System.Drawing.Point(297, 589);
            this.btnNaDisk.Name = "btnNaDisk";
            this.btnNaDisk.Size = new System.Drawing.Size(115, 23);
            this.btnNaDisk.TabIndex = 13;
            this.btnNaDisk.Text = "Shrani na disk";
            this.btnNaDisk.UseVisualStyleBackColor = true;
            this.btnNaDisk.Click += new System.EventHandler(this.btnNaDisk_Click);
            // 
            // btnOvrednoti
            // 
            this.btnOvrednoti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOvrednoti.Enabled = false;
            this.btnOvrednoti.Location = new System.Drawing.Point(418, 589);
            this.btnOvrednoti.Name = "btnOvrednoti";
            this.btnOvrednoti.Size = new System.Drawing.Size(533, 23);
            this.btnOvrednoti.TabIndex = 10;
            this.btnOvrednoti.Text = "Ovrednoti";
            this.btnOvrednoti.UseVisualStyleBackColor = true;
            this.btnOvrednoti.Click += new System.EventHandler(this.btnOvrednoti_Click);
            // 
            // AHPOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 624);
            this.Controls.Add(this.btnOvrednoti);
            this.Controls.Add(this.btnNaDisk);
            this.Controls.Add(this.flowGridi);
            this.Controls.Add(this.lblVrednotenje);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.lblGrajenje);
            this.Controls.Add(this.panelHierarhija);
            this.Controls.Add(this.lblDodajanjeAlternativ);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.dgAlternative);
            this.Name = "AHPOkno";
            this.Text = "AHP metoda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AHPOkno_FormClosing);
            this.Load += new System.EventHandler(this.AHPOkno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlternative)).EndInit();
            this.kontekstniMeni.ResumeLayout(false);
            this.panelHierarhija.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView hierarhija;
        private System.Windows.Forms.DataGridView dgAlternative;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Label lblDodajanjeAlternativ;
        private System.Windows.Forms.ContextMenuStrip kontekstniMeni;
        private System.Windows.Forms.ToolStripMenuItem dodajParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstraniParameterToolStripMenuItem;
        private System.Windows.Forms.Panel panelHierarhija;
        private System.Windows.Forms.Label lblGrajenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivAlternative;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.FlowLayoutPanel flowGridi;
        private System.Windows.Forms.Label lblVrednotenje;
        private System.Windows.Forms.Button btnNaDisk;
        private System.Windows.Forms.Button btnOvrednoti;
    }
}

