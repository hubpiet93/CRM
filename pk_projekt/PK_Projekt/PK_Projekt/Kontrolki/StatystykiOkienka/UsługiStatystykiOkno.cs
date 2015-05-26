using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statystyki.Kontrakt;
using System.Data.SqlClient;

namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    public partial class UsługiStatystykiOkno : UserControl
    {
        private List<object> Operacje;
        private SqlDataReader Czytacz;
        public UsługiStatystykiOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
        }

        private void Zobacz_Click(object sender, EventArgs e)
        {
            
            Czytacz = (Operacje[5] as IBudujStatystyki).TransakcjeNaUsłudze(DataOd.Value.ToShortDateString().ToString(),
                                                                            DataDo.Value.ToShortDateString().ToString());
            if (Czytacz.HasRows)
            {
                LiczbaTransakcji.Items.Clear();
                while (Czytacz.Read())
                {
                    ListViewItem listitems = new ListViewItem(Czytacz[0].ToString());
                    listitems.SubItems.Add(Czytacz[1].ToString());
                    listitems.SubItems.Add(Czytacz[2].ToString());
                    LiczbaTransakcji.Items.Add(listitems);
                }
            }
            (Operacje[5] as IBudujStatystyki).PołączenieClose();
        }
    }
}
