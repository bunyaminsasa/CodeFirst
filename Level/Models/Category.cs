using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Models
{
    public class Category
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar(30)"), Display(Name = "Kategori Adı"), Required(ErrorMessage = "Kategori adı boş geçilemez")]
        public string Name { get; set; } 
        public ICollection<News> News { get; set; }
    }
}
