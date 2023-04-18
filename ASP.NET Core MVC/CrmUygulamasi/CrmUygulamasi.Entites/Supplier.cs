using CrmUygulamasi.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entites
{
    [Table("Suppliers")]
    public class Supplier : EntityBase
    {
        [Required]
        [DisplayName("Firma Adı")]
        public string CompanyName { get; set; }


        public string? Email { get; set; }

        [DisplayName("Telefon")]
        public string? Phone { get; set; }

        [DisplayName("Vergi Dairesi")]
        public string? TaxAdmin { get; set; }

        [DisplayName("Vergi Numarası")]
        public string TaxNumber { get; set; }
    }
}
