using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWrkDbExsit
{
   public  class Contacts
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

    }
}
