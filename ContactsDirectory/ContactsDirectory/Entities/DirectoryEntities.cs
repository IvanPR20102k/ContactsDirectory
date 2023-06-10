using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContactsDirectory.Entities
{
    public partial class DirectoryEntities : DbContext
    {
        public static DirectoryEntities context;
        public DirectoryEntities()
            : base("name=DirectoryEntities")
        {
        }

        public virtual DbSet<EducationalInstitution> EducationalInstitution { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public static DirectoryEntities GetContext()
        {
            if (context == null)
                context = new DirectoryEntities();
            return context;
        }
    }
}
