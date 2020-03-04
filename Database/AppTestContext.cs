using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AppTestContext : DbContext
    {
        public AppTestContext() : base ("TestBitDB")
        {
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
