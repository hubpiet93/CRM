namespace PK_Projekt.Kontrolki
{
    partial class LogowanieOkno
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
            this.Logintext = new System.Windows.Forms.TextBox();
            this.Hasłotext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogowanieB = new System.Windows.Forms.Button();
            this.Rejestracja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logintext
            // 
            this.Logintext.Location = new System.Drawing.Point(208, 17);
            this.Logintext.Name = "Logintext";
            this.Logintext.Size = new System.Drawing.Size(141, 20);
            this.Logintext.TabIndex = 0;
            // 
            // Hasłotext
            // 
            this.Hasłotext.Location = new System.Drawing.Point(208, 57);
            this.Hasłotext.Name = "Hasłotext";
            this.Hasłotext.PasswordChar = '*';
            this.Hasłotext.Size = new System.Drawing.Size(141, 20);
            this.Hasłotext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(144, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // LogowanieB
            // 
            this.LogowanieB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogowanieB.Location = new System.Drawing.Point(147, 93);
            this.LogowanieB.Name = "LogowanieB";
            this.LogowanieB.Size = new System.Drawing.Size(75, 23);
            this.LogowanieB.TabIndex = 10;
            this.LogowanieB.Text = "Zaloguj";
            this.LogowanieB.UseVisualStyleBackColor = true;
            this.LogowanieB.Click += new System.EventHandler(this.LogowanieB_Click);
            // 
            // Rejestracja
            // 
            this.Rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rejestracja.Location = new System.Drawing.Point(274, 93);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(75, 23);
            this.Rejestracja.TabIndex = 11;
            this.Rejestracja.Text = "Zarejestruj";
            this.Rejestracja.UseVisualStyleBackColor = true;
            this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
            // 
            // LogowanieOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.LogowanieB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hasłotext);
            this.Controls.Add(this.Logintext);
            this.Name = "LogowanieOkno";
            this.Size = new System.Drawing.Size(511, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Logintext;
        private System.Windows.Forms.TextBox Hasłotext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogowanieB;
        private System.Windows.Forms.Button Rejestracja;
    }
}
