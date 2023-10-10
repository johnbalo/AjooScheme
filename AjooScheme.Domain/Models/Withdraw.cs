using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjooScheme.Domain.Models
{
    public  class Withdraw :BaseEntity
    {
        public int amount { get; set; }

        public int Balance { get; set; }    

    }
}
