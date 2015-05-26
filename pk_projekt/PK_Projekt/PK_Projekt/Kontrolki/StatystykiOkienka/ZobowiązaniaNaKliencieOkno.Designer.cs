namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    partial class ZobowiązaniaNaKliencieOkno
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
            this.ZobowiązaniaList = new System.Windows.Forms.ListView();
            this.IdKlienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imię = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usługa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wartość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTransakcji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboKlienci = new System.Windows.Forms.ComboBox();
            this.DataOd = new System.Windows.Forms.DateTimePicker();
            this.DataDo = new System.Windows.Forms.DateTimePicker();
            this.Od = new System.Windows.Forms.Label();
            this.Do = new System.Windows.Forms.Label();
            this.Zobacz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZobowiązaniaList
            // 
            this.ZobowiązaniaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdKlienta,
            this.Imię,
            this.Nazwisko,
            this.Email,
            this.telefon,
            this.Usługa,
            this.Wartość,
            this.DataTransakcji});
            this.ZobowiązaniaList.GridLines = true;
            this.ZobowiązaniaList.Location = new System.Drawing.Point(3, 89);
            this.ZobowiązaniaList.MultiSelect = false;
            this.ZobowiązaniaList.Name = "ZobowiązaniaList";
            this.ZobowiązaniaList.Size = new System.Drawing.Size(646, 343);
            this.ZobowiązaniaList.TabIndex = 16;
            this.ZobowiązaniaList.UseCompatibleStateImageBehavior = false;
            this.ZobowiązaniaList.View = System.Windows.Forms.View.Details;
            // 
            // IdKlienta
            // 
            this.IdKlienta.Text = "Id Klienta";
            // 
            // Imię
            // 
            this.Imię.Text = "Imię/Nazwa Firmy";
            this.Imię.Width = 109;
            // 
            // Email
            // 
            this.Email.DisplayIndex = 2;
            this.Email.Text = "Email";
            // 
            // Nazwisko
            // 
            this.Nazwisko.DisplayIndex = 3;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            // 
            // Usługa
            // 
            this.Usługa.Text = "Usługa";
            // 
            // Wartość
            // 
            this.Wartość.Text = "Wartość";
            // 
            // DataTransakcji
            // 
            this.DataTransakcji.Text = "Data Transakcji";
            this.DataTransakcji.Width = 171;
            // 
            // ComboKlienci
            // 
            this.ComboKlienci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboKlienci.FormattingEnabled = true;
            this.ComboKlienci.Location = new System.Drawing.Point(12, 15);
            this.ComboKlienci.Name = "ComboKlienci";
            this.ComboKlienci.Size = new System.Drawing.Size(270, 21);
            this.ComboKlienci.TabIndex = 17;
            // 
            // DataOd
            // 
            this.DataOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataOd.Location = new System.Drawing.Point(356, 16);
            this.DataOd.Name = "DataOd";
            this.DataOd.Size = new System.Drawing.Size(98, 20);
            this.DataOd.TabIndex = 42;
            // 
            // DataDo
            // 
            this.DataDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDo.Location = new System.Drawing.Point(518, 16);
            this.DataDo.Name = "DataDo";
            this.DataDo.Size = new System.Drawing.Size(98, 20);
            this.DataDo.TabIndex = 43;
            // 
            // Od
            // 
            this.Od.AutoSize = true;
            this.Od.Location = new System.Drawing.Point(323, 18);
            this.Od.Name = "Od";
            this.Od.Size = new System.Drawing.Size(27, 13);
            this.Od.TabIndex = 44;
            this.Od.Text = "Od :";
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(485, 18);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(27, 13);
            this.Do.TabIndex = 45;
            this.Do.Text = "Do :";
            // 
            // Zobacz
            // 
            this.Zobacz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zobacz.Location = new System.Drawing.Point(257, 42);
            this.Zobacz.Name = "Zobacz";
            this.Zobacz.Size = new System.Drawing.Size(124, 23);
            this.Zobacz.TabIndex = 46;
            this.Zobacz.Text = "Zobacz";
            this.Zobacz.UseVisualStyleBackColor = true;
            this.Zobacz.Click += new System.EventHandler(this.Zobacz_Click);
            // 
            // ZobowiązaniaNaKliencieOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Zobacz);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.Od);
            this.Controls.Add(this.DataDo);
            this.Controls.Add(this.DataOd);
            this.Controls.Add(this.ComboKlienci);
            this.Controls.Add(this.ZobowiązaniaList);
            this.Name = "ZobowiązaniaNaKliencieOkno";
            this.Size = new System.Drawing.Size(660, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ZobowiązaniaList;
        private System.Windows.Forms.ColumnHeader IdKlienta;
        private System.Windows.Forms.ColumnHeader Imię;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader Usługa;
        private System.Windows.Forms.ColumnHeader Wartość;
        private System.Windows.Forms.ColumnHeader DataTransakcji;
        private System.Windows.Forms.ComboBox ComboKlienci;
        private System.Windows.Forms.DateTimePicker DataOd;
        private System.Windows.Forms.DateTimePicker DataDo;
        private System.Windows.Forms.Label Od;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.Button Zobacz;
    }
}
