using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Test
{
    public partial class Form1 : Form
    {
        private List<Osoba> listaOsoba = new List<Osoba>();

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            cmbUloga.Items.AddRange(new string[] { "Učenik", "Profesor", "Tehničko osoblje" });
            cmbFiltrirajUloga.Items.AddRange(new string[] { "Učenik", "Profesor", "Tehničko osoblje" });
        }

        private void btnDodajOsobu_Click(object sender, EventArgs e)
        {
            Osoba novaOsoba = new Osoba
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Uloga = cmbUloga.SelectedItem.ToString()
            };
            listaOsoba.Add(novaOsoba);
            OsvjeziPrikaz();
        }

        private void btnPrikaziOsobe_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        private void OsvjeziPrikaz()
        {
            dgvOsobe.DataSource = null;
            dgvOsobe.DataSource = listaOsoba;

            txtIspis.Clear();

            foreach (Osoba osoba in listaOsoba)
            {
                txtIspis.AppendText($"{osoba.Ime} {osoba.Prezime} - {osoba.Uloga} ({osoba.Aktivnost})" + Environment.NewLine);
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string odabranaUloga = cmbFiltrirajUloga.SelectedItem.ToString();
            var filtriraneOsobe = listaOsoba.Where(o => o.Uloga == odabranaUloga).ToList();
            dgvOsobe.DataSource = null;
            dgvOsobe.DataSource = filtriraneOsobe;
        }

        private void btnObradiPodatke_Click(object sender, EventArgs e)
        {
            foreach (var osoba in listaOsoba)
            {
                switch (osoba.Uloga)
                {
                    case "Učenik":
                        osoba.Aktivnost = "Uči";
                        break;
                    case "Profesor":
                        osoba.Aktivnost = "Predaje";
                        break;
                    case "Tehničko osoblje":
                        osoba.Aktivnost = "Održava";
                        break;
                }
            }
            OsvjeziPrikaz();
        }

        private void btnSortirajPoImenu_Click(object sender, EventArgs e)
        {
            listaOsoba = listaOsoba.OrderBy(o => o.Ime).ToList();
            OsvjeziPrikaz();
        }

        private void btnSpremiUCSV_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("osobe.csv"))
            {
                foreach (var osoba in listaOsoba)
                {
                    sw.WriteLine($"{osoba.Ime},{osoba.Prezime},{osoba.Uloga},{osoba.Aktivnost}");
                }
            }
        }

        private void btnUcitajIzCSV_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("osobe.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split(',');
                    listaOsoba.Add(new Osoba { Ime = data[0], Prezime = data[1], Uloga = data[2], Aktivnost = data[3] });
                }
            }
            OsvjeziPrikaz();
        }
    }
}