using CrmUygulamasi.Entites.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrmUygulamasi.Entites
{
    [Table("Products")]
    public class Product : EntityBase
    {
        [Required(ErrorMessage = "Ürün Adı alanını boş geçemezsiniz..")]
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }


        [DisplayName("Birim Fiyatı")]
        public decimal UnitePrice { get; set; }

        [DisplayName("KDV Oran")]
        public int VatRate { get; set; }

        [DisplayName("Stok Mitkarı")]
        public int StockAmount { get; set; }

        [DisplayName("Ürün Resmi")]
        public string? ImageUrl { get; set; }
    }
}
