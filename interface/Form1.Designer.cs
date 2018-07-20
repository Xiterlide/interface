namespace @interface
{
    partial class Schnittstelle
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schnittstelle));
            this.ikony = new System.Windows.Forms.ImageList(this.components);
            this.Inhalt = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ikony
            // 
            this.ikony.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ikony.ImageStream")));
            this.ikony.TransparentColor = System.Drawing.Color.Transparent;
            this.ikony.Images.SetKeyName(0, "1sNE1eX.jpg");
            this.ikony.Images.SetKeyName(1, "50-reasons-why-nicolas-cage-is-the-greatest-human-1-5571-1389124720-1_big.jpg");
            this.ikony.Images.SetKeyName(2, "61Wo915nuTL._SY463_.jpg");
            this.ikony.Images.SetKeyName(3, "220px-Nicolas_Cage_-_66ème_Festival_de_Venise_(Mostra).jpg");
            // 
            // Inhalt
            // 
            this.Inhalt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inhalt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Inhalt.Location = new System.Drawing.Point(0, 0);
            this.Inhalt.Name = "Inhalt";
            this.Inhalt.Size = new System.Drawing.Size(900, 600);
            this.Inhalt.TabIndex = 0;
            this.Inhalt.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Schnittstelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.Inhalt);
            this.Name = "Schnittstelle";
            this.Text = "Rozhraní";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ikony;
        private System.Windows.Forms.Panel Inhalt;
    }
}

