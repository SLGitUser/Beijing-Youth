using BeijingYouth.Pub.Models.JSJL;

namespace BeijingYouth.Pub.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BeijingYouthContext : DbContext
    {
        public BeijingYouthContext()
            : base("name=BeijingYouthContext")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(e => e.Receive)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
