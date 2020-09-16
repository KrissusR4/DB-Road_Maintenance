using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Putevi.Mapiranja;
using Putevi.Entiteti;

namespace Putevi
{
    public class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        //funkcija na zahtev otvara sesiju
        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S16103;Password=S16103"));

               return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DeonicaMap>())
                    .BuildSessionFactory();
               /*return Fluently.Configure()
                      .Database(cfg)
                      .Mappings(m => m.FluentMappings.Add<PreduzeceMap>())
                      .Mappings(m => m.FluentMappings.Add<GradilisteMap>())
                      .Mappings(m => m.FluentMappings.Add<RadnikMap>())
                      .Mappings(m => m.FluentMappings.Add<VoziloMap>())
                      .Mappings(m => m.FluentMappings.Add<IzvrsilacMap>())
                      .Mappings(m => m.FluentMappings.Add<NadzornikMap>())
                      .Mappings(m => m.FluentMappings.Add<SpoljniSaradnikMap>())
                      .Mappings(m => m.FluentMappings.Add<TeretnoMap>())
                      .Mappings(m => m.FluentMappings.Add<RadnaMasinaMap>())
                      .Mappings(m => m.FluentMappings.Add<PutnickoMap>())
                      .Mappings(m => m.FluentMappings.Add<DeonicaMap>())
                      .Mappings(m => m.FluentMappings.Add<DuziMap>())
                      .Mappings(m => m.FluentMappings.Add<RadiNaMap>())
                      .Mappings(m => m.FluentMappings.Add<UpravljaMap>())
                      .Mappings(m => m.FluentMappings.Add<RadMasAngazovanaMap>())
                      .Mappings(m => m.FluentMappings.Add<TeretnoAngazovanoMap>())
                      .BuildSessionFactory();*/
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }

        }
    }
}
