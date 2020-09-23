using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OVERS.Models;
namespace OVERS.Models
{
    public class CustomerDB: DbContext
    {
        public CustomerDB(DbContextOptions<CustomerDB>options):base(options)
        {

        }

        public DbSet<CustomerDB> custometbl { get; set; } //Object table mapping

    }
}
