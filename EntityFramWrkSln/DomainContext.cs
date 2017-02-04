using EntityFramWrkSln.domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramWrkSln
{
    class DomainContext :DbContext
    {

        public DbSet<User> Users { get; set; }
    }
}
