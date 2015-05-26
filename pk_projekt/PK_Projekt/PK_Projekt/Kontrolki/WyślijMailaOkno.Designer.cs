namespace PK_Projekt.Kontrolki
{
    partial class WyślijMailaOkno
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
            this.WyślijButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Wiadomość = new System.Windows.Forms.TextBox();
            this.DoWszystkich = new System.Windows.Forms.CheckBox();
            this.Temat = new System.Windows.Forms.TextBox();
            this.Hasło = new System.Windows.Forms.TextBox();
            this.AdresSmtp = new System.Windows.Forms.TextBox();
            this.AdresOdbiorcy = new System.Windows.Forms.TextBox();
            this.AdresNadawcy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WyślijButton
            // 
            this.WyślijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WyślijButton.Location = new System.Drawing.Point(341, 489);
            this.WyślijButton.Name = "WyślijButton";
            this.WyślijButton.Size = new System.Drawing.Size(78, 40);
            this.WyślijButton.TabIndex = 40;
            this.WyślijButton.Text = "Wyślij";
            this.WyślijButton.UseVisualStyleBackColor = true;
            this.WyślijButton.Click += new System.EventHandler(this.WyślijButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(338, 302);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 17);
            this.label.TabIndex = 39;
            this.label.Text = "Wiadomość";
            // 
            // Wiadomość
            // 
            this.Wiadomość.Location = new System.Drawing.Point(163, 331);
            this.Wiadomość.Multiline = true;
            this.Wiadomość.Name = "Wiadomość";
            this.Wiadomość.Size = new System.Drawing.Size(434, 152);
            this.Wiadomość.TabIndex = 38;
            // 
            // DoWszystkich
            // 
            this.DoWszystkich.AutoSize = true;
            this.DoWszystkich.Location = new System.Drawing.Point(503, 140);
            this.DoWszystkich.Name = "DoWszystkich";
            this.DoWszystkich.Size = new System.Drawing.Size(94, 17);
            this.DoWszystkich.TabIndex = 37;
            this.DoWszystkich.Text = "Do wszystkich";
            this.DoWszystkich.UseVisualStyleBackColor = true;
            this.DoWszystkich.CheckedChanged += new System.EventHandler(this.DoWszystkich_CheckedChanged);
            // 
            // Temat
            // 
            this.Temat.Location = new System.Drawing.Point(265, 279);
            this.Temat.Name = "Temat";
            this.Temat.Size = new System.Drawing.Size(217, 20);
            this.Temat.TabIndex = 36;
            // 
            // Hasło
            // 
            this.Hasło.Location = new System.Drawing.Point(265, 238);
            this.Hasło.Name = "Hasło";
            this.Hasło.PasswordChar = '*';
            this.Hasło.Size = new System.Drawing.Size(217, 20);
            this.Hasło.TabIndex = 35;
            // 
            // AdresSmtp
            // 
            this.AdresSmtp.Location = new System.Drawing.Point(265, 174);
            this.AdresSmtp.Name = "AdresSmtp";
            this.AdresSmtp.Size = new System.Drawing.Size(217, 20);
            this.AdresSmtp.TabIndex = 34;
            // 
            // AdresOdbiorcy
            // 
            this.AdresOdbiorcy.Location = new System.Drawing.Point(265, 137);
            this.AdresOdbiorcy.Name = "AdresOdbiorcy";
            this.AdresOdbiorcy.Size = new System.Drawing.Size(217, 20);
            this.AdresOdbiorcy.TabIndex = 33;
            // 
            // AdresNadawcy
            // 
            this.AdresNadawcy.Location = new System.Drawing.Point(265, 100);
            this.AdresNadawcy.Name = "AdresNadawcy";
            this.AdresNadawcy.Size = new System.Drawing.Size(217, 20);
            this.AdresNadawcy.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(160, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Temat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(160, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(160, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Adres smtp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(160, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(160, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Z:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(296, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Wyślij maila";
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(4, 4);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 25;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(160, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Port:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(265, 207);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(217, 20);
            this.Port.TabIndex = 42;
            // 
            // WyślijMailaOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WyślijButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Wiadomość);
            this.Controls.Add(this.DoWszystkich);
            this.Controls.Add(this.Temat);
            this.Controls.Add(this.Hasło);
            this.Controls.Add(this.AdresSmtp);
            this.Controls.Add(this.AdresOdbiorcy);
            this.Controls.Add(this.AdresNadawcy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CofnijButton);
            this.Name = "WyślijMailaOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WyślijButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Wiadomość;
        private System.Windows.Forms.CheckBox DoWszystkich;
        private System.Windows.Forms.TextBox Temat;
        private System.Windows.Forms.TextBox Hasło;
        private System.Windows.Forms.TextBox AdresSmtp;
        private System.Windows.Forms.TextBox AdresOdbiorcy;
        private System.Windows.Forms.TextBox AdresNadawcy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Port;
    }
}
