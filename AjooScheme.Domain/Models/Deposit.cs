using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjooScheme.Domain.Models
{
    public class Deposit : BaseEntity
    {
        [Key]

        public int Id { get; set; }
        public int Amount { get; set; }

        public int Balance { get; set; }



    }
}
