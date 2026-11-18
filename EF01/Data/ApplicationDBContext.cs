using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EF01.Data
{
    public class ApplicationDBContext:DbContext
    {
         override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DAtabase=ReadMoreBooksDB;Trusted_connection=true;TrustServerCertificate=true");
        }
        public DbSet<Entities.Books> Books { get; set; }
        public DbSet<Entities.Authors> Authors { get; set; }
    }
}
