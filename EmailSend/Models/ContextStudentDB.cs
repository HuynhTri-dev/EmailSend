using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EmailSend.Models
{
    public partial class ContextStudentDB : DbContext
    {
        public ContextStudentDB()
            : base("name=ContextStudentDB")
        {
        }

        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MSSV)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
