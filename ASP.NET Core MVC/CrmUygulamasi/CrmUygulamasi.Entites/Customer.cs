using CrmUygulamasi.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entites
{
    [Table("Customers")]
    public class Customer : EntityBase
    {
        [Required]
        public string CompanyName { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? TaxAdmin { get; set; }

        public string TaxNumber { get; set; }

    }
}
