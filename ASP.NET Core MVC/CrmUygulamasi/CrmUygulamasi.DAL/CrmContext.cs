using CrmUygulamasi.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.DAL
{
    public class CrmContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=AYKUTBASTUG-ZEN;database=CRM_DB;uid=sa;pwd=1qaz2wsxA;TrustServerCertificate=true;");
            }
        }
    }
}
