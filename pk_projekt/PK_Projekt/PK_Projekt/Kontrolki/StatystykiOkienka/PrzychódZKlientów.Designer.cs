namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    partial class PrzychódZKlientów
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zklienta = new System.Windows.Forms.ListView();
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sumatransakcji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Zklienta
            // 
            this.Zklienta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imie,
            this.Nazwisko,
            this.Sumatransakcji});
            this.Zklienta.GridLines = true;
            this.Zklienta.Location = new System.Drawing.Point(7, 39);
            this.Zklienta.MultiSelect = false;
            this.Zklienta.Name = "Zklienta";
            this.Zklienta.Size = new System.Drawing.Size(646, 343);
            this.Zklienta.TabIndex = 15;
            this.Zklienta.UseCompatibleStateImageBehavior = false;
            this.Zklienta.View = System.Windows.Forms.View.Details;
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 168;
            // 
            // Sumatransakcji
            // 
            this.Sumatransakcji.Text = "Suma transakcji";
            this.Sumatransakcji.Width = 412;
            // 
            // PrzychódZKlientów
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Zklienta);
            this.Name = "PrzychódZKlientów";
            this.Size = new System.Drawing.Size(660, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Zklienta;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Sumatransakcji;
    }
}
