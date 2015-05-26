using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NowaUsługa.Kontrakt;
using System.Data.SqlClient;

namespace PK_Projekt.Kontrolki
{
    public partial class NowaUsługaOkno : UserControl
    {
        private List<object> Operacje;
        public NowaUsługaOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
            UzupełnijListView();
        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            if (!(NowaUsługa.Text == ""))
            {
                try
                {
                    (Operacje[4] as IDodajUsługę).DodajNowąUsługę(NowaUsługa.Text);
                    NowaUsługa.Text = "";
                    UzupełnijListView();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }
            }
        }


        private void UzupełnijListView()
        {
            ListaUsług.Items.Clear();
            SqlDataReader Czytacz;
            try
            {
                Czytacz = (Operacje[4] as IDodajUsługę).GetUsługi();
                if (Czytacz.HasRows)
                {
                    while (Czytacz.Read())
                    {
                        ListViewItem listitems = new ListViewItem(Czytacz[0].ToString());
                        listitems.SubItems.Add(Czytacz[1].ToString());
                        ListaUsług.Items.Add(listitems);
                    }
                }
                (Operacje[4] as IDodajUsługę).PołączenieClose();
            }
            catch (Exception)
            {
            }
            
        }
    }
}
