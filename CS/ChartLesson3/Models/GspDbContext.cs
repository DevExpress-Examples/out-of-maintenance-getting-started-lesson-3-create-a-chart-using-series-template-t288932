namespace ChartLesson3.Models {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GspDbContext : DbContext {
        public GspDbContext()
            : base("name=GspDbContext") {
        }

        public virtual DbSet<GSP> GSPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<GSP>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();
        }
    }
}
