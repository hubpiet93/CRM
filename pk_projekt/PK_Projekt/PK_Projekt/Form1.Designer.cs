namespace PK_Projekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.edytujKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTransakcjęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uregulujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyślijMailaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlDaneKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaTransakcjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaUsługaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KomentarzDodaj = new System.Windows.Forms.TextBox();
            this.KomentarzWyswietl = new System.Windows.Forms.TextBox();
            this.DodajKomentarz = new System.Windows.Forms.Button();
            this.WyświetlDaneButton = new System.Windows.Forms.Button();
            this.DodajKlientaButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujKlientaToolStripMenuItem,
            this.dodajTransakcjęToolStripMenuItem,
            this.wyślijMailaToolStripMenuItem,
            this.wyświetlDaneKlientaToolStripMenuItem,
            this.statystykiToolStripMenuItem,
            this.historiaTransakcjiToolStripMenuItem,
            this.nowaUsługaToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // edytujKlientaToolStripMenuItem
            // 
            this.edytujKlientaToolStripMenuItem.Name = "edytujKlientaToolStripMenuItem";
            this.edytujKlientaToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.edytujKlientaToolStripMenuItem.Text = "Edytuj klienta";
            this.edytujKlientaToolStripMenuItem.Click += new System.EventHandler(this.edytujKlientaToolStripMenuItem_Click);
            // 
            // dodajTransakcjęToolStripMenuItem
            // 
            this.dodajTransakcjęToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uregulujToolStripMenuItem});
            this.dodajTransakcjęToolStripMenuItem.Name = "dodajTransakcjęToolStripMenuItem";
            this.dodajTransakcjęToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.dodajTransakcjęToolStripMenuItem.Text = "Dodaj transakcję";
            this.dodajTransakcjęToolStripMenuItem.Click += new System.EventHandler(this.dodajTransakcjęToolStripMenuItem_Click);
            // 
            // uregulujToolStripMenuItem
            // 
            this.uregulujToolStripMenuItem.Name = "uregulujToolStripMenuItem";
            this.uregulujToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.uregulujToolStripMenuItem.Text = "Ureguluj";
            this.uregulujToolStripMenuItem.Click += new System.EventHandler(this.uregulujToolStripMenuItem_Click);
            // 
            // wyślijMailaToolStripMenuItem
            // 
            this.wyślijMailaToolStripMenuItem.Name = "wyślijMailaToolStripMenuItem";
            this.wyślijMailaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.wyślijMailaToolStripMenuItem.Text = "Wyślij maila";
            this.wyślijMailaToolStripMenuItem.Click += new System.EventHandler(this.wyślijMailaToolStripMenuItem_Click);
            // 
            // wyświetlDaneKlientaToolStripMenuItem
            // 
            this.wyświetlDaneKlientaToolStripMenuItem.Name = "wyświetlDaneKlientaToolStripMenuItem";
            this.wyświetlDaneKlientaToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.wyświetlDaneKlientaToolStripMenuItem.Text = "Wyświetl dane klienta";
            this.wyświetlDaneKlientaToolStripMenuItem.Click += new System.EventHandler(this.wyświetlDaneKlientaToolStripMenuItem_Click);
            // 
            // statystykiToolStripMenuItem
            // 
            this.statystykiToolStripMenuItem.Name = "statystykiToolStripMenuItem";
            this.statystykiToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.statystykiToolStripMenuItem.Text = "Statystyki";
            this.statystykiToolStripMenuItem.Click += new System.EventHandler(this.statystykiToolStripMenuItem_Click);
            // 
            // historiaTransakcjiToolStripMenuItem
            // 
            this.historiaTransakcjiToolStripMenuItem.Name = "historiaTransakcjiToolStripMenuItem";
            this.historiaTransakcjiToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.historiaTransakcjiToolStripMenuItem.Text = "Historia transakcji";
            this.historiaTransakcjiToolStripMenuItem.Click += new System.EventHandler(this.historiaTransakcjiToolStripMenuItem_Click);
            // 
            // nowaUsługaToolStripMenuItem
            // 
            this.nowaUsługaToolStripMenuItem.Name = "nowaUsługaToolStripMenuItem";
            this.nowaUsługaToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.nowaUsługaToolStripMenuItem.Text = "Nowa usługa";
            this.nowaUsługaToolStripMenuItem.Click += new System.EventHandler(this.nowaUsługaToolStripMenuItem_Click);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // KomentarzDodaj
            // 
            this.KomentarzDodaj.Location = new System.Drawing.Point(14, 438);
            this.KomentarzDodaj.Multiline = true;
            this.KomentarzDodaj.Name = "KomentarzDodaj";
            this.KomentarzDodaj.Size = new System.Drawing.Size(187, 151);
            this.KomentarzDodaj.TabIndex = 17;
            // 
            // KomentarzWyswietl
            // 
            this.KomentarzWyswietl.Location = new System.Drawing.Point(14, 285);
            this.KomentarzWyswietl.Multiline = true;
            this.KomentarzWyswietl.Name = "KomentarzWyswietl";
            this.KomentarzWyswietl.ReadOnly = true;
            this.KomentarzWyswietl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KomentarzWyswietl.Size = new System.Drawing.Size(187, 134);
            this.KomentarzWyswietl.TabIndex = 16;
            // 
            // DodajKomentarz
            // 
            this.DodajKomentarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajKomentarz.Location = new System.Drawing.Point(14, 606);
            this.DodajKomentarz.Name = "DodajKomentarz";
            this.DodajKomentarz.Size = new System.Drawing.Size(187, 31);
            this.DodajKomentarz.TabIndex = 15;
            this.DodajKomentarz.Text = "Dodaj komentarz";
            this.DodajKomentarz.UseVisualStyleBackColor = true;
            this.DodajKomentarz.Click += new System.EventHandler(this.DodajKomentarz_Click);
            // 
            // WyświetlDaneButton
            // 
            this.WyświetlDaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WyświetlDaneButton.Location = new System.Drawing.Point(14, 248);
            this.WyświetlDaneButton.Name = "WyświetlDaneButton";
            this.WyświetlDaneButton.Size = new System.Drawing.Size(187, 31);
            this.WyświetlDaneButton.TabIndex = 14;
            this.WyświetlDaneButton.Text = "Wyświetl dane";
            this.WyświetlDaneButton.UseVisualStyleBackColor = true;
            this.WyświetlDaneButton.Click += new System.EventHandler(this.WyświetlDaneButton_Click);
            // 
            // DodajKlientaButton
            // 
            this.DodajKlientaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajKlientaButton.Location = new System.Drawing.Point(14, 211);
            this.DodajKlientaButton.Name = "DodajKlientaButton";
            this.DodajKlientaButton.Size = new System.Drawing.Size(187, 31);
            this.DodajKlientaButton.TabIndex = 13;
            this.DodajKlientaButton.Text = "Dodaj klienta";
            this.DodajKlientaButton.UseVisualStyleBackColor = true;
            this.DodajKlientaButton.Click += new System.EventHandler(this.DodajKlientaButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(31, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(207, 37);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(715, 600);
            this.GroupBox.TabIndex = 18;
            this.GroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 662);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.KomentarzDodaj);
            this.Controls.Add(this.KomentarzWyswietl);
            this.Controls.Add(this.DodajKomentarz);
            this.Controls.Add(this.WyświetlDaneButton);
            this.Controls.Add(this.DodajKlientaButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System zarządzania klietami";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edytujKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTransakcjęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyślijMailaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyświetlDaneKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaTransakcjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaUsługaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.TextBox KomentarzDodaj;
        private System.Windows.Forms.TextBox KomentarzWyswietl;
        private System.Windows.Forms.Button DodajKomentarz;
        private System.Windows.Forms.Button WyświetlDaneButton;
        private System.Windows.Forms.Button DodajKlientaButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ToolStripMenuItem uregulujToolStripMenuItem;
    }
}

