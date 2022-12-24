using Microsoft.EntityFrameworkCore;
using UpSchool_WebAPI.DAL.Entities;

namespace UpSchool_WebAPI.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAMAZANSURUCU; initial catalog=UpSchoolApi; integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
