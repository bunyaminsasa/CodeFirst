using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Models
{
    public class Country
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar(30)"), Display(Name = "Ülke Adı"), Required(ErrorMessage = "Ülke adı boş geçilemez"), MinLength(2,ErrorMessage ="Ülke adı 2 karakterden az olamaz")]
        public string Name { get; set; }


        [StringLength(50), Column(TypeName = "varchar(150)"), Display(Name = "Ülke Resmi")]
        public string Picture { get; set; }

        public ICollection<Tour> Tours { get; set; }
    }
}
