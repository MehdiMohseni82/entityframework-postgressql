namespace SMS.Repository
{
    using SMS.Model;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class SMSDatabaseEntities : DbContext
    {
        public SMSDatabaseEntities()
            : base("name=SMSDatabaseEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Cours> Courses { get; set; }
    }
}