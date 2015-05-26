namespace PK_Projekt.Kontrolki
{
    partial class UregulowanieOkno
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
            this.Zapłać = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboTransakcje = new System.Windows.Forms.ComboBox();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zapłać
            // 
            this.Zapłać.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zapłać.Location = new System.Drawing.Point(443, 122);
            this.Zapłać.Name = "Zapłać";
            this.Zapłać.Size = new System.Drawing.Size(75, 23);
            this.Zapłać.TabIndex = 43;
            this.Zapłać.Text = "Zapłać";
            this.Zapłać.UseVisualStyleBackColor = true;
            this.Zapłać.Click += new System.EventHandler(this.Zapłać_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(323, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Transakcja";
            // 
            // ComboTransakcje
            // 
            this.ComboTransakcje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTransakcje.FormattingEnabled = true;
            this.ComboTransakcje.Location = new System.Drawing.Point(91, 124);
            this.ComboTransakcje.Name = "ComboTransakcje";
            this.ComboTransakcje.Size = new System.Drawing.Size(346, 21);
            this.ComboTransakcje.TabIndex = 41;
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(6, 4);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 40;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click_1);
            // 
            // UregulowanieOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Zapłać);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboTransakcje);
            this.Controls.Add(this.CofnijButton);
            this.Name = "UregulowanieOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zapłać;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboTransakcje;
        private System.Windows.Forms.Button CofnijButton;
    }
}
