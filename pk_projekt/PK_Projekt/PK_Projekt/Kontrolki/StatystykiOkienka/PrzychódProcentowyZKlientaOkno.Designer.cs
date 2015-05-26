namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    partial class PrzychódProcentowyZKlientaOkno
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
            this.ProcentoweLista = new System.Windows.Forms.ListView();
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Procent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zobacz = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.Label();
            this.Od = new System.Windows.Forms.Label();
            this.DataDo = new System.Windows.Forms.DateTimePicker();
            this.DataOd = new System.Windows.Forms.DateTimePicker();
            this.IDKlienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ProcentoweLista
            // 
            this.ProcentoweLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDKlienta,
            this.Imie,
            this.Nazwisko,
            this.Procent});
            this.ProcentoweLista.GridLines = true;
            this.ProcentoweLista.Location = new System.Drawing.Point(7, 39);
            this.ProcentoweLista.MultiSelect = false;
            this.ProcentoweLista.Name = "ProcentoweLista";
            this.ProcentoweLista.Size = new System.Drawing.Size(646, 343);
            this.ProcentoweLista.TabIndex = 16;
            this.ProcentoweLista.UseCompatibleStateImageBehavior = false;
            this.ProcentoweLista.View = System.Windows.Forms.View.Details;
            // 
            // Imie
            // 
            this.Imie.Text = "Imie/Nazwa Firmy";
            this.Imie.Width = 110;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 199;
            // 
            // Procent
            // 
            this.Procent.Text = "Przychód procentowo";
            this.Procent.Width = 273;
            // 
            // Zobacz
            // 
            this.Zobacz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zobacz.Location = new System.Drawing.Point(423, 10);
            this.Zobacz.Name = "Zobacz";
            this.Zobacz.Size = new System.Drawing.Size(124, 23);
            this.Zobacz.TabIndex = 56;
            this.Zobacz.Text = "Zobacz";
            this.Zobacz.UseVisualStyleBackColor = true;
            this.Zobacz.Click += new System.EventHandler(this.Zobacz_Click);
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(243, 15);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(27, 13);
            this.Do.TabIndex = 55;
            this.Do.Text = "Do :";
            // 
            // Od
            // 
            this.Od.AutoSize = true;
            this.Od.Location = new System.Drawing.Point(81, 15);
            this.Od.Name = "Od";
            this.Od.Size = new System.Drawing.Size(27, 13);
            this.Od.TabIndex = 54;
            this.Od.Text = "Od :";
            // 
            // DataDo
            // 
            this.DataDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDo.Location = new System.Drawing.Point(276, 13);
            this.DataDo.Name = "DataDo";
            this.DataDo.Size = new System.Drawing.Size(98, 20);
            this.DataDo.TabIndex = 53;
            // 
            // DataOd
            // 
            this.DataOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataOd.Location = new System.Drawing.Point(114, 13);
            this.DataOd.Name = "DataOd";
            this.DataOd.Size = new System.Drawing.Size(98, 20);
            this.DataOd.TabIndex = 52;
            // 
            // IDKlienta
            // 
            this.IDKlienta.Text = "Id Klienta";
            // 
            // PrzychódProcentowyZKlientaOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Zobacz);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.Od);
            this.Controls.Add(this.DataDo);
            this.Controls.Add(this.DataOd);
            this.Controls.Add(this.ProcentoweLista);
            this.Name = "PrzychódProcentowyZKlientaOkno";
            this.Size = new System.Drawing.Size(660, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProcentoweLista;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Procent;
        private System.Windows.Forms.ColumnHeader IDKlienta;
        private System.Windows.Forms.Button Zobacz;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.Label Od;
        private System.Windows.Forms.DateTimePicker DataDo;
        private System.Windows.Forms.DateTimePicker DataOd;
    }
}
