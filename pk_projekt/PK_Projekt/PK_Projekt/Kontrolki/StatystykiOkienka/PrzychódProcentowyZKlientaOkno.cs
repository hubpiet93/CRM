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
using Statystyki.Kontrakt;

namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    public partial class PrzychódProcentowyZKlientaOkno : UserControl
    {
        private List<object> Operacje;
        private int CałkowityPrzychód = 0;
        public PrzychódProcentowyZKlientaOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
        }

        private void Zobacz_Click(object sender, EventArgs e)
        {
            SqlDataReader Czytacz;

            try
            {
                CałkowityPrzychód = 0;
                Czytacz = (Operacje[5] as IBudujStatystyki).PrzychódCałkowity(DataOd.Value.ToShortDateString().ToString(),
                                                                DataDo.Value.ToShortDateString().ToString());
                if (Czytacz.HasRows)
                {
                    ProcentoweLista.Items.Clear();
                    while (Czytacz.Read())
                    {
                        CałkowityPrzychód = Convert.ToInt32(Czytacz[0]);
                    }
                }
                (Operacje[5] as IBudujStatystyki).PołączenieClose();


                Czytacz = (Operacje[5] as IBudujStatystyki).PrzychódProcentowy(DataOd.Value.ToShortDateString().ToString(),
                                                                               DataDo.Value.ToShortDateString().ToString(),
                                                                               CałkowityPrzychód);

                if (Czytacz.HasRows)
                {
                    ProcentoweLista.Items.Clear();
                    while (Czytacz.Read())
                    {
                        ListViewItem listitems = new ListViewItem(Czytacz[0].ToString());
                        listitems.SubItems.Add(Czytacz[1].ToString());
                        listitems.SubItems.Add(Czytacz[2].ToString());
                        listitems.SubItems.Add(Convert.ToDouble(((Convert.ToDouble(Czytacz[3]) / CałkowityPrzychód) * 100)).ToString().Substring(0,5));
                        ProcentoweLista.Items.Add(listitems);
                    }
                }
                (Operacje[5] as IBudujStatystyki).PołączenieClose();
            }
            catch (Exception)
            {
                ProcentoweLista.Items.Clear();
                (Operacje[5] as IBudujStatystyki).PołączenieClose();
            }
        }
    }
}
