using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Data.SqlClient;

namespace PK_Projekt.Kontrolki
{
    public partial class LogowanieOkno : UserControl
    {
        private IKernel Kontener;
        private string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private SqlConnection Połączenie; 
        public LogowanieOkno(IKernel Kontener)
        {
            InitializeComponent();
            this.Kontener = Kontener;
            string połaczenie = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\Uzytkownicy.mdf" + @";Integrated Security=True");
            this.Połączenie = new SqlConnection(połaczenie);
        }

        private void LogowanieB_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontener.Get<SystemLogowania.Contract.IUzytkownicy>().Zaloguj(Logintext.Text, Hasłotext.Text, path, @"\Uzytkownicy.mdf", "Login", "Hasło"))
                {
                    Form1.Zalogowanie = true;
                    MessageBox.Show("Logowanie powiodło się");
                    this.Dispose();
                }
                else
                {
                    Form1.Zalogowanie = false;
                    MessageBox.Show("Błędny login lub hasło");
                }
            }
            catch (Exception ee )
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            SqlCommand kwerenda;
            String Polecenie = "";
            try
            {
                Polecenie = String.Format(@"insert into [dbo].[Uzytkownicy]
                                            ([Login],[Hasło])
                                            values
                                            ('{0}','{1}')",Logintext.Text,Hasłotext.Text);
                kwerenda = new SqlCommand(Polecenie);
                Połączenie.Open();
                kwerenda.Connection = Połączenie;


                kwerenda.ExecuteNonQuery();
                Połączenie.Close();
                MessageBox.Show("Dodanie użytkownika powiodło się");
                Hasłotext.Text = "";
                Logintext.Text = "";
            }
            catch (Exception )
            {
                MessageBox.Show("Dodanie użytkownika nie powiodło się");
                Połączenie.Close();
            }
        }
    }
}
