using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putevi.Entiteti;
using NHibernate.Linq;
using NHibernate;
using Putevi.DTOs;

namespace Putevi
{
    public class DataProvider
    {

        #region Entiteti   

        #region Radnik
        public IList<RadnikView> GetRadnike()
        {
            ISession s = DataLayer.GetSession();
            IList<RadnikView> r = new List<RadnikView>();
            IEnumerable<Radnik> radnici = s.Query<Radnik>().Select(p => p);
            foreach (Radnik rad in radnici)
            {
                r.Add(new RadnikView(rad));
            }
            return r;
        }

        public RadnikView GetRadnik(int id)
        {
            ISession s = DataLayer.GetSession();
            Radnik r= s.Query<Radnik>().Where(e => e.IdRadnik == id).Select(p => p).FirstOrDefault();
            RadnikView rw = new RadnikView(r);
            return rw;
        }

        public int AddRadnik(Radnik r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveRadnik(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radnik r = s.Load<Radnik>(id);
                s.Delete(r);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateRadnik(int id, Radnik r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Radnik r where r.IdRadnik = " + id);
                Radnik radnik = query.UniqueResult<Radnik>();

                radnik.Ime = r.Ime;
                radnik.Prezime = r.Prezime;
                radnik.OcevoIme = r.OcevoIme;
                radnik.GodRodj = r.GodRodj;
                radnik.JMBG = r.JMBG;
                radnik.Adresa = r.Adresa;

                s.SaveOrUpdate(radnik);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion
       

        #region Nadzornik
        public IList<NadzornikView> GetNadzornike()
        {
            ISession s = DataLayer.GetSession();
            IList<NadzornikView> r = new List<NadzornikView>();
            IEnumerable<Nadzornik> radnici = s.Query<Nadzornik>().Select(p => p);
            foreach (Nadzornik rad in radnici)
            {
                r.Add(new NadzornikView(rad));
            }
            return r;
        }

        public NadzornikView GetNadzornik(int id)
        {
            ISession s = DataLayer.GetSession();
            Nadzornik n = s.Query<Nadzornik>().Where(e => e.IdRadnik == id).Select(p => p).FirstOrDefault();
            NadzornikView nadzornik = new NadzornikView(n);
            return nadzornik;
        }

        public int AddNadzornik(Nadzornik n)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(n);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveNadzornik(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nadzornik n = s.Load<Nadzornik>(id);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateNadzornik(int id, Nadzornik r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Nadzornik r where r.IdRadnik = " + id);
                Nadzornik radnik = query.UniqueResult<Nadzornik>();

                radnik.Ime = r.Ime;
                radnik.Prezime = r.Prezime;
                radnik.OcevoIme = r.OcevoIme;
                radnik.GodRodj = r.GodRodj;
                radnik.JMBG = r.JMBG;
                radnik.DatumPostavljanja = r.DatumPostavljanja;
                radnik.Adresa = r.Adresa;

                s.SaveOrUpdate(radnik);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion
        

        #region Izvrsilac
        public IList<IzvrsilacView> GetIzvrsioce()
        {
            ISession s = DataLayer.GetSession();
            IList<IzvrsilacView> r = new List<IzvrsilacView>();
            IEnumerable<Izvrsilac> radnici = s.Query<Izvrsilac>().Select(p => p);
            foreach (Izvrsilac rad in radnici)
            {
                r.Add(new IzvrsilacView(rad));
            }
            return r;
        }

        public IzvrsilacView GetIzvrsilac(int id)
        {
            ISession s = DataLayer.GetSession();
            Izvrsilac i = s.Query<Izvrsilac>().Where(e => e.IdRadnik == id).Select(p => p).FirstOrDefault();
            IzvrsilacView v = new IzvrsilacView(i);
            return v;
        }

        public int AddIzvrsilac(Izvrsilac n)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(n);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveIzvrsilac(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Izvrsilac n = s.Load<Izvrsilac>(id);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateIzvrsilac(int id, Izvrsilac r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Izvrsilac r where r.IdRadnik = " + id);
                Izvrsilac radnik = query.UniqueResult<Izvrsilac>();

                radnik.Ime = r.Ime;
                radnik.Prezime = r.Prezime;
                radnik.OcevoIme = r.OcevoIme;
                radnik.GodRodj = r.GodRodj;
                radnik.JMBG = r.JMBG;
                radnik.Adresa = r.Adresa;
                radnik.Specijalnost = r.Specijalnost;

                s.SaveOrUpdate(radnik);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion
       

        #region Vozilo
        public IList<VoziloView> GetVozila()
        {
            ISession s = DataLayer.GetSession();
            IList<VoziloView> v = new List<VoziloView>();
            IEnumerable<Vozilo> vozila = s.Query<Vozilo>().Select(p => p);
            foreach (Vozilo voz in vozila)
            {
                v.Add(new VoziloView(voz));
            }
            return v;
        }

        public VoziloView GetVozilo(string regozn)
        {
            ISession s = DataLayer.GetSession();
            Vozilo v = s.Query<Vozilo>().Where(e => e.RegOznaka == regozn).Select(p => p).FirstOrDefault();
            VoziloView vozilo = new VoziloView(v);
            return vozilo;
        }

        public int AddVozilo(Vozilo v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(v);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveVozilo(string reg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo n = s.Load<Vozilo>(reg);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateVozilo(string id, Vozilo r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Vozilo r where r.RegOznaka = " + id);
                Vozilo vozilo = query.UniqueResult<Vozilo>();

                vozilo.Boja = r.Boja;
                vozilo.Gorivo = r.Gorivo;
                vozilo.ZapreminaMotora = r.ZapreminaMotora;

                s.SaveOrUpdate(vozilo);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion
       

        #region Putnicko
        public IList<PutnickoView> GetPutnicka()
        {
            ISession s = DataLayer.GetSession();
            IList<PutnickoView> v = new List<PutnickoView>();
            IEnumerable<Putnicko> vozila = s.Query<Putnicko>().Select(p => p);
            foreach (Putnicko voz in vozila)
            {
                v.Add(new PutnickoView(voz));
            }
            return v;
        }

        public PutnickoView GetPutnicko(string regozn)
        {
            ISession s = DataLayer.GetSession();
            Putnicko v = s.Query<Putnicko>().Where(e => e.RegOznaka == regozn).Select(p => p).FirstOrDefault();
            PutnickoView putnicko = new PutnickoView(v);
            return putnicko;
        }

        public int AddPutnicko(Putnicko v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(v);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemovePutnicko(string reg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Putnicko n = s.Load<Putnicko>(reg);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdatePutnicko(string id, Putnicko r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Putnicko r where r.RegOznaka = " + id);
                Putnicko vozilo = query.UniqueResult<Putnicko>();

                vozilo.Boja = r.Boja;
                vozilo.Gorivo = r.Gorivo;
                vozilo.ZapreminaMotora = r.ZapreminaMotora;
                vozilo.BrojMesta = r.BrojMesta;

                s.SaveOrUpdate(vozilo);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion
       

        #region Radna Masina

        public IList<RadnaMasinaView> GetRadneMasine()
        {
            ISession s = DataLayer.GetSession();
            IList<RadnaMasinaView> v = new List<RadnaMasinaView>();
            IEnumerable<RadnaMasina> vozila = s.Query<RadnaMasina>().Select(p => p);
            foreach (RadnaMasina voz in vozila)
            {
                v.Add(new RadnaMasinaView(voz));
            }
            return v;
        }

        public RadnaMasinaView GetRadMasina(string regozn)
        {
            ISession s = DataLayer.GetSession();
            RadnaMasina rm= s.Query<RadnaMasina>().Where(e => e.RegOznaka == regozn).Select(p => p).FirstOrDefault();
            RadnaMasinaView v = new RadnaMasinaView(rm);
            return v;
        }

        public int AddRadMasina(RadnaMasina v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(v);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveRadnaMasina(string reg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnaMasina n = s.Load<RadnaMasina>(reg);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateRadnaMasina(string id, RadnaMasina r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from RadnaMasina r where r.RegOznaka = " + id);
                RadnaMasina vozilo = query.UniqueResult<RadnaMasina>();

                vozilo.Boja = r.Boja;
                vozilo.Gorivo = r.Gorivo;
                vozilo.ZapreminaMotora = r.ZapreminaMotora;
                vozilo.Tip = r.Tip;
                vozilo.TipPogona = r.TipPogona;

                s.SaveOrUpdate(vozilo);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion
       

        #region Teretno
        public IList<TeretnoView> GetTeretna()
        {
            ISession s = DataLayer.GetSession();
            IList<TeretnoView> v = new List<TeretnoView>();
            IEnumerable<Teretno> vozila = s.Query<Teretno>().Select(p => p);
            foreach (Teretno voz in vozila)
            {
                v.Add(new TeretnoView(voz));
            }
            return v;
        }

        public TeretnoView GetTeretno(string regozn)
        {
            ISession s = DataLayer.GetSession();
            Teretno vozilo= s.Query<Teretno>().Where(e => e.RegOznaka == regozn).Select(p => p).FirstOrDefault();
            TeretnoView v = new TeretnoView(vozilo);
            return v;
        }

        public int AddTeretno(Teretno v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(v);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveTeretno(string reg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Teretno n = s.Load<Teretno>(reg);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateTeretno(string id, Teretno r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Teretno r where r.RegOznaka = " + id);
                Teretno vozilo = query.UniqueResult<Teretno>();

                vozilo.Boja = r.Boja;
                vozilo.Gorivo = r.Gorivo;
                vozilo.ZapreminaMotora = r.ZapreminaMotora;
                vozilo.Nosivost = r.Nosivost;
                vozilo.BrojOsovina = r.BrojOsovina;

                s.SaveOrUpdate(vozilo);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion


        #region Gradiliste
        public IList<GradilisteView> GetGradilista()
        {
            ISession s = DataLayer.GetSession();
            IList<GradilisteView> g = new List<GradilisteView>();
            IEnumerable<Gradiliste> gradilista= s.Query<Gradiliste>().Select(p => p);
            foreach (Gradiliste gr in gradilista)
            {
                g.Add(new GradilisteView(gr));
            }
            return g;
        }

        public GradilisteView GetGradiliste(int id)
        {
            ISession s = DataLayer.GetSession();
            Gradiliste g= s.Query<Gradiliste>().Where(e => e.IdGradilista == id).Select(p => p).FirstOrDefault();
            GradilisteView gradiliste = new GradilisteView(g);
            return gradiliste;
        }

        public int AddGradiliste(Gradiliste v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(v);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveGradiliste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Gradiliste n = s.Load<Gradiliste>(id);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateGradiliste(int id, Gradiliste r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Gradiliste r where r.IdGradilista = " + id);
                Gradiliste gradiliste = query.UniqueResult<Gradiliste>();

                gradiliste.Tip = r.Tip;

                s.SaveOrUpdate(gradiliste);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion

     

        #region Deonica
        public IList<DeonicaView> GetDeonice()
        {
            ISession s = DataLayer.GetSession();
            IList<DeonicaView> deonice = new List<DeonicaView>();
            IEnumerable<Deonica> deonicee = s.Query<Deonica>().Select(p => p);
            foreach (Deonica d in deonicee)
            {
                deonice.Add(new DeonicaView(d));
            }

            return deonice;
        }

        public DeonicaView GetDeonica(int id)
        {
            ISession s = DataLayer.GetSession();
            Deonica deonica=s.Query<Deonica>().Where(e => e.IdDeonice == id).Select(p => p).FirstOrDefault();
            DeonicaView d = new DeonicaView(deonica);

            return d;
        }
        
        public int AddDeonica(Deonica v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(v);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveDeonica(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Deonica n = s.Load<Deonica>(id);
                s.Delete(n);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }
        
        public int UpdateDeonica(int id, Deonica r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Deonica r where r.IdDeonice = " + id);
                Deonica deonica = query.UniqueResult<Deonica>();

                deonica.KrajnjiGrad = r.KrajnjiGrad;
                deonica.PocetniGrad = r.PocetniGrad;
                deonica.PocetniKilometar = r.PocetniKilometar;
                deonica.ZavrsniKilometar = r.ZavrsniKilometar;

                s.SaveOrUpdate(deonica);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion

        

        #region Preduzece
        public IList<PreduzeceView> GetPreduzeca()
        {
            ISession s = DataLayer.GetSession();
            IList<PreduzeceView> r = new List<PreduzeceView>();
            IEnumerable<Preduzece> preduzeca = s.Query<Preduzece>().Select(p => p);
            foreach (Preduzece pr in preduzeca)
            {
                r.Add(new PreduzeceView(pr));
            }
            return r;
        }

        public PreduzeceView GetPreduzece(int id)
        {
            ISession s = DataLayer.GetSession();
            Preduzece pred= s.Query<Preduzece>().Where(e => e.IdPreduzeca == id).Select(p => p).FirstOrDefault();
            PreduzeceView preduzece = new PreduzeceView(pred);
            return preduzece;
        }

        public int AddPreduzece(Preduzece r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemovePreduzece(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Preduzece r = s.Load<Preduzece>(id);
                s.Delete(r);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdatePreduzece(int id, Preduzece r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Preduzece r where r.IdPreduzeca = " + id);
                Preduzece preduzece = query.UniqueResult<Preduzece>();

                preduzece.Naziv = r.Naziv;

                s.SaveOrUpdate(preduzece);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion

        #region Spoljni Saradnik

        public IList<SpoljniSaradnikView> GetSpoljneSaradnike()
        {
            ISession s = DataLayer.GetSession();
            IList<SpoljniSaradnikView> r = new List<SpoljniSaradnikView>();
            IEnumerable<SpoljniSaradnik> saradnici = s.Query<SpoljniSaradnik>().Select(p => p);
            foreach (SpoljniSaradnik saradnik in saradnici)
            {
                r.Add(new SpoljniSaradnikView(saradnik));
            }
            return r;
        }
        /*
        public SpoljniSaradnikView GetSpoljniSaradnik(int brug,int n)
        {
            ISession s = DataLayer.GetSession();
            SpoljniSaradnik sar= s.Query<SpoljniSaradnik>().Where(e => e.BrUgovoraODelu == brug && e.Nadzornik.IdRadnik == n).Select(p => p).FirstOrDefault();
            SpoljniSaradnikView saradnik = new SpoljniSaradnikView(sar);
            return saradnik; 
        }
        
        public int RemoveSpoljniSaradnik(Nadzornik n, int brug)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik d = s.Load<SpoljniSaradnik>;
                s.Delete(d);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }
        */
        #endregion

        #endregion

        //Za veze smo napisali samo get,remove i update(samo datumi bez referenci)

        #region Veze

        #region Duzi
        public IList<DuziView> GetDuzenja()
        {
            ISession s = DataLayer.GetSession();
            IList<DuziView> d = new List<DuziView>();
            IEnumerable<Duzi> duzenja = s.Query<Duzi>().Select(p => p);
            foreach (Duzi du in duzenja)
            {
                d.Add(new DuziView(du));
            }
            return d;
        }

        public DuziView GetDuzi(int id)
        {
            ISession s = DataLayer.GetSession();
            Duzi d= s.Query<Duzi>().Where(e => e.IdDuzenja == id).Select(p => p).FirstOrDefault();
            DuziView duzenje = new DuziView(d);
            return duzenje;
        }

        /*
        public int AddDuzi(Duzi d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(d);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        */

        public int RemoveDuzi(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Duzi d = s.Load<Duzi>(id);
                s.Delete(d);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateDuzi(int id, Duzi r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Duzi r where r.IdDuzenja = " + id);
                Duzi duzi = query.UniqueResult<Duzi>();

                duzi.DatumDo = r.DatumDo;
                duzi.DatumOd = r.DatumOd;
                
                s.SaveOrUpdate(duzi);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion


        #region Radi Na
        public IList<RadiNaView> GetRadiNa()
        {
            ISession s = DataLayer.GetSession();
            IList<RadiNaView> rn = new List<RadiNaView>();
            IEnumerable<RadiNa> lista = s.Query<RadiNa>().Select(p => p);
            foreach (RadiNa r in lista)
            {
                rn.Add(new RadiNaView(r));
            }
            return rn;
        }

        public RadiNaView GetRadiNa(int id)
        {
            ISession s = DataLayer.GetSession();
            RadiNa rn= s.Query<RadiNa>().Where(e => e.RadiNaId == id).Select(p => p).FirstOrDefault();
            RadiNaView radi = new RadiNaView(rn);
            return radi;
        }

        public int AddRadiNa(RadiNa d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(d);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveRadiNa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadiNa d = s.Load<RadiNa>(id);
                s.Delete(d);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateRadiNa(int id, RadiNa r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from RadiNa r where r.RadiNaId = " + id);
                RadiNa radn = query.UniqueResult<RadiNa>();

                radn.DatumDo = r.DatumDo;
                radn.DatumOd = r.DatumOd;

                s.SaveOrUpdate(radn);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion 
        

        #region Radna Masina Angazovana
        public IList<RadMasAngazovanaView> GetRadMasAngazovanja()
        {
            ISession s = DataLayer.GetSession();
            IList<RadMasAngazovanaView> rn = new List<RadMasAngazovanaView>();
            IEnumerable<RadMasAngazovana> lista = s.Query<RadMasAngazovana>().Select(p => p);
            foreach (RadMasAngazovana r in lista)
            {
                rn.Add(new RadMasAngazovanaView(r));
            }
            return rn;
        }

        public RadMasAngazovanaView GetRadMasAngazovana(int id)
        {
            ISession s = DataLayer.GetSession();
            RadMasAngazovana rm= s.Query<RadMasAngazovana>().Where(e => e.IdAngazovanje == id).Select(p => p).FirstOrDefault();
            RadMasAngazovanaView ang = new RadMasAngazovanaView(rm);
            return ang;
        }

        public int AddRadMasAngazovana(RadMasAngazovana d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(d);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveRadMasAngazovana(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadMasAngazovana d = s.Load<RadMasAngazovana>(id);
                s.Delete(d);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateRadMasAngazovana(int id, RadMasAngazovana r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from RadMasAngazovana r where r.IdAngazovanja = " + id);
                RadMasAngazovana duzi = query.UniqueResult<RadMasAngazovana>();
                
                duzi.DatumDo = r.DatumDo;
                duzi.DatumOd = r.DatumOd;

                s.SaveOrUpdate(duzi);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }
        #endregion
        

        #region Teretno Angazovano
        public IList<TeretnoAngazovanoView> GetTeretnoAngazovanja()
        {
            ISession s = DataLayer.GetSession();
            IList<TeretnoAngazovanoView> rn = new List<TeretnoAngazovanoView>();
            IEnumerable<TeretnoAngazovano> lista = s.Query<TeretnoAngazovano>().Select(p => p);
            foreach (TeretnoAngazovano r in lista)
            {
                rn.Add(new TeretnoAngazovanoView(r));
            }
            return rn;
        }

        public TeretnoAngazovanoView GetTeretnoAngazovano(int id)
        {
            ISession s = DataLayer.GetSession();
            TeretnoAngazovano ta= s.Query<TeretnoAngazovano>().Where(e => e.IdAngazovanje == id).Select(p => p).FirstOrDefault();
            TeretnoAngazovanoView angazovanje = new TeretnoAngazovanoView(ta);
            return angazovanje;
        }

        public int AddTeretnoAngazovano(TeretnoAngazovano d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(d);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveTeretnoAngazovano(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TeretnoAngazovano d = s.Load<TeretnoAngazovano>(id);
                s.Delete(d);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateTeretnoAngazovano(int id, TeretnoAngazovano r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from TeretnoAngazovano r where r.IdAngazovanja = " + id);
                TeretnoAngazovano duzi = query.UniqueResult<TeretnoAngazovano>();

                duzi.DatumDo = r.DatumDo;
                duzi.DatumOd = r.DatumOd;

                s.SaveOrUpdate(duzi);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion


        #region Upravlja
        public IList<UpravljaView> GetUpravljanja()
        {
            ISession s = DataLayer.GetSession();
            IList<UpravljaView> rn = new List<UpravljaView>();
            IEnumerable<Upravlja> lista = s.Query<Upravlja>().Select(p => p);
            foreach (Upravlja r in lista)
            {
                rn.Add(new UpravljaView(r));
            }
            return rn;
        }

        public UpravljaView GetUpravlja(int id)
        {
            ISession s = DataLayer.GetSession();
            Upravlja u= s.Query<Upravlja>().Where(e => e.IdUpravljanja == id).Select(p => p).FirstOrDefault();
            UpravljaView upr = new UpravljaView(u);
            return upr; 
        }

        public int AddUpravlja(Upravlja d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(d);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int RemoveUpravlja(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Upravlja d = s.Load<Upravlja>(id);
                s.Delete(d);
                s.Flush();
                s.Close();

                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int UpdateUpravlja(int id, Upravlja r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery query = s.CreateQuery("select r from Upravlja r where r.IdUpravljanja = " + id);
                Upravlja duzi = query.UniqueResult<Upravlja>();
               
                duzi.DatumDo = r.DatumDo;
                duzi.DatumOd = r.DatumOd;

                s.SaveOrUpdate(duzi);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return -1;
            }
        }

        #endregion

        #endregion
    }
}
