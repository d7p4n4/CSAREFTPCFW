using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAREFTPCFW
{
    public class Context : DbContext
    {
        public Context() : base("ConnectionString")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, CSAREFTPCFW.Migrations.Configuration>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Programkod>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ProgramKods");
            });

            modelBuilder.Entity<AdatElem>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("AdatElems");
            });

            modelBuilder.Entity<Kepernyo>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Kepernyos");
            });

            modelBuilder.Entity<Ellenorzes>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Ellenorzess");
            });

            modelBuilder.Entity<Feladat>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Feladats");
            });

            modelBuilder.Entity<Funkcio>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Funkcios");
            });

            modelBuilder.Entity<Muvelet>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Muvelets");
            });

            modelBuilder.Entity<Metodus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Metoduss");
            });

            modelBuilder.Entity<TaroltEljarasArgumentum>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("TaroltEljarasArgumentums");
            });


            modelBuilder.Entity<Adatkor>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Adatkors");
            });
                       
            modelBuilder.Entity<ConfluenceDokumentacio>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ConfluenceDokumentacios");
            });


            modelBuilder.Entity<FejlesztesiAllapot>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("FejlesztesiAllapots");
            });

            modelBuilder.Entity<KepernyoAdatkor>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("KepernyoAdatkors");
            });

            modelBuilder.Entity<KepernyoElem>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("KepernyoElems");
            });

            modelBuilder.Entity<KepernyoFejlesztesiAllapot>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("KepernyoFejlesztesiAllapots");
            });

            modelBuilder.Entity<EljarasTipus>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("EljarasTipuss");
            });

            modelBuilder.Entity<KepernyoGyujtemeny>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("KepernyoGyujtemenys");
            });

            modelBuilder.Entity<KepernyoTeszteles>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("KepernyoTeszteless");
            });

            modelBuilder.Entity<MediaObjektum>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("MediaObjektums");
            });

            modelBuilder.Entity<MegfeleltetesCsomopont>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("MegfeleltetesCsomoponts");
            });

            modelBuilder.Entity<MegfeleltetesElem>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("MegfeleltetesElemss");
            });

            modelBuilder.Entity<Teszteles>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Teszteless");
            });

            modelBuilder.Entity<Modul>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Moduls");
            });

            modelBuilder.Entity<TablaOszlop>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("TablaOszlops");
            });

            modelBuilder.Entity<Tabla>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Tablas");
            });

            modelBuilder.Entity<TaroltEljaras>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("TaroltEljarass");
            });

            modelBuilder.Entity<TaroltEljarasGyujtemeny>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("TaroltEljarasGyujtemenys");
            });

        }

        public DbSet<RAMetaObjektum> RAMetaObjektums { get; set; }
    }
}
