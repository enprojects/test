using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWrkDbExsit 
{
    public class DomainCtx : DbContext
    {
        public DomainCtx() :base("northwind")
        {
            Database.SetInitializer<DomainCtx>(null);
        }
       public DbSet<Contacts> Contacts { get; set; }
    }
}
