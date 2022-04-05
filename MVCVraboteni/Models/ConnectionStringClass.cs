using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using MVCVraboteni.Models;



namespace MVCVraboteni.Models
{
    public class ConnectionStringClass:DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options):base(options)
        {

        }

        public DbSet<VraboteniClass> VraboteniTable { get; set; }

    }
   
}








