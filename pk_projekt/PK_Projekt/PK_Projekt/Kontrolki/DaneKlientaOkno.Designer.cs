namespace PK_Projekt.Kontrolki
{
    partial class DaneKlientaOkno
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.Zobacz = new System.Windows.Forms.Button();
            this.DaneKlientaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboKlienci
            // 
            this.ComboKlienci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboKlienci.FormattingEnabled = true;
            this.ComboKlienci.Location = new System.Drawing.Point(171, 106);
            this.ComboKlienci.Name = "ComboKlienci";
            this.ComboKlienci.Size = new System.Drawing.Size(270, 21);
            this.ComboKlienci.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wybierz klienta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(267, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dane klienta";
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(1, 2);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 13;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // Zobacz
            // 
            this.Zobacz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zobacz.Location = new System.Drawing.Point(464, 106);
            this.Zobacz.Name = "Zobacz";
            this.Zobacz.Size = new System.Drawing.Size(124, 23);
            this.Zobacz.TabIndex = 18;
            this.Zobacz.Text = "Zobacz";
            this.Zobacz.UseVisualStyleBackColor = true;
            this.Zobacz.Click += new System.EventHandler(this.Zobacz_Click);
            // 
            // DaneKlientaText
            // 
            this.DaneKlientaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaneKlientaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DaneKlientaText.Location = new System.Drawing.Point(65, 149);
            this.DaneKlientaText.Multiline = true;
            this.DaneKlientaText.Name = "DaneKlientaText";
            this.DaneKlientaText.ReadOnly = true;
            this.DaneKlientaText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DaneKlientaText.Size = new System.Drawing.Size(523, 228);
            this.DaneKlientaText.TabIndex = 19;
            // 
            // DaneKlientaOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DaneKlientaText);
            this.Controls.Add(this.Zobacz);
            this.Controls.Add(this.ComboKlienci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CofnijButton);
            this.Name = "DaneKlientaOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboKlienci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.Button Zobacz;
        private System.Windows.Forms.TextBox DaneKlientaText;
    }
}
