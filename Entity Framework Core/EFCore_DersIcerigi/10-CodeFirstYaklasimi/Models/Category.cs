using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_CodeFirstYaklasimi.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [DisplayName("Kategori No")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

        [StringLength(250)]
        [DisplayName("Açıklama")]
        public string Description { get; set; }


        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
