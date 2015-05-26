namespace PK_Projekt.Kontrolki
{
    partial class WyświetlanieOkno
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
            this.ListaTransakcji = new System.Windows.Forms.ListView();
            this.IDTransakcji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Klient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usługa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTransakcji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormaPłatności = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wartość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odroczenie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaKlientów = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imię = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pesel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mieszkanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WyświetlButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaTransakcji
            // 
            this.ListaTransakcji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDTransakcji,
            this.Klient,
            this.Usługa,
            this.DataTransakcji,
            this.FormaPłatności,
            this.Wartość,
            this.Odroczenie});
            this.ListaTransakcji.GridLines = true;
            this.ListaTransakcji.HideSelection = false;
            this.ListaTransakcji.Location = new System.Drawing.Point(28, 330);
            this.ListaTransakcji.MultiSelect = false;
            this.ListaTransakcji.Name = "ListaTransakcji";
            this.ListaTransakcji.Size = new System.Drawing.Size(635, 205);
            this.ListaTransakcji.TabIndex = 31;
            this.ListaTransakcji.UseCompatibleStateImageBehavior = false;
            this.ListaTransakcji.View = System.Windows.Forms.View.Details;
            // 
            // IDTransakcji
            // 
            this.IDTransakcji.Text = "ID";
            // 
            // Klient
            // 
            this.Klient.Text = "Klient";
            this.Klient.Width = 59;
            // 
            // Usługa
            // 
            this.Usługa.Text = "Usługa";
            this.Usługa.Width = 66;
            // 
            // DataTransakcji
            // 
            this.DataTransakcji.Text = "DataTransakcji";
            this.DataTransakcji.Width = 113;
            // 
            // FormaPłatności
            // 
            this.FormaPłatności.Text = "FormaPłatności";
            this.FormaPłatności.Width = 121;
            // 
            // Wartość
            // 
            this.Wartość.Text = "Wartość";
            this.Wartość.Width = 122;
            // 
            // Odroczenie
            // 
            this.Odroczenie.Text = "Zapłacone";
            this.Odroczenie.Width = 103;
            // 
            // ListaKlientów
            // 
            this.ListaKlientów.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Imię,
            this.Nazwisko,
            this.Pesel,
            this.NIP,
            this.Kod,
            this.Miasto,
            this.Ulica,
            this.Dom,
            this.Mieszkanie,
            this.Email,
            this.Telefon});
            this.ListaKlientów.GridLines = true;
            this.ListaKlientów.HideSelection = false;
            this.ListaKlientów.Location = new System.Drawing.Point(28, 61);
            this.ListaKlientów.MultiSelect = false;
            this.ListaKlientów.Name = "ListaKlientów";
            this.ListaKlientów.Size = new System.Drawing.Size(635, 192);
            this.ListaKlientów.TabIndex = 30;
            this.ListaKlientów.UseCompatibleStateImageBehavior = false;
            this.ListaKlientów.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 27;
            // 
            // Imię
            // 
            this.Imię.Text = "Imię/Nazwa firmy";
            this.Imię.Width = 97;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            // 
            // Pesel
            // 
            this.Pesel.Text = "Pesel";
            this.Pesel.Width = 44;
            // 
            // NIP
            // 
            this.NIP.Text = "NIP";
            this.NIP.Width = 57;
            // 
            // Kod
            // 
            this.Kod.Text = "Kod pocztowy";
            this.Kod.Width = 86;
            // 
            // Miasto
            // 
            this.Miasto.Text = "Miasto";
            this.Miasto.Width = 47;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.Width = 45;
            // 
            // Dom
            // 
            this.Dom.Text = "Numer domu";
            this.Dom.Width = 76;
            // 
            // Mieszkanie
            // 
            this.Mieszkanie.Text = "Numer mieszkania";
            this.Mieszkanie.Width = 108;
            // 
            // Email
            // 
            this.Email.Text = "Adres email";
            this.Email.Width = 73;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 52;
            // 
            // WyświetlButton
            // 
            this.WyświetlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WyświetlButton.Location = new System.Drawing.Point(257, 271);
            this.WyświetlButton.Name = "WyświetlButton";
            this.WyświetlButton.Size = new System.Drawing.Size(140, 40);
            this.WyświetlButton.TabIndex = 29;
            this.WyświetlButton.Text = "Wyświetl dane";
            this.WyświetlButton.UseVisualStyleBackColor = true;
            this.WyświetlButton.Click += new System.EventHandler(this.WyświetlButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Historia ostatnich transakcji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Klienci:";
            // 
            // WyświetlanieOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListaTransakcji);
            this.Controls.Add(this.ListaKlientów);
            this.Controls.Add(this.WyświetlButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WyświetlanieOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaTransakcji;
        private System.Windows.Forms.ListView ListaKlientów;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Imię;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Pesel;
        private System.Windows.Forms.ColumnHeader NIP;
        private System.Windows.Forms.ColumnHeader Kod;
        private System.Windows.Forms.ColumnHeader Miasto;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Dom;
        private System.Windows.Forms.ColumnHeader Mieszkanie;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.Button WyświetlButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Klient;
        private System.Windows.Forms.ColumnHeader Usługa;
        private System.Windows.Forms.ColumnHeader DataTransakcji;
        private System.Windows.Forms.ColumnHeader FormaPłatności;
        private System.Windows.Forms.ColumnHeader Wartość;
        private System.Windows.Forms.ColumnHeader IDTransakcji;
        private System.Windows.Forms.ColumnHeader Odroczenie;
    }
}
