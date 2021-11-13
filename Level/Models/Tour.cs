using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Models
{
    public class Tour
    {
       
        public int ID { get; set; }

        [StringLength(50), Column(TypeName="varchar(50)"), Display(Name="Tur Adı"), Required(ErrorMessage ="Tur adı boş geçilemez")]
        public string Name { get; set; }

        [StringLength(50), Column(TypeName = "varchar(150)"), Display(Name = "Tur Resmi")]
        public string Picture { get; set; }

        [StringLength(50), Column(TypeName = "varchar(250)"), Display(Name = "Tur Açıklaması")]
        public string Description { get; set; }

        [Column(TypeName = "text"), Display(Name = "Tur Detayı")]
        public string Detail { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int DisplayIndex { get; set; }

        public int? CountryID { get; set; }
        public Country Country { get; set; }



        //[NotMapped]
        //public bool YetkiliMi { get; set; }
    }
}
