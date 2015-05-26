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
using Statystyki.Kontrakt;

namespace PK_Projekt.Kontrolki
{
    public partial class StatystykiOkno : UserControl
    {
        private SqlDataReader Czytacz;
        private List<object> Operacje;
        private List<int> ListaIndeksów;
        private int wybranyklient;
        public StatystykiOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            ListaIndeksów = new List<int>();
            Operacje = ListaOperacji;

        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void poklientachb_Click(object sender, EventArgs e)
        {
            this.groupBox.Controls.Clear();
            StatystykiOkienka.PrzychódZKlientów okno = new StatystykiOkienka.PrzychódZKlientów(Operacje);
            this.groupBox.Controls.Add(okno);
        }



        private void zobowiązanianakliencie_Click(object sender, EventArgs e)
        {
            this.groupBox.Controls.Clear();
            StatystykiOkienka.ZobowiązaniaNaKliencieOkno okno = new StatystykiOkienka.ZobowiązaniaNaKliencieOkno(Operacje);
            this.groupBox.Controls.Add(okno);
        }

        private void transakcjezusług_Click(object sender, EventArgs e)
        {
            this.groupBox.Controls.Clear();
            StatystykiOkienka.UsługiStatystykiOkno okno = new StatystykiOkienka.UsługiStatystykiOkno(Operacje);
            this.groupBox.Controls.Add(okno);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox.Controls.Clear();
            StatystykiOkienka.PrzychódProcentowyZKlientaOkno okno = new StatystykiOkienka.PrzychódProcentowyZKlientaOkno(Operacje);
            this.groupBox.Controls.Add(okno);
        }
    }
}
