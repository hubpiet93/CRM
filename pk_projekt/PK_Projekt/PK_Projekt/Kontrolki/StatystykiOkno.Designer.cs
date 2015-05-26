namespace PK_Projekt.Kontrolki
{
    partial class StatystykiOkno
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.poklientachb = new System.Windows.Forms.Button();
            this.zobowiązanianakliencie = new System.Windows.Forms.Button();
            this.transakcjezusług = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(34, 145);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(660, 420);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(277, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Statystyki";
            // 
            // CofnijButton
            // 
            this.CofnijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CofnijButton.Location = new System.Drawing.Point(3, 3);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 12;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // poklientachb
            // 
            this.poklientachb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poklientachb.Location = new System.Drawing.Point(34, 84);
            this.poklientachb.Name = "poklientachb";
            this.poklientachb.Size = new System.Drawing.Size(144, 55);
            this.poklientachb.TabIndex = 16;
            this.poklientachb.Text = "Przychód po klientach";
            this.poklientachb.UseVisualStyleBackColor = true;
            this.poklientachb.Click += new System.EventHandler(this.poklientachb_Click);
            // 
            // zobowiązanianakliencie
            // 
            this.zobowiązanianakliencie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zobowiązanianakliencie.Location = new System.Drawing.Point(201, 84);
            this.zobowiązanianakliencie.Name = "zobowiązanianakliencie";
            this.zobowiązanianakliencie.Size = new System.Drawing.Size(144, 55);
            this.zobowiązanianakliencie.TabIndex = 17;
            this.zobowiązanianakliencie.Text = "Zobowiązania na kliencie";
            this.zobowiązanianakliencie.UseVisualStyleBackColor = true;
            this.zobowiązanianakliencie.Click += new System.EventHandler(this.zobowiązanianakliencie_Click);
            // 
            // transakcjezusług
            // 
            this.transakcjezusług.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transakcjezusług.Location = new System.Drawing.Point(368, 84);
            this.transakcjezusług.Name = "transakcjezusług";
            this.transakcjezusług.Size = new System.Drawing.Size(144, 55);
            this.transakcjezusług.TabIndex = 18;
            this.transakcjezusług.Text = "Liczba transakcji z usług";
            this.transakcjezusług.UseVisualStyleBackColor = true;
            this.transakcjezusług.Click += new System.EventHandler(this.transakcjezusług_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(528, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Procentowy przychód z klientów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatystykiOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transakcjezusług);
            this.Controls.Add(this.zobowiązanianakliencie);
            this.Controls.Add(this.poklientachb);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CofnijButton);
            this.Name = "StatystykiOkno";
            this.Size = new System.Drawing.Size(710, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.Button poklientachb;
        private System.Windows.Forms.Button zobowiązanianakliencie;
        private System.Windows.Forms.Button transakcjezusług;
        private System.Windows.Forms.Button button1;
    }
}
