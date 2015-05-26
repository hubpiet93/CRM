namespace PK_Projekt.Kontrolki
{
    partial class NowaUsługaOkno
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
            this.DodajButton = new System.Windows.Forms.Button();
            this.NowaUsługa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaUsług = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazwaUsługi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DodajButton
            // 
            this.DodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajButton.Location = new System.Drawing.Point(273, 184);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(140, 40);
            this.DodajButton.TabIndex = 42;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // NowaUsługa
            // 
            this.NowaUsługa.Location = new System.Drawing.Point(261, 125);
            this.NowaUsługa.Name = "NowaUsługa";
            this.NowaUsługa.Size = new System.Drawing.Size(292, 20);
            this.NowaUsługa.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(143, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nazwa usługi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(285, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dodaj nową usługę";
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(3, 2);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 38;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(285, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Wszystkie usługi";
            // 
            // ListaUsług
            // 
            this.ListaUsług.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NazwaUsługi});
            this.ListaUsług.GridLines = true;
            this.ListaUsług.HideSelection = false;
            this.ListaUsług.Location = new System.Drawing.Point(90, 277);
            this.ListaUsług.MultiSelect = false;
            this.ListaUsług.Name = "ListaUsług";
            this.ListaUsług.Size = new System.Drawing.Size(526, 205);
            this.ListaUsług.TabIndex = 44;
            this.ListaUsług.UseCompatibleStateImageBehavior = false;
            this.ListaUsług.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 61;
            // 
            // NazwaUsługi
            // 
            this.NazwaUsługi.Text = "Nazwa usługi";
            this.NazwaUsługi.Width = 461;
            // 
            // NowaUsługaOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListaUsług);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.NowaUsługa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CofnijButton);
            this.Name = "NowaUsługaOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.TextBox NowaUsługa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListaUsług;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NazwaUsługi;
    }
}
