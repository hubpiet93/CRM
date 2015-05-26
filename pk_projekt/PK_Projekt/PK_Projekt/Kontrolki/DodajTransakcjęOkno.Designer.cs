namespace PK_Projekt.Kontrolki
{
    partial class DodajTransakcjęOkno
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
            this.DodajTransakcję = new System.Windows.Forms.Button();
            this.DataTransakcji = new System.Windows.Forms.DateTimePicker();
            this.pln = new System.Windows.Forms.Label();
            this.KosztNumeric = new System.Windows.Forms.NumericUpDown();
            this.FormaPłatnościCombo = new System.Windows.Forms.ComboBox();
            this.UsługaCombo = new System.Windows.Forms.ComboBox();
            this.ComboKlienci = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.OdroczenieBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.KosztNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajTransakcję
            // 
            this.DodajTransakcję.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajTransakcję.Location = new System.Drawing.Point(282, 361);
            this.DodajTransakcję.Name = "DodajTransakcję";
            this.DodajTransakcję.Size = new System.Drawing.Size(111, 40);
            this.DodajTransakcję.TabIndex = 42;
            this.DodajTransakcję.Text = "Dodaj transakcję";
            this.DodajTransakcję.UseVisualStyleBackColor = true;
            this.DodajTransakcję.Click += new System.EventHandler(this.DodajTransakcję_Click);
            // 
            // DataTransakcji
            // 
            this.DataTransakcji.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataTransakcji.Location = new System.Drawing.Point(282, 284);
            this.DataTransakcji.Name = "DataTransakcji";
            this.DataTransakcji.Size = new System.Drawing.Size(200, 20);
            this.DataTransakcji.TabIndex = 41;
            // 
            // pln
            // 
            this.pln.AutoSize = true;
            this.pln.Location = new System.Drawing.Point(488, 249);
            this.pln.Name = "pln";
            this.pln.Size = new System.Drawing.Size(21, 13);
            this.pln.TabIndex = 40;
            this.pln.Text = "pln";
            // 
            // KosztNumeric
            // 
            this.KosztNumeric.Location = new System.Drawing.Point(282, 244);
            this.KosztNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.KosztNumeric.Name = "KosztNumeric";
            this.KosztNumeric.Size = new System.Drawing.Size(200, 20);
            this.KosztNumeric.TabIndex = 39;
            // 
            // FormaPłatnościCombo
            // 
            this.FormaPłatnościCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPłatnościCombo.FormattingEnabled = true;
            this.FormaPłatnościCombo.Location = new System.Drawing.Point(282, 323);
            this.FormaPłatnościCombo.Name = "FormaPłatnościCombo";
            this.FormaPłatnościCombo.Size = new System.Drawing.Size(200, 21);
            this.FormaPłatnościCombo.TabIndex = 38;
            // 
            // UsługaCombo
            // 
            this.UsługaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsługaCombo.Location = new System.Drawing.Point(282, 206);
            this.UsługaCombo.Name = "UsługaCombo";
            this.UsługaCombo.Size = new System.Drawing.Size(200, 21);
            this.UsługaCombo.TabIndex = 37;
            // 
            // ComboKlienci
            // 
            this.ComboKlienci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboKlienci.FormattingEnabled = true;
            this.ComboKlienci.Location = new System.Drawing.Point(282, 172);
            this.ComboKlienci.Name = "ComboKlienci";
            this.ComboKlienci.Size = new System.Drawing.Size(200, 21);
            this.ComboKlienci.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(156, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Forma płatności:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(156, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Data transakcji:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(156, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Koszt usługi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(156, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Usługa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(156, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Klient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(279, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Dodaj transakcję";
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(0, 3);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 29;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // OdroczenieBox
            // 
            this.OdroczenieBox.AutoSize = true;
            this.OdroczenieBox.Location = new System.Drawing.Point(519, 285);
            this.OdroczenieBox.Name = "OdroczenieBox";
            this.OdroczenieBox.Size = new System.Drawing.Size(80, 17);
            this.OdroczenieBox.TabIndex = 44;
            this.OdroczenieBox.Text = "Odroczenie";
            this.OdroczenieBox.UseVisualStyleBackColor = true;
            this.OdroczenieBox.CheckedChanged += new System.EventHandler(this.OdroczenieBox_CheckedChanged);
            // 
            // DodajTransakcjęOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OdroczenieBox);
            this.Controls.Add(this.DodajTransakcję);
            this.Controls.Add(this.DataTransakcji);
            this.Controls.Add(this.pln);
            this.Controls.Add(this.KosztNumeric);
            this.Controls.Add(this.FormaPłatnościCombo);
            this.Controls.Add(this.UsługaCombo);
            this.Controls.Add(this.ComboKlienci);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CofnijButton);
            this.Name = "DodajTransakcjęOkno";
            this.Size = new System.Drawing.Size(710, 595);
            ((System.ComponentModel.ISupportInitialize)(this.KosztNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajTransakcję;
        private System.Windows.Forms.DateTimePicker DataTransakcji;
        private System.Windows.Forms.Label pln;
        private System.Windows.Forms.NumericUpDown KosztNumeric;
        private System.Windows.Forms.ComboBox FormaPłatnościCombo;
        private System.Windows.Forms.ComboBox UsługaCombo;
        private System.Windows.Forms.ComboBox ComboKlienci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.CheckBox OdroczenieBox;
    }
}
