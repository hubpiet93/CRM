using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Wyświetl.Kontrakt;
using NowaUsługa.Kontrakt;
using ObsługaKlienta.Kontrakt;

namespace PK_Projekt.Kontrolki
{
    public partial class DodajTransakcjęOkno : UserControl
    {
        private List<object> Operacje;
        private SqlDataReader Czytacz;
        private List<int> ListaIndeksówKlienci;
        private List<int> ListaIndeksówUsługi;
        private int wybranyklient;
        private int wybranausługa;
        private bool wybieranie = false;
        private bool Odroczenie;
        public DodajTransakcjęOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;

            ListaIndeksówKlienci = new List<int>();
            ListaIndeksówUsługi = new List<int>();
            WypełnijComboUsługi();
            WypełnijComboKlienci();
            FormaPłatnościCombo.Items.Add("Gotówka");
            FormaPłatnościCombo.Items.Add("Karta płatnicza");

            //DataTransakcji.Value.ToShortDateString().ToString()
        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DodajTransakcję_Click(object sender, EventArgs e)
        {
            if (!(ComboKlienci.SelectedIndex == -1 || UsługaCombo.SelectedIndex == -1 || KosztNumeric.Value == 0 || FormaPłatnościCombo.SelectedIndex == -1))
            {
                wybranyklient = ListaIndeksówKlienci[ComboKlienci.SelectedIndex];
                wybranausługa = ListaIndeksówUsługi[UsługaCombo.SelectedIndex];
                string PolecenieSql;
                SqlCommand s;
                string PolecenieSql2;
                SqlCommand s2;
                if (OdroczenieBox.Checked)
                {
                    PolecenieSql = String.Format(@"insert into [dbo].[Transakcje]
                                                     ([IdKlienta],[IdUsługi],[DataTransakcji],[FormaPłatności],[WartośćTransakcji],[Zapłacone] )
                                                     values
                                                     ('" + wybranyklient + "','" + wybranausługa + "','" + DataTransakcji.Value.ToShortDateString().ToString() + "','" + FormaPłatnościCombo.Text + "','" + KosztNumeric.Value + "','" + false.ToString() + "')");
                    s = new SqlCommand(PolecenieSql);

                    PolecenieSql2 = String.Format(@"insert into [dbo].[Zobowiazania]
                                                      ([DataTransakcji])
                                                      values
                                                      ('" + DataTransakcji.Value.ToShortDateString().ToString() + "')");
                    s2 = new SqlCommand(PolecenieSql2);
                }
                else
                {
                    PolecenieSql = String.Format(@"insert into [dbo].[Transakcje]
                                                     ([IdKlienta],[IdUsługi],[DataTransakcji],[FormaPłatności],[WartośćTransakcji],[Zapłacone] )
                                                     values
                                                     ('" + wybranyklient + "','" + wybranausługa + "','" + DataTransakcji.Value.ToShortDateString().ToString() + "','" + FormaPłatnościCombo.Text + "','" + KosztNumeric.Value + "','" + true.ToString() + "')");
                    s = new SqlCommand(PolecenieSql);
                    PolecenieSql2 = String.Format(@"insert into [dbo].[Zobowiazania]
                                                      ([DataTransakcji],[DataZapłaty])
                                                      values
                                                      ('" + DataTransakcji.Value.ToShortDateString().ToString() + "','" + DataTransakcji.Value.ToShortDateString().ToString() + "')");

                    s2 = new SqlCommand(PolecenieSql2);
                }




                try
                {
                    (Operacje[2] as IObsługaKlienta).DodajTransakcję(s);
                    (Operacje[2] as IObsługaKlienta).DodajTransakcję(s2);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    throw;
                }
                CzyśćPola();
            }

        }


        private void WypełnijComboKlienci()
        {
            ComboKlienci.Items.Clear();
            ComboKlienci.SelectedItem = null;
            Czytacz = (Operacje[3] as IWyświetl).WyświetlWszystkichKlientów();
            if (Czytacz.HasRows)
            {
                while (Czytacz.Read())
                {
                    ListaIndeksówKlienci.Add(Convert.ToInt32(Czytacz[0]));
                    ComboKlienci.Items.Add("Id: " + Czytacz[0] + " " + Czytacz[1] + " " + Czytacz[2] + " Pesel: " + Czytacz[3]);
                }
            }
            (Operacje[3] as IWyświetl).PołączenieClose();
        }
        private void WypełnijComboUsługi()
        {
            UsługaCombo.Items.Clear();
            UsługaCombo.SelectedItem = null;
            Czytacz = (Operacje[4] as IDodajUsługę).GetUsługi();
            if (Czytacz.HasRows)
            {
                while (Czytacz.Read())
                {
                    ListaIndeksówUsługi.Add(Convert.ToInt32(Czytacz[0]));
                    UsługaCombo.Items.Add(Czytacz[1]);
                }
            }
            (Operacje[4] as IDodajUsługę).PołączenieClose();
        }

        private void CzyśćPola()
        {
            ComboKlienci.SelectedItem = null;
            UsługaCombo.SelectedItem = null;
            KosztNumeric.Value = 0;
            DataTransakcji.ResetText();
            FormaPłatnościCombo.SelectedItem = null;
            FormaPłatnościCombo.Text = "";
            UsługaCombo.Text = "";
            ComboKlienci.Text = "";
            OdroczenieBox.Checked = false;
        }

        private void OdroczenieBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
