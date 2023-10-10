using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjooScheme.Domain.Models
{
    internal class Customer:BaseEntity
    {
        public string name { get; set; }

        [key]
        public int id { get; set; }

        public int phone_number { get; set; }    

        public string email { get; set; }

        public string address { get; set; }

        public int gender { get; set; }

        public string NextOfKin { get; set; }
    }
}
