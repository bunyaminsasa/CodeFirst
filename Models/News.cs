using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Models
{
    public class News
    {
        public int ID { get; set; }

        [StringLength(100),Column(TypeName ="varchar(100)"), Required(ErrorMessage = "Haber Başlığı Boş Geçilemez"), Display(Name = "Haber Başlığı")]
        public string Title { get; set; }

        [StringLength(250), Column(TypeName = "varchar(250)"), Display(Name = "Açıklama")]
        public string Description { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Resim Dosyası")]
        public string Picture { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
