using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _10_CodeFirstYaklasimi.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Firma Adı")]
        public string CompanyName { get; set; }

        public string? Email { get; set; }
    }
}
