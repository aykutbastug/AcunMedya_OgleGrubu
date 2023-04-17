using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entites.Abstract
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
