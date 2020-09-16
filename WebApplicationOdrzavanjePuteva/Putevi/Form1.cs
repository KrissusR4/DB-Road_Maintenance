using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Putevi.Mapiranja;
using Putevi.Entiteti;

namespace Putevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUcitajGradiliste_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Gradiliste g = s.Load<Gradiliste>(2);

                MessageBox.Show(g.Tip);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajIzvrsioca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Izvrsilac i = new Izvrsilac();

                i.Ime = "Petar";
                i.Prezime = "Peric";
                i.GodRodj = 1990;
                i.OcevoIme = "Nikola";
                i.Adresa = "Pere Detlica 3";
                i.Specijalnost = "vozac";
                i.JMBG = 0111981314435;
                i.Sef = s.Load<Radnik>(1);
                i.Preduzece = s.Load<Preduzece>(1);
                s.Save(i);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Preduzece p = s.Load<Preduzece>(1);
                foreach (Gradiliste g in p.Gradilista)
                {
                    MessageBox.Show(g.Tip);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Gradiliste g = s.Load<Gradiliste>(2);

                MessageBox.Show(g.Tip);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDuzi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Duzi d = new Duzi();
                d.DatumOd = new DateTime(2016, 2, 9);
                d.DatumDo = new DateTime(2016, 4, 11);
                d.Nadzornici = s.Load<Nadzornik>(2);
                d.PutnickaVozila = s.Load<Putnicko>("NI-001-01");

                s.Save(d);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Preduzece_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Preduzece p = s.Get<Preduzece>(1);

                MessageBox.Show(p.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo p = s.Load<Vozilo>("NI-001-01");

                MessageBox.Show(p.Boja);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIzvrsilac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Izvrsilac i = s.Load<Izvrsilac>(2);

                MessageBox.Show(i.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Izvrsilac i = s.Load<Izvrsilac>(2);
                foreach (Vozilo v in i.Vozila)
                {
                    MessageBox.Show(v.RegOznaka);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVratiSaradnike_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nadzornik i = s.Load<Nadzornik>(1);
                foreach (SpoljniSaradnik j in i.SpoljniSaradnici)
                {
                    MessageBox.Show("Broj ugovora o delu saradnika: "+j.BrUgovoraODelu.ToString());
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnAngazovanjaTer_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Deonica d = s.Load<Deonica>(1);
                foreach (RadnaMasina ra in d.RadneMasine)
                {
                    MessageBox.Show("Tip radne masine: "+ra.Tip);
                }

                foreach (Teretno t in d.Teretna)
                {
                    MessageBox.Show("Nosivost teretnog vozila: "+t.Nosivost.ToString());
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVratiAngazovaneIzvrsioce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Deonica d = s.Load<Deonica>(3);
                foreach (Izvrsilac j in d.Izvrsioci)
                {
                    MessageBox.Show(j.Ime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVratiDuzenja_Click(object sender, EventArgs e)
        {
           IList<Upravlja> ListaDuzenja = new List<Upravlja>();

            try
            {
                ISession s = DataLayer.GetSession();
                //s.Clear();
                /*IQuery q*/ ListaDuzenja= s.CreateQuery("FROM Upravlja").List<Upravlja>();
                
               // ListaDuzenja = q.List<Upravlja>();

                foreach (Upravlja d in ListaDuzenja)
                {
                    MessageBox.Show("Izvrsilac " + d.Izvrsilac.Ime + " Duzi vozilo" + d.Vozilo.RegOznaka);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
