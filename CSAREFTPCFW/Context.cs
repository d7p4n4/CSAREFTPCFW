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
        }

        public DbSet<RAMetaObjektum> RAMetaObjektums { get; set; }
    }
}
