namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    partial class UsługiStatystykiOkno
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
            this.Do = new System.Windows.Forms.Label();
            this.Od = new System.Windows.Forms.Label();
            this.DataDo = new System.Windows.Forms.DateTimePicker();
            this.DataOd = new System.Windows.Forms.DateTimePicker();
            this.LiczbaTransakcji = new System.Windows.Forms.ListView();
            this.Usługa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LiczbaWystąpień = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zobacz = new System.Windows.Forms.Button();
            this.SumaZUsług = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(223, 15);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(27, 13);
            this.Do.TabIndex = 49;
            this.Do.Text = "Do :";
            // 
            // Od
            // 
            this.Od.AutoSize = true;
            this.Od.Location = new System.Drawing.Point(61, 15);
            this.Od.Name = "Od";
            this.Od.Size = new System.Drawing.Size(27, 13);
            this.Od.TabIndex = 48;
            this.Od.Text = "Od :";
            // 
            // DataDo
            // 
            this.DataDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDo.Location = new System.Drawing.Point(256, 13);
            this.DataDo.Name = "DataDo";
            this.DataDo.Size = new System.Drawing.Size(98, 20);
            this.DataDo.TabIndex = 47;
            // 
            // DataOd
            // 
            this.DataOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataOd.Location = new System.Drawing.Point(94, 13);
            this.DataOd.Name = "DataOd";
            this.DataOd.Size = new System.Drawing.Size(98, 20);
            this.DataOd.TabIndex = 46;
            // 
            // LiczbaTransakcji
            // 
            this.LiczbaTransakcji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Usługa,
            this.LiczbaWystąpień,
            this.SumaZUsług});
            this.LiczbaTransakcji.GridLines = true;
            this.LiczbaTransakcji.Location = new System.Drawing.Point(7, 39);
            this.LiczbaTransakcji.MultiSelect = false;
            this.LiczbaTransakcji.Name = "LiczbaTransakcji";
            this.LiczbaTransakcji.Size = new System.Drawing.Size(646, 343);
            this.LiczbaTransakcji.TabIndex = 50;
            this.LiczbaTransakcji.UseCompatibleStateImageBehavior = false;
            this.LiczbaTransakcji.View = System.Windows.Forms.View.Details;
            // 
            // Usługa
            // 
            this.Usługa.Text = "Usługa";
            this.Usługa.Width = 181;
            // 
            // LiczbaWystąpień
            // 
            this.LiczbaWystąpień.Text = "Liczba transakcji";
            this.LiczbaWystąpień.Width = 223;
            // 
            // Zobacz
            // 
            this.Zobacz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zobacz.Location = new System.Drawing.Point(403, 10);
            this.Zobacz.Name = "Zobacz";
            this.Zobacz.Size = new System.Drawing.Size(124, 23);
            this.Zobacz.TabIndex = 51;
            this.Zobacz.Text = "Zobacz";
            this.Zobacz.UseVisualStyleBackColor = true;
            this.Zobacz.Click += new System.EventHandler(this.Zobacz_Click);
            // 
            // SumaZUsług
            // 
            this.SumaZUsług.Text = "Suma z usług";
            this.SumaZUsług.Width = 235;
            // 
            // UsługiStatystykiOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Zobacz);
            this.Controls.Add(this.LiczbaTransakcji);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.Od);
            this.Controls.Add(this.DataDo);
            this.Controls.Add(this.DataOd);
            this.Name = "UsługiStatystykiOkno";
            this.Size = new System.Drawing.Size(660, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.Label Od;
        private System.Windows.Forms.DateTimePicker DataDo;
        private System.Windows.Forms.DateTimePicker DataOd;
        private System.Windows.Forms.ListView LiczbaTransakcji;
        private System.Windows.Forms.ColumnHeader Usługa;
        private System.Windows.Forms.ColumnHeader LiczbaWystąpień;
        private System.Windows.Forms.Button Zobacz;
        private System.Windows.Forms.ColumnHeader SumaZUsług;
    }
}
