using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WysyłanieMaili.Kontrakt;
using System.Data.SqlClient;
using Wyświetl.Kontrakt;

namespace PK_Projekt.Kontrolki
{
    public partial class WyślijMailaOkno : UserControl
    {
        private List<object> Operacje;
        private List<string> AdresyMail;
        public WyślijMailaOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
            AdresyMail = new List<string>();
        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DoWszystkich_CheckedChanged(object sender, EventArgs e)
        {
            if (DoWszystkich.Checked)
            {
                AdresOdbiorcy.Enabled = false;
                AdresyMail = new List<string>();
                SqlDataReader Czytacz;
                Czytacz = (Operacje[3] as IWyświetl).WyświetlWszystkichKlientów();
                if (Czytacz.HasRows)
                {
                    while (Czytacz.Read())
                    {
                        AdresyMail.Add(Czytacz[10].ToString());
                    }
                }
                (Operacje[3] as IWyświetl).PołączenieClose();
            }
            else
            {
                AdresOdbiorcy.Enabled = true;
            }
        }

        private void WyślijButton_Click(object sender, EventArgs e)
        {
            if (DoWszystkich.Checked)
            {
                try
                {
                    (Operacje[1] as IOperacjeMail).SeryjnyMail(AdresNadawcy.Text, Hasło.Text, AdresSmtp.Text, Convert.ToInt32(Port.Text), AdresyMail, Temat.Text, Wiadomość.Text);
                    Czyszczenie();
                }
                catch (Exception)
                {
                    MessageBox.Show("Coś poszło nie tak");
                    Czyszczenie();
                }
            }
            else
            {
                try
                {
                    (Operacje[1] as IOperacjeMail).PojedyńczyMail(AdresNadawcy.Text, Hasło.Text, AdresSmtp.Text, Convert.ToInt32(Port.Text), AdresOdbiorcy.Text, Temat.Text, Wiadomość.Text);
                    Czyszczenie();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Coś poszło nie tak");
                    Czyszczenie();
                }
            }
        }
        private void Czyszczenie()
        {
            AdresNadawcy.Text = "";
            AdresOdbiorcy.Text = "";
            AdresSmtp.Text = "";
            Port.Text = "";
            Temat.Text = "";
            Wiadomość.Text = "";
            Hasło.Text = "";
        }
    }
}
