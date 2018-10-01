namespace API_V2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDBTestModel : DbContext
    {
        public ShopDBTestModel()
            : base("name=ShopDBTestConnectionString")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<detailreciept> detailreciepts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
