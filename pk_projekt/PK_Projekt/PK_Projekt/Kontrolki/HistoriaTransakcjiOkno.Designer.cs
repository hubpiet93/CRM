namespace PK_Projekt.Kontrolki
{
    partial class HistoriaTransakcjiOkno
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
            this.ComboKlienci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.ZobaczHistorięTransakcji = new System.Windows.Forms.Button();
            this.HistoriaTransakcji = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usługa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTransakcji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormaPłatności = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wartość = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odroczenie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ComboKlienci
            // 
            this.ComboKlienci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboKlienci.FormattingEnabled = true;
            this.ComboKlienci.Location = new System.Drawing.Point(164, 151);
            this.ComboKlienci.Name = "ComboKlienci";
            this.ComboKlienci.Size = new System.Drawing.Size(266, 21);
            this.ComboKlienci.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wybierz klienta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Historia transakcji";
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(6, 5);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 9;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // ZobaczHistorięTransakcji
            // 
            this.ZobaczHistorięTransakcji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZobaczHistorięTransakcji.Location = new System.Drawing.Point(454, 147);
            this.ZobaczHistorięTransakcji.Name = "ZobaczHistorięTransakcji";
            this.ZobaczHistorięTransakcji.Size = new System.Drawing.Size(136, 25);
            this.ZobaczHistorięTransakcji.TabIndex = 14;
            this.ZobaczHistorięTransakcji.Text = "Zobacz historię";
            this.ZobaczHistorięTransakcji.UseVisualStyleBackColor = true;
            this.ZobaczHistorięTransakcji.Click += new System.EventHandler(this.ZobaczHistorięTransakcji_Click);
            // 
            // HistoriaTransakcji
            // 
            this.HistoriaTransakcji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Usługa,
            this.DataTransakcji,
            this.FormaPłatności,
            this.Wartość,
            this.Odroczenie});
            this.HistoriaTransakcji.GridLines = true;
            this.HistoriaTransakcji.HideSelection = false;
            this.HistoriaTransakcji.Location = new System.Drawing.Point(55, 178);
            this.HistoriaTransakcji.MultiSelect = false;
            this.HistoriaTransakcji.Name = "HistoriaTransakcji";
            this.HistoriaTransakcji.Size = new System.Drawing.Size(568, 364);
            this.HistoriaTransakcji.TabIndex = 15;
            this.HistoriaTransakcji.UseCompatibleStateImageBehavior = false;
            this.HistoriaTransakcji.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 36;
            // 
            // Usługa
            // 
            this.Usługa.Text = "Usługa";
            // 
            // DataTransakcji
            // 
            this.DataTransakcji.Text = "Data transakcji";
            this.DataTransakcji.Width = 93;
            // 
            // FormaPłatności
            // 
            this.FormaPłatności.Text = "Forma płatności";
            this.FormaPłatności.Width = 141;
            // 
            // Wartość
            // 
            this.Wartość.Text = "Wartość";
            this.Wartość.Width = 102;
            // 
            // Odroczenie
            // 
            this.Odroczenie.Text = "Zapłacone";
            this.Odroczenie.Width = 132;
            // 
            // HistoriaTransakcjiOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HistoriaTransakcji);
            this.Controls.Add(this.ZobaczHistorięTransakcji);
            this.Controls.Add(this.ComboKlienci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CofnijButton);
            this.Name = "HistoriaTransakcjiOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboKlienci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.Button ZobaczHistorięTransakcji;
        private System.Windows.Forms.ListView HistoriaTransakcji;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Usługa;
        private System.Windows.Forms.ColumnHeader DataTransakcji;
        private System.Windows.Forms.ColumnHeader FormaPłatności;
        private System.Windows.Forms.ColumnHeader Wartość;
        private System.Windows.Forms.ColumnHeader Odroczenie;
    }
}
