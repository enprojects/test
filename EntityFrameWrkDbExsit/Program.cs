using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWrkDbExsit
{




    class Program
    {
        static void Main(string[] args)
        {
          //  Database.SetInitializer<DomainCtx>(null);
            using (DomainCtx ctx = new DomainCtx())
            {
                var contacts = ctx.Contacts.ToList();
                foreach (var item in contacts)
                {
                    Console.WriteLine("{0},{1},{2},{3}", 
                        item.ContactID, 
                        item.ContactName,
                        item.Country,
                        item.City);
                }

            }
        }
    }
}
