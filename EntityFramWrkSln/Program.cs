using EntityFramWrkSln.domain;
using EntityFramWrkSln.Migrations;
using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFramWrkSln
{
    class Program
    {
        static void Main(string[] args)
        {
      Database.SetInitializer(new MigrateDatabaseToLatestVersion<DomainContext, Configuration>());
            using (DomainContext ctx = new DomainContext())
            {

                //var user = new User
                //{
                //    Age = 12,
                //    FirstName = "Someone",
                //    LastName = "Someone last Name",
                //    UserId = Guid.NewGuid().ToString(),
                //    MyProperty = 10,
                //      MyProperto5=90

                //};
                //ctx.Users.Add(user);
                //ctx.SaveChanges();

                var user = ctx.Users.Where(x=>x.UserId== "a0bf4f89-d782-490b-b4d6-4376f1b6f893").FirstOrDefault();
                //user.Pass = "1234from code";
                ctx.SaveChanges();
              
            }

        }
    }
}
