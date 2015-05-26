using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PK_Projekt.Kontrolki;
using Ninject;
using TypOperacji.Kontrakt;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace PK_Projekt
{
    public partial class Form1 : Form
    {
        private List<object> ListaOperacji = new List<object>();
        private string Połączenie = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\Uzytkownicy.mdf" + @";Integrated Security=True");
        public static  bool Zalogowanie = false;
            
        public Form1()
        {
            InitializeComponent();

            ListaOperacji = Program.LISTAOPERACJI;

            GroupBox.Controls.Clear();
            LogowanieOkno okno = new LogowanieOkno(Program.GetKontener);
            GroupBox.Controls.Add(okno);
            GroupBox.Controls[0].Location = new Point(100,150);

            try
            {
                WczytanieKomentarzy();
            }
            catch (Exception)
            {
                
            }

            
        }

        private void DodajKlientaButton_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                DodajKlientaOkno okno = new DodajKlientaOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void WyświetlDaneButton_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                WyświetlanieOkno okno = new WyświetlanieOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void edytujKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                EdytujKlientaOkno okno = new EdytujKlientaOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void dodajTransakcjęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                DodajTransakcjęOkno okno = new DodajTransakcjęOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void wyślijMailaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                WyślijMailaOkno okno = new WyślijMailaOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void wyświetlDaneKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                DaneKlientaOkno okno = new DaneKlientaOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void statystykiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                StatystykiOkno okno = new StatystykiOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void historiaTransakcjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                HistoriaTransakcjiOkno okno = new HistoriaTransakcjiOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void nowaUsługaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                NowaUsługaOkno okno = new NowaUsługaOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DodajKomentarz_Click(object sender, EventArgs e)
        {
            if (KomentarzDodaj.Text != null)
            {
                string komentarz = KomentarzDodaj.Text;
                StreamWriter sw = new StreamWriter("Komentarze.txt",true);
                sw.WriteLine(komentarz);
                sw.Close();
            }
            KomentarzDodaj.Text = "";
            WczytanieKomentarzy();
        }

        private void WczytanieKomentarzy()
        {
            KomentarzWyswietl.Text = "";
            StreamReader sr = new StreamReader("Komentarze.txt");
            string str;
            while ((str=sr.ReadLine())!=null)
            {
                KomentarzWyswietl.Text = KomentarzWyswietl.Text + "*"+str + "\r\n";
            }
            string[] linijki = KomentarzWyswietl.Lines;
            try  // zabezpieczenie przed tym jak jest mniej nicz 5 komentarzy 
            {
                string[] tmp = new string[6];
                int licznik = 0;
                for (int i = linijki.Length - 6; i < linijki.Length; i++)
                {
                    tmp[licznik] = linijki[i];
                    licznik++;
                }
                KomentarzWyswietl.Lines = tmp;
            }
            catch (Exception)
            {
                sr.Close();
            }
            sr.Close();
        }

        private void uregulujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Zalogowanie == true)
            {
                GroupBox.Controls.Clear();
                UregulowanieOkno okno = new UregulowanieOkno(this.ListaOperacji);
                GroupBox.Controls.Add(okno);
            }
        }
    }
}
