using D_Sergeevi.Modals;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sergeevi.Context
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=FinalDB")
        {
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, D_Sergeevi.Migrations.Configuration>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasKey<int>(s => s.Id);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> GradesSet { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
