using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01_EFCore.Entities
{

    [Table("Todos")]
    public class Todo
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(250)]
        public string Header { get; set; }


        [StringLength(500)]
        public string? Description { get; set; }


        public bool IsCompleted { get; set; }
    }
}
