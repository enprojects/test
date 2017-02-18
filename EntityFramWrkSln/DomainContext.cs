using EntityFramWrkSln.domain;
using EntityFramWrkSln.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramWrkSln
{
    public class DomainContext :DbContext 
    {
        public DomainContext():base("MyContext")
        {
          
        }
        public DbSet<User> Users { get; set; }
       
    }
}
