using CrmUygulamasi.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required(ErrorMessage = "Firma Adı alanını boş geçemezsiniz..")]
        [DisplayName("Firma Adı")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Email alanını boş geçemezsiniz..")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email adresini hatalı girdiniz..")]
        public string Email { get; set; }

        [DisplayName("Telefon")]
        [MaxLength(11, ErrorMessage = "Telefon alanı maksimum 11 karakter olmalıdır. Örn: 05123456789")]
        public string? Phone { get; set; }

        [DisplayName("Vergi Dairesi")]
        public string? TaxAdmin { get; set; }

        [DisplayName("Vergi Numarası")]
        public string? TaxNumber { get; set; }

    }
}
