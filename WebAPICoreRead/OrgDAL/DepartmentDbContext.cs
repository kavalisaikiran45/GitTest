using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgDAL
{
   public class DepartmentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=myDataBase;User Id=sa; Password=123; ");
        }
        public DbSet<Department> departments { get; set; }

    }
}
