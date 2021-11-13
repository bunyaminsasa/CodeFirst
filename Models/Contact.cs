using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Models
{
    public class Contact
    {
       
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar(30)"), Required(ErrorMessage = "Ad Soyad Boş Geçilemez"), Display(Name = "Adınız Soyadınız")]
        public string Name { get; set; }

        [StringLength(80), Column(TypeName = "varchar(80)"), Required(ErrorMessage = "Email Boş Geçilemez"), Display(Name = "Email Adresiniz"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(100), Column(TypeName = "varchar(100)"), Display(Name = "Konu")]
        public string Subject { get; set; }

        [StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Mesajınız")]
        public string Message { get; set; }
    }
}
