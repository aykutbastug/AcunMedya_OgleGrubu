using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_CodeFirstYaklasimi.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DisplayName("Ürün No")]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }


        [Required]
        public int CategoryId { get; set; }

        [DisplayName("Fiyatı")]
        public decimal Price { get; set; }

        public int StockAmount { get; set; }


        public virtual Category Category { get; set; } = new Category();
    }
}
